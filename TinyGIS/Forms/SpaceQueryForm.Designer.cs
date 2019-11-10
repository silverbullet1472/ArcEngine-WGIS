namespace TinyGIS.Forms
{
    partial class SpaceQueryForm
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
            this.checkListLayer = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumericDistance = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.unit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // checkListLayer
            // 
            this.checkListLayer.FormattingEnabled = true;
            this.checkListLayer.Location = new System.Drawing.Point(11, 44);
            this.checkListLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkListLayer.Name = "checkListLayer";
            this.checkListLayer.Size = new System.Drawing.Size(464, 84);
            this.checkListLayer.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(11, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "目标图层：";
            // 
            // NumericDistance
            // 
            this.NumericDistance.Location = new System.Drawing.Point(124, 159);
            this.NumericDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumericDistance.Name = "NumericDistance";
            this.NumericDistance.Size = new System.Drawing.Size(107, 25);
            this.NumericDistance.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(12, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "搜索半径：";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(395, 198);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(80, 29);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 198);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 29);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(252, 158);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(147, 25);
            this.unit.TabIndex = 14;
            // 
            // SpaceQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 247);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NumericDistance);
            this.Controls.Add(this.checkListLayer);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SpaceQueryForm";
            this.Text = "空间查询";
            this.Load += new System.EventHandler(this.SpaceQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListLayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown NumericDistance;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox unit;
    }
}