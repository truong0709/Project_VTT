
namespace Project_VTT.DAO
{
    partial class Dangky
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
            this.tbx_Tentaikhoan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_Matkhau = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbx_Xacnhanmk = new System.Windows.Forms.TextBox();
            this.btn_Dangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Tentaikhoan
            // 
            this.tbx_Tentaikhoan.Location = new System.Drawing.Point(202, 226);
            this.tbx_Tentaikhoan.Multiline = true;
            this.tbx_Tentaikhoan.Name = "tbx_Tentaikhoan";
            this.tbx_Tentaikhoan.Size = new System.Drawing.Size(318, 25);
            this.tbx_Tentaikhoan.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(39, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tên tài khoản";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(39, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Mật khẩu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbx_Matkhau
            // 
            this.tbx_Matkhau.Location = new System.Drawing.Point(202, 257);
            this.tbx_Matkhau.Multiline = true;
            this.tbx_Matkhau.Name = "tbx_Matkhau";
            this.tbx_Matkhau.Size = new System.Drawing.Size(318, 25);
            this.tbx_Matkhau.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(39, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xác nhận mật khẩu";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tbx_Xacnhanmk
            // 
            this.tbx_Xacnhanmk.Location = new System.Drawing.Point(202, 288);
            this.tbx_Xacnhanmk.Multiline = true;
            this.tbx_Xacnhanmk.Name = "tbx_Xacnhanmk";
            this.tbx_Xacnhanmk.Size = new System.Drawing.Size(318, 25);
            this.tbx_Xacnhanmk.TabIndex = 6;
            // 
            // btn_Dangky
            // 
            this.btn_Dangky.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Dangky.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Dangky.Location = new System.Drawing.Point(238, 341);
            this.btn_Dangky.Name = "btn_Dangky";
            this.btn_Dangky.Size = new System.Drawing.Size(118, 58);
            this.btn_Dangky.TabIndex = 10;
            this.btn_Dangky.Text = "Đăng ký";
            this.btn_Dangky.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_VTT.Properties.Resources.hot_beverage_48px;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 423);
            this.Controls.Add(this.btn_Dangky);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbx_Xacnhanmk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbx_Matkhau);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_Tentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangky";
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_Tentaikhoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_Matkhau;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbx_Xacnhanmk;
        private System.Windows.Forms.Button btn_Dangky;
    }
}