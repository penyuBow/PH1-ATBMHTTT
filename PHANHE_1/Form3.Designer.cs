namespace PHANHE_1
{
    partial class Form3
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
            this.rbtn_TatCa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_Table = new System.Windows.Forms.RadioButton();
            this.rbtn_View = new System.Windows.Forms.RadioButton();
            this.rbtn_Function = new System.Windows.Forms.RadioButton();
            this.rbtn_Trigger = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtn_Proc = new System.Windows.Forms.RadioButton();
            this.rbtn_Package = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CreateTable = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_TatCa
            // 
            this.rbtn_TatCa.AutoSize = true;
            this.rbtn_TatCa.Checked = true;
            this.rbtn_TatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_TatCa.Location = new System.Drawing.Point(144, 10);
            this.rbtn_TatCa.Name = "rbtn_TatCa";
            this.rbtn_TatCa.Size = new System.Drawing.Size(71, 24);
            this.rbtn_TatCa.TabIndex = 0;
            this.rbtn_TatCa.TabStop = true;
            this.rbtn_TatCa.Text = "Tất cả";
            this.rbtn_TatCa.UseVisualStyleBackColor = true;
            this.rbtn_TatCa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐỐI TƯỢNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_Table
            // 
            this.rbtn_Table.AutoSize = true;
            this.rbtn_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Table.Location = new System.Drawing.Point(241, 10);
            this.rbtn_Table.Name = "rbtn_Table";
            this.rbtn_Table.Size = new System.Drawing.Size(66, 24);
            this.rbtn_Table.TabIndex = 2;
            this.rbtn_Table.Text = "Table";
            this.rbtn_Table.UseVisualStyleBackColor = true;
            this.rbtn_Table.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_View
            // 
            this.rbtn_View.AutoSize = true;
            this.rbtn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_View.Location = new System.Drawing.Point(327, 11);
            this.rbtn_View.Name = "rbtn_View";
            this.rbtn_View.Size = new System.Drawing.Size(61, 24);
            this.rbtn_View.TabIndex = 3;
            this.rbtn_View.Text = "View";
            this.rbtn_View.UseVisualStyleBackColor = true;
            this.rbtn_View.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_Function
            // 
            this.rbtn_Function.AutoSize = true;
            this.rbtn_Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Function.Location = new System.Drawing.Point(418, 10);
            this.rbtn_Function.Name = "rbtn_Function";
            this.rbtn_Function.Size = new System.Drawing.Size(89, 24);
            this.rbtn_Function.TabIndex = 4;
            this.rbtn_Function.Text = "Function";
            this.rbtn_Function.UseVisualStyleBackColor = true;
            this.rbtn_Function.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_Trigger
            // 
            this.rbtn_Trigger.AutoSize = true;
            this.rbtn_Trigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Trigger.Location = new System.Drawing.Point(523, 10);
            this.rbtn_Trigger.Name = "rbtn_Trigger";
            this.rbtn_Trigger.Size = new System.Drawing.Size(76, 24);
            this.rbtn_Trigger.TabIndex = 5;
            this.rbtn_Trigger.Text = "Trigger";
            this.rbtn_Trigger.UseVisualStyleBackColor = true;
            this.rbtn_Trigger.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xem đối tượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 307);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rbtn_Proc
            // 
            this.rbtn_Proc.AutoSize = true;
            this.rbtn_Proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Proc.Location = new System.Drawing.Point(615, 11);
            this.rbtn_Proc.Name = "rbtn_Proc";
            this.rbtn_Proc.Size = new System.Drawing.Size(100, 24);
            this.rbtn_Proc.TabIndex = 8;
            this.rbtn_Proc.Text = "Procedure";
            this.rbtn_Proc.UseVisualStyleBackColor = true;
            this.rbtn_Proc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_Package
            // 
            this.rbtn_Package.AutoSize = true;
            this.rbtn_Package.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Package.Location = new System.Drawing.Point(751, 99);
            this.rbtn_Package.Name = "rbtn_Package";
            this.rbtn_Package.Size = new System.Drawing.Size(89, 24);
            this.rbtn_Package.TabIndex = 9;
            this.rbtn_Package.Text = "Package";
            this.rbtn_Package.UseVisualStyleBackColor = true;
            this.rbtn_Package.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Proc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtn_Trigger);
            this.panel1.Controls.Add(this.rbtn_Function);
            this.panel1.Controls.Add(this.rbtn_View);
            this.panel1.Controls.Add(this.rbtn_Table);
            this.panel1.Controls.Add(this.rbtn_TatCa);
            this.panel1.Location = new System.Drawing.Point(29, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 51);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_CreateTable
            // 
            this.btn_CreateTable.Location = new System.Drawing.Point(361, 456);
            this.btn_CreateTable.Name = "btn_CreateTable";
            this.btn_CreateTable.Size = new System.Drawing.Size(134, 33);
            this.btn_CreateTable.TabIndex = 11;
            this.btn_CreateTable.Text = "Tạo Bảng";
            this.btn_CreateTable.UseVisualStyleBackColor = true;
            this.btn_CreateTable.Click += new System.EventHandler(this.btn_CreateTable_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(29, 456);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(88, 33);
            this.btn_TroVe.TabIndex = 12;
            this.btn_TroVe.Text = "Trở Về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.btn_CreateTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtn_Package);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_TatCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Table;
        private System.Windows.Forms.RadioButton rbtn_View;
        private System.Windows.Forms.RadioButton rbtn_Function;
        private System.Windows.Forms.RadioButton rbtn_Trigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtn_Proc;
        private System.Windows.Forms.RadioButton rbtn_Package;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CreateTable;
        private System.Windows.Forms.Button btn_TroVe;
    }
}