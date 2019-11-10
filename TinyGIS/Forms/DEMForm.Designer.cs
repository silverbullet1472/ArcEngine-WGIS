namespace TinyGIS.Forms
{
    partial class DEMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEMForm));
            this.axSceneControl = new ESRI.ArcGIS.Controls.AxSceneControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenDEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axSceneControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axSceneControl
            // 
            this.axSceneControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSceneControl.Location = new System.Drawing.Point(0, 28);
            this.axSceneControl.Name = "axSceneControl";
            this.axSceneControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSceneControl.OcxState")));
            this.axSceneControl.Size = new System.Drawing.Size(969, 607);
            this.axSceneControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDEMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenDEMToolStripMenuItem
            // 
            this.OpenDEMToolStripMenuItem.Name = "OpenDEMToolStripMenuItem";
            this.OpenDEMToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.OpenDEMToolStripMenuItem.Text = "打开数据";
            this.OpenDEMToolStripMenuItem.Click += new System.EventHandler(this.OpenDEMToolStripMenuItem_Click);
            // 
            // DEMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 635);
            this.Controls.Add(this.axSceneControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DEMForm";
            this.Text = "DEMForm";
            ((System.ComponentModel.ISupportInitialize)(this.axSceneControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxSceneControl axSceneControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenDEMToolStripMenuItem;
    }
}