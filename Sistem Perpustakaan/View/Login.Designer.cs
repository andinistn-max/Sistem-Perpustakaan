namespace Sistem_Perpustakaan.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox_loginshow = new System.Windows.Forms.CheckBox();
            this.txt_loginpassword = new System.Windows.Forms.TextBox();
            this.lbl_loginpassword = new System.Windows.Forms.Label();
            this.txt_loginussername = new System.Windows.Forms.TextBox();
            this.lbl_loginusername = new System.Windows.Forms.Label();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_register, "btn_register");
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Name = "btn_register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_info
            // 
            resources.ApplyResources(this.lbl_info, "lbl_info");
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Name = "lbl_info";
            // 
            // pictureBox_logo
            // 
            resources.ApplyResources(this.pictureBox_logo, "pictureBox_logo");
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_login.Controls.Add(this.lbl_judul);
            this.pnl_login.Controls.Add(this.pictureBox_logo);
            this.pnl_login.Controls.Add(this.lbl_info);
            this.pnl_login.Controls.Add(this.btn_register);
            resources.ApplyResources(this.pnl_login, "pnl_login");
            this.pnl_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_login.Name = "pnl_login";
            // 
            // lbl_judul
            // 
            resources.ApplyResources(this.lbl_judul, "lbl_judul");
            this.lbl_judul.ForeColor = System.Drawing.Color.White;
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Click += new System.EventHandler(this.lbl_judul_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox_loginshow
            // 
            resources.ApplyResources(this.checkBox_loginshow, "checkBox_loginshow");
            this.checkBox_loginshow.Name = "checkBox_loginshow";
            this.checkBox_loginshow.UseVisualStyleBackColor = true;
            this.checkBox_loginshow.CheckedChanged += new System.EventHandler(this.checkBox_loginshow_CheckedChanged);
            // 
            // txt_loginpassword
            // 
            resources.ApplyResources(this.txt_loginpassword, "txt_loginpassword");
            this.txt_loginpassword.Name = "txt_loginpassword";
            this.txt_loginpassword.UseSystemPasswordChar = true;
            // 
            // lbl_loginpassword
            // 
            resources.ApplyResources(this.lbl_loginpassword, "lbl_loginpassword");
            this.lbl_loginpassword.Name = "lbl_loginpassword";
            // 
            // txt_loginussername
            // 
            resources.ApplyResources(this.txt_loginussername, "txt_loginussername");
            this.txt_loginussername.Name = "txt_loginussername";
            // 
            // lbl_loginusername
            // 
            resources.ApplyResources(this.lbl_loginusername, "lbl_loginusername");
            this.lbl_loginusername.Name = "lbl_loginusername";
            // 
            // lbl_signin
            // 
            resources.ApplyResources(this.lbl_signin, "lbl_signin");
            this.lbl_signin.Name = "lbl_signin";
            // 
            // lbl_close
            // 
            resources.ApplyResources(this.lbl_close, "lbl_close");
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.checkBox_loginshow);
            this.Controls.Add(this.txt_loginpassword);
            this.Controls.Add(this.lbl_loginpassword);
            this.Controls.Add(this.txt_loginussername);
            this.Controls.Add(this.lbl_loginusername);
            this.Controls.Add(this.lbl_signin);
            this.Controls.Add(this.pnl_login);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox_loginshow;
        private System.Windows.Forms.TextBox txt_loginpassword;
        private System.Windows.Forms.Label lbl_loginpassword;
        private System.Windows.Forms.TextBox txt_loginussername;
        private System.Windows.Forms.Label lbl_loginusername;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.Label lbl_close;
    }
}