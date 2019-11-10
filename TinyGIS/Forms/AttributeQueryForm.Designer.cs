namespace TinyGIS.Forms
{
    partial class AttributeQueryForm
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
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.listBoxField = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.btnlike = new System.Windows.Forms.Button();
            this.btnor = new System.Windows.Forms.Button();
            this.btnloe = new System.Windows.Forms.Button();
            this.btnmoe = new System.Windows.Forms.Button();
            this.btnless = new System.Windows.Forms.Button();
            this.btnmore = new System.Windows.Forms.Button();
            this.btnis = new System.Windows.Forms.Button();
            this.btnunequal = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnempty = new System.Windows.Forms.Button();
            this.btnspace = new System.Windows.Forms.Button();
            this.btnbetween = new System.Windows.Forms.Button();
            this.btncharacter = new System.Windows.Forms.Button();
            this.btnnull = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLayer
            // 
            this.cboLayer.FormattingEnabled = true;
            this.cboLayer.Location = new System.Drawing.Point(141, 22);
            this.cboLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Size = new System.Drawing.Size(383, 23);
            this.cboLayer.TabIndex = 0;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // listBoxField
            // 
            this.listBoxField.FormattingEnabled = true;
            this.listBoxField.ItemHeight = 15;
            this.listBoxField.Location = new System.Drawing.Point(68, 78);
            this.listBoxField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxField.Name = "listBoxField";
            this.listBoxField.Size = new System.Drawing.Size(213, 199);
            this.listBoxField.TabIndex = 1;
            this.listBoxField.SelectedIndexChanged += new System.EventHandler(this.listBoxField_SelectedIndexChanged);
            this.listBoxField.DoubleClick += new System.EventHandler(this.listBoxField_DoubleClick);
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 15;
            this.listBoxValue.Location = new System.Drawing.Point(310, 78);
            this.listBoxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(214, 199);
            this.listBoxValue.TabIndex = 2;
            this.listBoxValue.DoubleClick += new System.EventHandler(this.listBoxValue_DoubleClick);
            // 
            // btnlike
            // 
            this.btnlike.Font = new System.Drawing.Font("Arial", 9F);
            this.btnlike.Location = new System.Drawing.Point(358, 312);
            this.btnlike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(67, 33);
            this.btnlike.TabIndex = 3;
            this.btnlike.Text = "like";
            this.btnlike.UseVisualStyleBackColor = true;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // btnor
            // 
            this.btnor.Font = new System.Drawing.Font("Arial", 9F);
            this.btnor.Location = new System.Drawing.Point(358, 360);
            this.btnor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnor.Name = "btnor";
            this.btnor.Size = new System.Drawing.Size(67, 33);
            this.btnor.TabIndex = 4;
            this.btnor.Text = "or";
            this.btnor.UseVisualStyleBackColor = true;
            this.btnor.Click += new System.EventHandler(this.btnor_Click);
            // 
            // btnloe
            // 
            this.btnloe.Font = new System.Drawing.Font("Arial", 9F);
            this.btnloe.Location = new System.Drawing.Point(268, 360);
            this.btnloe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnloe.Name = "btnloe";
            this.btnloe.Size = new System.Drawing.Size(67, 33);
            this.btnloe.TabIndex = 5;
            this.btnloe.Text = "<=";
            this.btnloe.UseVisualStyleBackColor = true;
            this.btnloe.Click += new System.EventHandler(this.btnloe_Click);
            // 
            // btnmoe
            // 
            this.btnmoe.Font = new System.Drawing.Font("Arial", 9F);
            this.btnmoe.Location = new System.Drawing.Point(170, 360);
            this.btnmoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmoe.Name = "btnmoe";
            this.btnmoe.Size = new System.Drawing.Size(67, 33);
            this.btnmoe.TabIndex = 6;
            this.btnmoe.Text = ">=";
            this.btnmoe.UseVisualStyleBackColor = true;
            this.btnmoe.Click += new System.EventHandler(this.btnmoe_Click_1);
            // 
            // btnless
            // 
            this.btnless.Font = new System.Drawing.Font("Arial", 9F);
            this.btnless.Location = new System.Drawing.Point(68, 360);
            this.btnless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnless.Name = "btnless";
            this.btnless.Size = new System.Drawing.Size(67, 33);
            this.btnless.TabIndex = 7;
            this.btnless.Text = "<";
            this.btnless.UseVisualStyleBackColor = true;
            this.btnless.Click += new System.EventHandler(this.btnless_Click);
            // 
            // btnmore
            // 
            this.btnmore.Font = new System.Drawing.Font("Arial", 9F);
            this.btnmore.Location = new System.Drawing.Point(457, 312);
            this.btnmore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(67, 33);
            this.btnmore.TabIndex = 8;
            this.btnmore.Text = ">";
            this.btnmore.UseVisualStyleBackColor = true;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // btnis
            // 
            this.btnis.Font = new System.Drawing.Font("Arial", 9F);
            this.btnis.Location = new System.Drawing.Point(268, 312);
            this.btnis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnis.Name = "btnis";
            this.btnis.Size = new System.Drawing.Size(67, 33);
            this.btnis.TabIndex = 9;
            this.btnis.Text = "is";
            this.btnis.UseVisualStyleBackColor = true;
            this.btnis.Click += new System.EventHandler(this.btnis_Click);
            // 
            // btnunequal
            // 
            this.btnunequal.Font = new System.Drawing.Font("Arial", 9F);
            this.btnunequal.Location = new System.Drawing.Point(170, 312);
            this.btnunequal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnunequal.Name = "btnunequal";
            this.btnunequal.Size = new System.Drawing.Size(67, 33);
            this.btnunequal.TabIndex = 10;
            this.btnunequal.Text = "!=";
            this.btnunequal.UseVisualStyleBackColor = true;
            this.btnunequal.Click += new System.EventHandler(this.btnunequal_Click);
            // 
            // btnequal
            // 
            this.btnequal.Font = new System.Drawing.Font("Arial", 9F);
            this.btnequal.Location = new System.Drawing.Point(68, 312);
            this.btnequal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(67, 33);
            this.btnequal.TabIndex = 11;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnempty
            // 
            this.btnempty.Location = new System.Drawing.Point(426, 407);
            this.btnempty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnempty.Name = "btnempty";
            this.btnempty.Size = new System.Drawing.Size(98, 33);
            this.btnempty.TabIndex = 13;
            this.btnempty.Text = "清空";
            this.btnempty.UseVisualStyleBackColor = true;
            this.btnempty.Click += new System.EventHandler(this.btnempty_Click);
            // 
            // btnspace
            // 
            this.btnspace.Font = new System.Drawing.Font("宋体", 9F);
            this.btnspace.Location = new System.Drawing.Point(300, 407);
            this.btnspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(98, 33);
            this.btnspace.TabIndex = 14;
            this.btnspace.Text = "空格";
            this.btnspace.UseVisualStyleBackColor = true;
            this.btnspace.Click += new System.EventHandler(this.btnspace_Click);
            // 
            // btnbetween
            // 
            this.btnbetween.Font = new System.Drawing.Font("Arial", 9F);
            this.btnbetween.Location = new System.Drawing.Point(170, 407);
            this.btnbetween.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbetween.Name = "btnbetween";
            this.btnbetween.Size = new System.Drawing.Size(98, 33);
            this.btnbetween.TabIndex = 15;
            this.btnbetween.Text = "between";
            this.btnbetween.UseVisualStyleBackColor = true;
            this.btnbetween.Click += new System.EventHandler(this.btnbetween_Click);
            // 
            // btncharacter
            // 
            this.btncharacter.Font = new System.Drawing.Font("Arial", 9F);
            this.btncharacter.Location = new System.Drawing.Point(68, 407);
            this.btncharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncharacter.Name = "btncharacter";
            this.btncharacter.Size = new System.Drawing.Size(67, 33);
            this.btncharacter.TabIndex = 16;
            this.btncharacter.Text = "\'\'";
            this.btncharacter.UseVisualStyleBackColor = true;
            this.btncharacter.Click += new System.EventHandler(this.btncharacter_Click);
            // 
            // btnnull
            // 
            this.btnnull.Font = new System.Drawing.Font("Arial", 9F);
            this.btnnull.Location = new System.Drawing.Point(457, 360);
            this.btnnull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnull.Name = "btnnull";
            this.btnnull.Size = new System.Drawing.Size(67, 33);
            this.btnnull.TabIndex = 17;
            this.btnnull.Text = "null";
            this.btnnull.UseVisualStyleBackColor = true;
            this.btnnull.Click += new System.EventHandler(this.btnnull_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBoxSql);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 459);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 69);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select * From Table Where";
            // 
            // textBoxSql
            // 
            this.textBoxSql.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSql.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSql.Location = new System.Drawing.Point(0, 22);
            this.textBoxSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(455, 47);
            this.textBoxSql.TabIndex = 19;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 544);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 29);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "查找";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 544);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(68, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 21);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "字段：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(310, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 21);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "取值：";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(68, 288);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 21);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "表达式：";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(68, 22);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 21);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "图层：";
            // 
            // AttributeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 582);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnull);
            this.Controls.Add(this.btncharacter);
            this.Controls.Add(this.btnbetween);
            this.Controls.Add(this.btnspace);
            this.Controls.Add(this.btnempty);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnunequal);
            this.Controls.Add(this.btnis);
            this.Controls.Add(this.btnmore);
            this.Controls.Add(this.btnless);
            this.Controls.Add(this.btnmoe);
            this.Controls.Add(this.btnloe);
            this.Controls.Add(this.btnor);
            this.Controls.Add(this.btnlike);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listBoxField);
            this.Controls.Add(this.cboLayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AttributeQueryForm";
            this.Text = "属性查询";
            this.Load += new System.EventHandler(this.AttributeQueryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.ListBox listBoxField;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btnor;
        private System.Windows.Forms.Button btnloe;
        private System.Windows.Forms.Button btnmoe;
        private System.Windows.Forms.Button btnless;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Button btnis;
        private System.Windows.Forms.Button btnunequal;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnempty;
        private System.Windows.Forms.Button btnspace;
        private System.Windows.Forms.Button btnbetween;
        private System.Windows.Forms.Button btncharacter;
        private System.Windows.Forms.Button btnnull;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}