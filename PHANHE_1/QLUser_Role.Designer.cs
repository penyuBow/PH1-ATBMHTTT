namespace PHANHE_1
{
    partial class QLUser_Role
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_ChinhUser = new System.Windows.Forms.Button();
            this.btn_XoaUser = new System.Windows.Forms.Button();
            this.btn_TaoUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TroVe1 = new System.Windows.Forms.Button();
            this.btn_ChinhRole = new System.Windows.Forms.Button();
            this.btn_XoaRole = new System.Windows.Forms.Button();
            this.btn_TaoRole = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TroVe);
            this.panel1.Controls.Add(this.btn_ChinhUser);
            this.panel1.Controls.Add(this.btn_XoaUser);
            this.panel1.Controls.Add(this.btn_TaoUser);
            this.panel1.Location = new System.Drawing.Point(608, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 352);
            this.panel1.TabIndex = 1;
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(41, 302);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(101, 37);
            this.btn_TroVe.TabIndex = 3;
            this.btn_TroVe.Text = "Trở Về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_ChinhUser
            // 
            this.btn_ChinhUser.Location = new System.Drawing.Point(20, 201);
            this.btn_ChinhUser.Name = "btn_ChinhUser";
            this.btn_ChinhUser.Size = new System.Drawing.Size(139, 35);
            this.btn_ChinhUser.TabIndex = 2;
            this.btn_ChinhUser.Text = "Chỉnh Sửa User";
            this.btn_ChinhUser.UseVisualStyleBackColor = true;
            this.btn_ChinhUser.Click += new System.EventHandler(this.btn_ChinhUser_Click);
            // 
            // btn_XoaUser
            // 
            this.btn_XoaUser.Location = new System.Drawing.Point(41, 139);
            this.btn_XoaUser.Name = "btn_XoaUser";
            this.btn_XoaUser.Size = new System.Drawing.Size(101, 35);
            this.btn_XoaUser.TabIndex = 1;
            this.btn_XoaUser.Text = "Xóa User";
            this.btn_XoaUser.UseVisualStyleBackColor = true;
            this.btn_XoaUser.Click += new System.EventHandler(this.btn_XoaUser_Click);
            // 
            // btn_TaoUser
            // 
            this.btn_TaoUser.Location = new System.Drawing.Point(41, 86);
            this.btn_TaoUser.Name = "btn_TaoUser";
            this.btn_TaoUser.Size = new System.Drawing.Size(101, 35);
            this.btn_TaoUser.TabIndex = 0;
            this.btn_TaoUser.Text = "Tạo User";
            this.btn_TaoUser.UseVisualStyleBackColor = true;
            this.btn_TaoUser.Click += new System.EventHandler(this.btn_TaoUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TroVe1);
            this.panel2.Controls.Add(this.btn_ChinhRole);
            this.panel2.Controls.Add(this.btn_XoaRole);
            this.panel2.Controls.Add(this.btn_TaoRole);
            this.panel2.Location = new System.Drawing.Point(607, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 347);
            this.panel2.TabIndex = 1;
            // 
            // btn_TroVe1
            // 
            this.btn_TroVe1.Location = new System.Drawing.Point(43, 278);
            this.btn_TroVe1.Name = "btn_TroVe1";
            this.btn_TroVe1.Size = new System.Drawing.Size(96, 34);
            this.btn_TroVe1.TabIndex = 3;
            this.btn_TroVe1.Text = "Trở Về";
            this.btn_TroVe1.UseVisualStyleBackColor = true;
            this.btn_TroVe1.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_ChinhRole
            // 
            this.btn_ChinhRole.Location = new System.Drawing.Point(31, 192);
            this.btn_ChinhRole.Name = "btn_ChinhRole";
            this.btn_ChinhRole.Size = new System.Drawing.Size(122, 33);
            this.btn_ChinhRole.TabIndex = 2;
            this.btn_ChinhRole.Text = "Chỉnh Sửa Role";
            this.btn_ChinhRole.UseVisualStyleBackColor = true;
            this.btn_ChinhRole.Click += new System.EventHandler(this.btn_ChinhRole_Click);
            // 
            // btn_XoaRole
            // 
            this.btn_XoaRole.Location = new System.Drawing.Point(43, 122);
            this.btn_XoaRole.Name = "btn_XoaRole";
            this.btn_XoaRole.Size = new System.Drawing.Size(96, 37);
            this.btn_XoaRole.TabIndex = 1;
            this.btn_XoaRole.Text = "Xóa Role";
            this.btn_XoaRole.UseVisualStyleBackColor = true;
            this.btn_XoaRole.Click += new System.EventHandler(this.btn_XoaRole_Click);
            // 
            // btn_TaoRole
            // 
            this.btn_TaoRole.Location = new System.Drawing.Point(43, 55);
            this.btn_TaoRole.Name = "btn_TaoRole";
            this.btn_TaoRole.Size = new System.Drawing.Size(96, 37);
            this.btn_TaoRole.TabIndex = 0;
            this.btn_TaoRole.Text = "Tạo Role";
            this.btn_TaoRole.UseVisualStyleBackColor = true;
            this.btn_TaoRole.Click += new System.EventHandler(this.btn_TaoRole_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 347);
            this.dataGridView2.TabIndex = 0;
            // 
            // QLUser_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLUser_Role";
            this.Text = "QLUser_Role";
            this.Load += new System.EventHandler(this.QLUser_Role_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_ChinhUser;
        private System.Windows.Forms.Button btn_XoaUser;
        private System.Windows.Forms.Button btn_TaoUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TroVe1;
        private System.Windows.Forms.Button btn_ChinhRole;
        private System.Windows.Forms.Button btn_XoaRole;
        private System.Windows.Forms.Button btn_TaoRole;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}