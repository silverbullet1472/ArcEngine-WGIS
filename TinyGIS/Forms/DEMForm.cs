using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesRaster;

namespace TinyGIS.Forms
{
    public partial class DEMForm : Form
    {
        public DEMForm()
        {
            InitializeComponent();

        }

        private void OpenDEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = null;
            IRasterLayer pRasterLayer = null;
            pRasterLayer = new RasterLayerClass();
            OpenFileDialog OpenDEM = new OpenFileDialog(); //可实例化类
            OpenDEM.InitialDirectory = "C:";
            OpenDEM.Filter = "Shape文件(*.sxd)|*.sxd";
            // Gets or sets the file dialog box title. (Inherited from FileDialog.)
            OpenDEM.Title = "打开数据"; // OpenFileDialog类的属性Title
            if (OpenDEM.ShowDialog() == DialogResult.OK)
            {
                //从打开对话框中得到打开文件的全路径
                fileName = OpenDEM.FileName;
                axSceneControl.LoadSxFile(fileName);
                axSceneControl.Refresh();
            }
        }
    }
}
