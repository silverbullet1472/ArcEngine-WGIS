using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.NetworkAnalysis;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.NetworkAnalyst;
using ESRI.ArcGIS.DataSourcesGDB;
using WGIS.Forms;
using ESRI.ArcGIS.Display;
using System.Drawing.Drawing2D;
using ESRI.ArcGIS.Server;
using System.Configuration;

namespace WGIS.Classes
{
    /// <summary>
    /// ���·������
    /// </summary>
    [Guid("4ffd8016-0be3-4730-8fc3-924b0ebc23b6")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("WGIS.Classes.RouteQuery")]
    public sealed class RouteQuery : BaseTool
    {
        private AxMapControl axMapControl;
        public INAContext m_NAContext;//�������������
        private INetworkDataset networkDataset;//�������ݼ�
        public IFeatureWorkspace pFWorkspace;
        public IFeatureClass inputFClass;//��stops���ݼ�
        private IFeatureDataset featureDataset;
        public bool networkanalasia = false;//�ж��Ƿ�����·�߰�ť������������׶�
        public int clickedcount = 0;//mapcontrol�ӵ���ʾ����
        private IActiveView m_ipActiveView;
        public IGraphicsContainer PGC;
        private IMap m_ipMap;

        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsCommands.Register(regKey);

        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsCommands.Unregister(regKey);

        }

        #endregion
        #endregion

        private IHookHelper m_hookHelper;

