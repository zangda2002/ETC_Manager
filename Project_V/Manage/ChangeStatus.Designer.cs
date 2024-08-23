namespace Project_V.Manage
{
    partial class ChangeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStatus));
            this.lb1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.dsads = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.Location = new System.Drawing.Point(12, 41);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(160, 52);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Default";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(259, 168);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(320, 22);
            this.txtname.TabIndex = 1;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(259, 218);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(320, 22);
            this.txtacc.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(259, 272);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(320, 22);
            this.txtpass.TabIndex = 1;
            // 
            // dsads
            // 
            this.dsads.AutoSize = true;
            this.dsads.Location = new System.Drawing.Point(121, 171);
            this.dsads.Name = "dsads";
            this.dsads.Size = new System.Drawing.Size(103, 16);
            this.dsads.TabIndex = 2;
            this.dsads.Text = "Tên người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa ngay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsads);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lb1);
            this.DoubleBuffered = true;
            this.Name = "ChangeStatus";
            this.Text = "ChangeStatus";
            this.Load += new System.EventHandler(this.ChangeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label dsads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}