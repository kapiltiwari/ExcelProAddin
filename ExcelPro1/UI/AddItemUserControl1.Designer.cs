namespace ExcelPro1.UI
{
    partial class AddItemUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SaveItem = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_len = new System.Windows.Forms.TextBox();
            this.Len = new System.Windows.Forms.Label();
            this.tb_fieldText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tb_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SaveItem);
            this.panel1.Controls.Add(this.tb_desc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_len);
            this.panel1.Controls.Add(this.Len);
            this.panel1.Controls.Add(this.tb_fieldText);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.tb_field);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 725);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_SaveItem
            // 
            this.btn_SaveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveItem.Location = new System.Drawing.Point(52, 305);
            this.btn_SaveItem.Name = "btn_SaveItem";
            this.btn_SaveItem.Size = new System.Drawing.Size(131, 23);
            this.btn_SaveItem.TabIndex = 8;
            this.btn_SaveItem.Text = "Save";
            this.btn_SaveItem.UseVisualStyleBackColor = true;
            this.btn_SaveItem.Click += new System.EventHandler(this.btn_SaveItem_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.Location = new System.Drawing.Point(47, 236);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(167, 21);
            this.tb_desc.TabIndex = 7;
            this.tb_desc.TextChanged += new System.EventHandler(this.tb_desc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_len
            // 
            this.tb_len.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_len.Location = new System.Drawing.Point(47, 170);
            this.tb_len.Name = "tb_len";
            this.tb_len.Size = new System.Drawing.Size(167, 21);
            this.tb_len.TabIndex = 5;
            this.tb_len.TextChanged += new System.EventHandler(this.tb_len_TextChanged);
            // 
            // Len
            // 
            this.Len.AutoSize = true;
            this.Len.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Len.Location = new System.Drawing.Point(4, 174);
            this.Len.Name = "Len";
            this.Len.Size = new System.Drawing.Size(33, 16);
            this.Len.TabIndex = 4;
            this.Len.Text = "Len";
            this.Len.Click += new System.EventHandler(this.Len_Click);
            // 
            // tb_fieldText
            // 
            this.tb_fieldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fieldText.Location = new System.Drawing.Point(47, 104);
            this.tb_fieldText.Name = "tb_fieldText";
            this.tb_fieldText.Size = new System.Drawing.Size(167, 21);
            this.tb_fieldText.TabIndex = 3;
            this.tb_fieldText.TextChanged += new System.EventHandler(this.tb_fieldText_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(4, 108);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 16);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // tb_field
            // 
            this.tb_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_field.Location = new System.Drawing.Point(47, 38);
            this.tb_field.Name = "tb_field";
            this.tb_field.Size = new System.Drawing.Size(167, 21);
            this.tb_field.TabIndex = 1;
            this.tb_field.TextChanged += new System.EventHandler(this.tb_field_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddItemUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddItemUserControl1";
            this.Size = new System.Drawing.Size(252, 744);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SaveItem;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_len;
        private System.Windows.Forms.Label Len;
        private System.Windows.Forms.TextBox tb_fieldText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tb_field;
        private System.Windows.Forms.Label label1;
    }
}
