namespace KiemTra
{
    partial class Form2
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
            this.txt_mal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Mal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mal
            // 
            this.txt_mal.Location = new System.Drawing.Point(408, 110);
            this.txt_mal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_mal.Name = "txt_mal";
            this.txt_mal.Size = new System.Drawing.Size(260, 38);
            this.txt_mal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp";
            // 
            // txt_tenl
            // 
            this.txt_tenl.Location = new System.Drawing.Point(408, 238);
            this.txt_tenl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_tenl.Name = "txt_tenl";
            this.txt_tenl.Size = new System.Drawing.Size(260, 38);
            this.txt_tenl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(1069, 117);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(260, 38);
            this.txt_sl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mal,
            this.Tenlop,
            this.Soluong});
            this.dgv2.Location = new System.Drawing.Point(235, 353);
            this.dgv2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 102;
            this.dgv2.Size = new System.Drawing.Size(972, 303);
            this.dgv2.TabIndex = 2;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            // 
            // Mal
            // 
            this.Mal.HeaderText = "Mã lớp";
            this.Mal.MinimumWidth = 12;
            this.Mal.Name = "Mal";
            this.Mal.Width = 250;
            // 
            // Tenlop
            // 
            this.Tenlop.HeaderText = "Tên lớp";
            this.Tenlop.MinimumWidth = 12;
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Width = 250;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 12;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 250;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(233, 729);
            this.btn_them.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(200, 55);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(584, 729);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(200, 55);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(954, 729);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(200, 55);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenl);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_mal);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.Text = "Thuoc";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}