        public RouteQuery(AxMapControl axMapControl)
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text 
            base.m_caption = "·����ѯ";  //localizable text 
            base.m_message = "·����ѯ";  //localizable text
            base.m_toolTip = "·����ѯ";  //localizable text
            base.m_name = "RouteQuery";   //unique id, non-localizable (e.g. "MyCategory_MyTool")
            try
            {
                //
                // TODO: change resource name if necessary
                //
                this.axMapControl = axMapControl;
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        /// <summary>
        /// ��ʼ������ȡshp���������ݼ�
        /// </summary>
        private void initialize()
        {
            axMapControl.ActiveView.Clear();
            axMapControl.ActiveView.Refresh();
            //��ȡ��ǰӦ�ó����Ŀ¼����
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            int t;
            for (t = 0; t < path.Length; t++)
            {
                if (path.Substring(t, 4) == "WGIS")
                {
                    break;
                }
            }
            //����Ŀ¼���ƻ�ȡ���ݴ�ȡ·��
            string name = path.Substring(0, t-1) + "\\DATA\\data\\RouteQuery.mdb";
            //�򿪹����ռ�
            pFWorkspace = OpenWorkspace(name) as IFeatureWorkspace;
            //���������ݼ�
            networkDataset = OpenNetworkDataset(pFWorkspace as IWorkspace, "road_ND", "road");
            //����������������ģ�����һ�ֽ����ϵ
            m_NAContext = CreateSolverContext(networkDataset);
            //�����ݼ�
            inputFClass = pFWorkspace.OpenFeatureClass("stops");
            IFeatureCursor pFeatureCursor = inputFClass.Search(null, false);
            IFeature pFeature = pFeatureCursor.NextFeature();
            while (pFeature != null)
            {
                pFeature.Delete();
                pFeature = pFeatureCursor.NextFeature();
            }  
            //road_ND_JUNCTIONSͼ��
            IFeatureLayer vertex = new FeatureLayerClass();
            vertex.FeatureClass = pFWorkspace.OpenFeatureClass("road_ND_Junctions");
            vertex.Name = vertex.FeatureClass.AliasName;
            axMapControl.AddLayer(vertex, 0);
            //roadͼ��
            IFeatureLayer road3;
            road3 = new FeatureLayerClass();
            road3.FeatureClass = pFWorkspace.OpenFeatureClass("road");
            road3.Name = road3.FeatureClass.AliasName;
            axMapControl.AddLayer(road3, 0);
            //Ϊnetworkdataset����һ��ͼ�㣬������ͼ����ӵ�axmapcontrol��
            ILayer pLayer;//����ͼ��
            INetworkLayer pNetworkLayer;
            pNetworkLayer = new NetworkLayerClass();
            pNetworkLayer.NetworkDataset = networkDataset;
            pLayer = pNetworkLayer as ILayer;
            pLayer.Name = "Network Dataset";
            axMapControl.AddLayer(pLayer, 0);
            //����һ���������ͼ�㲢��ӵ�axmaptrol��
            ILayer layer1;
            INALayer nalayer = m_NAContext.Solver.CreateLayer(m_NAContext);
            layer1 = nalayer as ILayer;
            layer1.Name = m_NAContext.Solver.DisplayName;
            axMapControl.AddLayer(layer1, 0);
            m_ipActiveView = axMapControl.ActiveView;
            m_ipMap = m_ipActiveView.FocusMap;
            PGC = m_ipMap as IGraphicsContainer;
        }

        /// <summary>
        /// �򿪹����ռ�
        /// </summary>
        public IWorkspace OpenWorkspace(string strMDBName)
        {
            IWorkspaceFactory workspaceFactory;
            workspaceFactory = new AccessWorkspaceFactoryClass();
            return workspaceFactory.OpenFromFile(strMDBName, 0);
        }

        /// <summary>
        /// ���������ݼ�
        /// </summary>
        public INetworkDataset OpenNetworkDataset(IWorkspace networkDatasetWorkspace, System.String networkDatasetName, System.String featureDatasetName)
        {
            if (networkDatasetWorkspace == null || networkDatasetName == "" || featureDatasetName == null)
            {
                return null;
            }
            IFeatureWorkspace featureWorkspace = networkDatasetWorkspace as IFeatureWorkspace;
            featureDataset = featureWorkspace.OpenFeatureDataset(featureDatasetName);
            IFeatureDatasetExtensionContainer featureDatasetExtensionContainer = featureDataset as IFeatureDatasetExtensionContainer;
            IFeatureDatasetExtension featureDatasetExtension = featureDatasetExtensionContainer.FindExtension(esriDatasetType.esriDTNetworkDataset);
            IDatasetContainer3 datasetContainer3 = (IDatasetContainer3)featureDatasetExtension;
            if (datasetContainer3 == null)
                return null;
            IDataset dataset = datasetContainer3.get_DatasetByName(esriDatasetType.esriDTNetworkDataset, networkDatasetName);
            return dataset as INetworkDataset;
        }

        /// <summary>
        /// �����������������
        /// </summary>
        public INAContext CreateSolverContext(INetworkDataset networkDataset)
        {
            //��ȡ����������������������IDENETWORKDATASET���Ͳ���
            IDENetworkDataset deNDS = GetDENetworkDataset(networkDataset);
            INASolver naSolver;
            naSolver = new NARouteSolver();
            INAContextEdit contextEdit = naSolver.CreateContext(deNDS, naSolver.Name) as INAContextEdit;
            contextEdit.Bind(networkDataset, new GPMessagesClass());
            return contextEdit as INAContext;
        }

        /// <summary>
        /// �õ�����������������������IDENETWORKDATASET���Ͳ���
        /// </summary>
        public IDENetworkDataset GetDENetworkDataset(INetworkDataset networkDataset)
        {
            //������������ݼ�QI��ӵ�DATASETCOMPOENT
            IDatasetComponent dstComponent;
            dstComponent = networkDataset as IDatasetComponent;
            //�������Ԫ��
            return dstComponent.DataElement as IDENetworkDataset;
        }

        /// <summary>
        /// ��ȡ�������������ĵ�
        /// </summary>
        public void CreateFeature(IFeatureClass featureClass, IPointCollection PointCollection)
        {
            //�Ƿ�Ϊ��ͼ��
            if (featureClass.ShapeType != esriGeometryType.esriGeometryPoint)
            {
                return;
            }

            for (int i = 0; i < PointCollection.PointCount; i++)
            {
               IFeature feature = featureClass.CreateFeature();

               feature.Shape = PointCollection.get_Point(i);
               IRowSubtypes rowSubtypes = (IRowSubtypes)feature;
               feature.Store();
            }
        }

        /// <summary>
        /// ����ͣ����
        /// </summary>
        public void loadNANetworkLocations(string strNAClassName, IFeatureClass inputFC, double snapTolerance)
        {
            INAClass naClass;
            INamedSet classes;
            classes = m_NAContext.NAClasses;
            naClass = classes.get_ItemByName(strNAClassName) as INAClass;
            //ɾ��naClasses����ӵ���
            naClass.DeleteAllRows();
            //��������������������ݲ�ֵ
            INAClassLoader classLoader = new NAClassLoader();
            classLoader.Locator = m_NAContext.Locator;
            if (snapTolerance > 0) classLoader.Locator.SnapTolerance = snapTolerance;
            classLoader.NAClass = naClass;
            //�ֶ�ƥ��
            INAClassFieldMap pNAClassFieldMap = new NAClassFieldMap();
            pNAClassFieldMap.CreateMapping(naClass.ClassDefinition, inputFC.Fields);
            classLoader.FieldMap = pNAClassFieldMap;
            //�������������
            int rowsln = 0;
            int rowsLocated = 0;
            IFeatureCursor featureCursor = inputFC.Search(null, true);
            classLoader.Load((ICursor)featureCursor, null, ref rowsln, ref rowsLocated);
            ((INAContextEdit)m_NAContext).ContextChanged();
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this tool is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            if (m_hookHelper == null)
                m_hookHelper = new HookHelperClass();

            m_hookHelper.Hook = hook;

            // TODO:  Add RouteQuery.OnCreate implementation
            networkanalasia = true;
            initialize();
        }

        /// <summary>
        /// Occurs when this tool is clicked
        /// </summary>
        public override void OnClick()
        {
            // TODO: Add RouteQuery.OnClick implementation
 
        }

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add RouteQuery.OnMouseDown implementation
            if (networkanalasia == true)
            {
                IPointCollection m_ipPoints;//����㼯��
                IPoint ipNew;
                m_ipPoints = new MultipointClass();
                ipNew = axMapControl.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                object o = Type.Missing;
                m_ipPoints.AddPoint(ipNew, ref o, ref o);
                CreateFeature(inputFClass, m_ipPoints);//��ȡ������������
                //������ĵ���ʾ����
                IElement element;
                ITextElement textelement = new TextElementClass();
                element = textelement as IElement;
                ITextSymbol textSymbol = new ESRI.ArcGIS.Display.TextSymbol();

                textelement.Symbol = textSymbol;
                clickedcount++;
                textelement.Text = clickedcount.ToString();
                element.Geometry = m_ipActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                PGC.AddElement(element, 0);

                m_ipActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
            }
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add RouteQuery.OnMouseMove implementation
        }

        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add RouteQuery.OnMouseUp implementation
        }
        #endregion
    }
}
