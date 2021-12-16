
namespace Project_VTT
{
    partial class Dangnhap
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
            this.lbl_Quenmk = new System.Windows.Forms.LinkLabel();
            this.lbl_Dangky = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_Tentk = new System.Windows.Forms.TextBox();
            this.tbx_Matkhau = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quenmk
            // 
            this.lbl_Quenmk.AutoSize = true;
            this.lbl_Quenmk.Location = new System.Drawing.Point(104, 397);
            this.lbl_Quenmk.Name = "lbl_Quenmk";
            this.lbl_Quenmk.Size = new System.Drawing.Size(105, 17);
            this.lbl_Quenmk.TabIndex = 3;
            this.lbl_Quenmk.TabStop = true;
            this.lbl_Quenmk.Text = "Quên mật khẩu";
            // 
            // lbl_Dangky
            // 
            this.lbl_Dangky.AutoSize = true;
            this.lbl_Dangky.Location = new System.Drawing.Point(397, 397);
            this.lbl_Dangky.Name = "lbl_Dangky";
            this.lbl_Dangky.Size = new System.Drawing.Size(62, 17);
            this.lbl_Dangky.TabIndex = 4;
            this.lbl_Dangky.TabStop = true;
            this.lbl_Dangky.Text = "Đăng Ký";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(252, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbx_Tentk
            // 
            this.tbx_Tentk.Location = new System.Drawing.Point(200, 258);
            this.tbx_Tentk.Multiline = true;
            this.tbx_Tentk.Name = "tbx_Tentk";
            this.tbx_Tentk.Size = new System.Drawing.Size(207, 30);
            this.tbx_Tentk.TabIndex = 6;
            // 
            // tbx_Matkhau
            // 
            this.tbx_Matkhau.Location = new System.Drawing.Point(200, 318);
            this.tbx_Matkhau.Multiline = true;
            this.tbx_Matkhau.Name = "tbx_Matkhau";
            this.tbx_Matkhau.Size = new System.Drawing.Size(207, 30);
            this.tbx_Matkhau.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_VTT.Properties.Resources.password_64px;
            this.pictureBox3.Location = new System.Drawing.Point(107, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_VTT.Properties.Resources.user_64px;
            this.pictureBox2.Location = new System.Drawing.Point(107, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_VTT.Properties.Resources.hot_beverage_48px;
            this.pictureBox1.Location = new System.Drawing.Point(200, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dangnhap
            // 
            this.ClientSize = new System.Drawing.Size(592, 508);
            this.Controls.Add(this.tbx_Matkhau);
            this.Controls.Add(this.tbx_Tentk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Dangky);
            this.Controls.Add(this.lbl_Quenmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lbl_Quenmk;
        private System.Windows.Forms.LinkLabel lbl_Dangky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_Tentk;
        private System.Windows.Forms.TextBox tbx_Matkhau;
    }
}