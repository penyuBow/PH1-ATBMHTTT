namespace PHANHE_1
{
    partial class Form1
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
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbn_Username = new System.Windows.Forms.Label();
            this.lbn_Password = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_HostName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.check_DBASYS = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_DangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.Location = new System.Drawing.Point(0, 0);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(635, 92);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Đăng Nhập";
            this.lbl_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DangNhap.Click += new System.EventHandler(this.lbl_DangNhap_Click);
            // 
            // lbn_Username
            // 
            this.lbn_Username.AutoSize = true;
            this.lbn_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Username.Location = new System.Drawing.Point(69, 136);
            this.lbn_Username.Name = "lbn_Username";
            this.lbn_Username.Size = new System.Drawing.Size(91, 20);
            this.lbn_Username.TabIndex = 1;
            this.lbn_Username.Text = "Username";
            this.lbn_Username.Click += new System.EventHandler(this.lbn_Username_Click);
            // 
            // lbn_Password
            // 
            this.lbn_Password.AutoSize = true;
            this.lbn_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Password.Location = new System.Drawing.Point(74, 195);
            this.lbn_Password.Name = "lbn_Password";
            this.lbn_Password.Size = new System.Drawing.Size(86, 20);
            this.lbn_Password.TabIndex = 2;
            this.lbn_Password.Text = "Password";
            this.lbn_Password.Click += new System.EventHandler(this.lbn_Password_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(231, 341);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(94, 44);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Location = new System.Drawing.Point(395, 341);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 44);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(183, 130);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(306, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(183, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbl_HostName
            // 
            this.lbl_HostName.AutoSize = true;
            this.lbl_HostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HostName.Location = new System.Drawing.Point(74, 249);
            this.lbl_HostName.Name = "lbl_HostName";
            this.lbl_HostName.Size = new System.Drawing.Size(91, 20);
            this.lbl_HostName.TabIndex = 7;
            this.lbl_HostName.Text = "Hostname";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(118, 294);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(42, 20);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtHostname
            // 
            this.txtHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostname.Location = new System.Drawing.Point(183, 248);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(306, 26);
            this.txtHostname.TabIndex = 9;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(183, 294);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(306, 26);
            this.txtPort.TabIndex = 10;
            // 
            // check_DBASYS
            // 
            this.check_DBASYS.AutoSize = true;
            this.check_DBASYS.Location = new System.Drawing.Point(506, 301);
            this.check_DBASYS.Name = "check_DBASYS";
            this.check_DBASYS.Size = new System.Drawing.Size(117, 17);
            this.check_DBASYS.TabIndex = 11;
            this.check_DBASYS.Text = "Log In As DBASYS";
            this.check_DBASYS.UseVisualStyleBackColor = true;
            this.check_DBASYS.CheckedChanged += new System.EventHandler(this.check_DBASYS_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Key Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(635, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_DBASYS);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lbl_HostName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lbn_Password);
            this.Controls.Add(this.lbn_Username);
            this.Controls.Add(this.lbl_DangNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbn_Username;
        private System.Windows.Forms.Label lbn_Password;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_HostName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox check_DBASYS;
        private System.Windows.Forms.Button button1;
    }
}