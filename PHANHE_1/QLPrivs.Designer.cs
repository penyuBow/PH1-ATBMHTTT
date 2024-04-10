namespace PHANHE_1
{
    partial class QLPrivs
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
            this.btn_ThuHoiQuyenUser = new System.Windows.Forms.Button();
            this.btn_CapRoleChoUser = new System.Windows.Forms.Button();
            this.btn_CapQuyenUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TroVe1 = new System.Windows.Forms.Button();
            this.btn_ThuHoiQuyenRole = new System.Windows.Forms.Button();
            this.btn_CapQuyenRole = new System.Windows.Forms.Button();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 606);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(849, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TroVe);
            this.panel1.Controls.Add(this.btn_ThuHoiQuyenUser);
            this.panel1.Controls.Add(this.btn_CapRoleChoUser);
            this.panel1.Controls.Add(this.btn_CapQuyenUser);
            this.panel1.Location = new System.Drawing.Point(8, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 56);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(712, 11);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(96, 42);
            this.btn_TroVe.TabIndex = 3;
            this.btn_TroVe.Text = "Trở Về ";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_ThuHoiQuyenUser
            // 
            this.btn_ThuHoiQuyenUser.Location = new System.Drawing.Point(279, 11);
            this.btn_ThuHoiQuyenUser.Name = "btn_ThuHoiQuyenUser";
            this.btn_ThuHoiQuyenUser.Size = new System.Drawing.Size(137, 42);
            this.btn_ThuHoiQuyenUser.TabIndex = 2;
            this.btn_ThuHoiQuyenUser.Text = "Thu Hồi Quyền";
            this.btn_ThuHoiQuyenUser.UseVisualStyleBackColor = true;
            this.btn_ThuHoiQuyenUser.Click += new System.EventHandler(this.btn_ThuHoiQuyenUser_Click);
            // 
            // btn_CapRoleChoUser
            // 
            this.btn_CapRoleChoUser.Location = new System.Drawing.Point(153, 11);
            this.btn_CapRoleChoUser.Name = "btn_CapRoleChoUser";
            this.btn_CapRoleChoUser.Size = new System.Drawing.Size(94, 42);
            this.btn_CapRoleChoUser.TabIndex = 1;
            this.btn_CapRoleChoUser.Text = "Cấp Role";
            this.btn_CapRoleChoUser.UseVisualStyleBackColor = true;
            this.btn_CapRoleChoUser.Click += new System.EventHandler(this.btn_CapRoleChoUser_Click);
            // 
            // btn_CapQuyenUser
            // 
            this.btn_CapQuyenUser.Location = new System.Drawing.Point(20, 11);
            this.btn_CapQuyenUser.Name = "btn_CapQuyenUser";
            this.btn_CapQuyenUser.Size = new System.Drawing.Size(92, 42);
            this.btn_CapQuyenUser.TabIndex = 0;
            this.btn_CapQuyenUser.Text = "Cấp Quyền";
            this.btn_CapQuyenUser.UseVisualStyleBackColor = true;
            this.btn_CapQuyenUser.Click += new System.EventHandler(this.btn_CapQuyenUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(849, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TroVe1);
            this.panel2.Controls.Add(this.btn_ThuHoiQuyenRole);
            this.panel2.Controls.Add(this.btn_CapQuyenRole);
            this.panel2.Location = new System.Drawing.Point(7, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 56);
            this.panel2.TabIndex = 2;
            // 
            // btn_TroVe1
            // 
            this.btn_TroVe1.Location = new System.Drawing.Point(712, 11);
            this.btn_TroVe1.Name = "btn_TroVe1";
            this.btn_TroVe1.Size = new System.Drawing.Size(96, 42);
            this.btn_TroVe1.TabIndex = 3;
            this.btn_TroVe1.Text = "Trở Về ";
            this.btn_TroVe1.UseVisualStyleBackColor = true;
            this.btn_TroVe1.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_ThuHoiQuyenRole
            // 
            this.btn_ThuHoiQuyenRole.Location = new System.Drawing.Point(152, 11);
            this.btn_ThuHoiQuyenRole.Name = "btn_ThuHoiQuyenRole";
            this.btn_ThuHoiQuyenRole.Size = new System.Drawing.Size(137, 42);
            this.btn_ThuHoiQuyenRole.TabIndex = 2;
            this.btn_ThuHoiQuyenRole.Text = "Thu Hồi Quyền";
            this.btn_ThuHoiQuyenRole.UseVisualStyleBackColor = true;
            this.btn_ThuHoiQuyenRole.Click += new System.EventHandler(this.btn_ThuHoiQuyenRole_Click);
            // 
            // btn_CapQuyenRole
            // 
            this.btn_CapQuyenRole.Location = new System.Drawing.Point(21, 11);
            this.btn_CapQuyenRole.Name = "btn_CapQuyenRole";
            this.btn_CapQuyenRole.Size = new System.Drawing.Size(92, 42);
            this.btn_CapQuyenRole.TabIndex = 0;
            this.btn_CapQuyenRole.Text = "Cấp Quyền";
            this.btn_CapQuyenRole.UseVisualStyleBackColor = true;
            this.btn_CapQuyenRole.Click += new System.EventHandler(this.btn_CapQuyenRole_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(833, 365);
            this.dataGridView2.TabIndex = 0;
            // 
            // QLPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLPrivs";
            this.Text = "QLPrivs";
            this.Load += new System.EventHandler(this.QLPrivs_Load);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_ThuHoiQuyenUser;
        private System.Windows.Forms.Button btn_CapRoleChoUser;
        private System.Windows.Forms.Button btn_CapQuyenUser;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TroVe1;
        private System.Windows.Forms.Button btn_ThuHoiQuyenRole;
        private System.Windows.Forms.Button btn_CapQuyenRole;
    }
}