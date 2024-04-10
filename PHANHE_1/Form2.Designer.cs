namespace PHANHE_1
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
            this.btn_QuanLyUserRole = new System.Windows.Forms.Button();
            this.btn_QuanLyQuyen = new System.Windows.Forms.Button();
            this.btn_DSDoiTuong = new System.Windows.Forms.Button();
            this.btn_QuanLyDuLieu = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QuanLyUserRole
            // 
            this.btn_QuanLyUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyUserRole.Location = new System.Drawing.Point(70, 49);
            this.btn_QuanLyUserRole.Name = "btn_QuanLyUserRole";
            this.btn_QuanLyUserRole.Size = new System.Drawing.Size(191, 118);
            this.btn_QuanLyUserRole.TabIndex = 0;
            this.btn_QuanLyUserRole.Text = "Quản Lý User/Role";
            this.btn_QuanLyUserRole.UseVisualStyleBackColor = true;
            this.btn_QuanLyUserRole.Click += new System.EventHandler(this.btn_QuanLyUserRole_Click);
            // 
            // btn_QuanLyQuyen
            // 
            this.btn_QuanLyQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyQuyen.Location = new System.Drawing.Point(334, 49);
            this.btn_QuanLyQuyen.Name = "btn_QuanLyQuyen";
            this.btn_QuanLyQuyen.Size = new System.Drawing.Size(191, 118);
            this.btn_QuanLyQuyen.TabIndex = 2;
            this.btn_QuanLyQuyen.Text = "Quản Lý Quyền";
            this.btn_QuanLyQuyen.UseVisualStyleBackColor = true;
            this.btn_QuanLyQuyen.Click += new System.EventHandler(this.btn_QuanLyQuyen_Click);
            // 
            // btn_DSDoiTuong
            // 
            this.btn_DSDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSDoiTuong.Location = new System.Drawing.Point(604, 49);
            this.btn_DSDoiTuong.Name = "btn_DSDoiTuong";
            this.btn_DSDoiTuong.Size = new System.Drawing.Size(191, 118);
            this.btn_DSDoiTuong.TabIndex = 3;
            this.btn_DSDoiTuong.Text = "Danh Sách Đối Tượng";
            this.btn_DSDoiTuong.UseVisualStyleBackColor = true;
            this.btn_DSDoiTuong.Click += new System.EventHandler(this.btn_DSDoiTuong_Click);
            // 
            // btn_QuanLyDuLieu
            // 
            this.btn_QuanLyDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyDuLieu.Location = new System.Drawing.Point(164, 292);
            this.btn_QuanLyDuLieu.Name = "btn_QuanLyDuLieu";
            this.btn_QuanLyDuLieu.Size = new System.Drawing.Size(191, 118);
            this.btn_QuanLyDuLieu.TabIndex = 4;
            this.btn_QuanLyDuLieu.Text = "Thông Tin Quyền";
            this.btn_QuanLyDuLieu.UseVisualStyleBackColor = true;
            this.btn_QuanLyDuLieu.Click += new System.EventHandler(this.btn_ThongTinQuyen_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(476, 292);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(191, 118);
            this.btn_DangXuat.TabIndex = 7;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 513);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_QuanLyDuLieu);
            this.Controls.Add(this.btn_DSDoiTuong);
            this.Controls.Add(this.btn_QuanLyQuyen);
            this.Controls.Add(this.btn_QuanLyUserRole);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QuanLyUserRole;
        private System.Windows.Forms.Button btn_QuanLyQuyen;
        private System.Windows.Forms.Button btn_DSDoiTuong;
        private System.Windows.Forms.Button btn_QuanLyDuLieu;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}