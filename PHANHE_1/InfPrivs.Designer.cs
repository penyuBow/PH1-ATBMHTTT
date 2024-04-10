namespace PHANHE_1
{
    partial class InfPrivs
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
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XemAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btn_XemRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XemAllRole = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(857, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btn_TroVe);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(708, 384);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(104, 34);
            this.btn_TroVe.TabIndex = 3;
            this.btn_TroVe.Text = "Trờ Về ";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btn_Xem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_XemAll);
            this.panel1.Location = new System.Drawing.Point(568, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 338);
            this.panel1.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(22, 71);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 24);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(22, 126);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(100, 34);
            this.btn_Xem.TabIndex = 2;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Tên User";
            // 
            // btn_XemAll
            // 
            this.btn_XemAll.Location = new System.Drawing.Point(22, 224);
            this.btn_XemAll.Name = "btn_XemAll";
            this.btn_XemAll.Size = new System.Drawing.Size(100, 34);
            this.btn_XemAll.TabIndex = 0;
            this.btn_XemAll.Text = "Xem Tất Cả";
            this.btn_XemAll.UseVisualStyleBackColor = true;
            this.btn_XemAll.Click += new System.EventHandler(this.btn_XemAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(701, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Trờ Về ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRoleName);
            this.panel2.Controls.Add(this.btn_XemRole);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_XemAllRole);
            this.panel2.Location = new System.Drawing.Point(561, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 338);
            this.panel2.TabIndex = 5;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(22, 71);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(222, 24);
            this.txtRoleName.TabIndex = 3;
            // 
            // btn_XemRole
            // 
            this.btn_XemRole.Location = new System.Drawing.Point(22, 126);
            this.btn_XemRole.Name = "btn_XemRole";
            this.btn_XemRole.Size = new System.Drawing.Size(100, 34);
            this.btn_XemRole.TabIndex = 2;
            this.btn_XemRole.Text = "Xem";
            this.btn_XemRole.UseVisualStyleBackColor = true;
            this.btn_XemRole.Click += new System.EventHandler(this.btn_XemRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên Role";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_XemAllRole
            // 
            this.btn_XemAllRole.Location = new System.Drawing.Point(22, 224);
            this.btn_XemAllRole.Name = "btn_XemAllRole";
            this.btn_XemAllRole.Size = new System.Drawing.Size(100, 34);
            this.btn_XemAllRole.TabIndex = 0;
            this.btn_XemAllRole.Text = "Xem Tất Cả";
            this.btn_XemAllRole.UseVisualStyleBackColor = true;
            this.btn_XemAllRole.Click += new System.EventHandler(this.btn_XemAllRole_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(542, 338);
            this.dataGridView2.TabIndex = 4;
            // 
            // InfPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfPrivs";
            this.Text = "InfPrivs";
            this.Load += new System.EventHandler(this.InfPrivs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XemAll;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btn_XemRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XemAllRole;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}