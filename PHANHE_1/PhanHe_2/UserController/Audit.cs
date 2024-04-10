using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE_1.PhanHe_2.UserController
{
    public partial class Audit : UserControl
    {
        OracleConnection connection;
        String username;
        public Audit()
        {
            InitializeComponent();
        }
        public Audit(String user, OracleConnection connection)
        {
            InitializeComponent();
            this.username = user;
            this.connection = connection;
        }
        private void Audit_Load(object sender, EventArgs e)
        {

            viewAuditButton_Click(sender, e);

        }

        private void viewAuditButton_Click(object sender, EventArgs e)
        {
            auditLabel.Show();
            logDataGridView.Hide();
            richTextBox1.Hide();
            auditDataGridView.Show();
            viewLogButton.Show();
            viewAuditButton.Hide();
            if (auditDataGridView.Rows.Count == 0)
            {
                //chưa sửa
                string sql = "select * from " + "SYS" + ".V_AUDIT";
                //Hiện bảng ra auditDataGridView
                HelperControl.raiseTable(auditDataGridView, sql, connection);

            }
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            auditLabel.Hide();
            auditDataGridView.Hide();
            logDataGridView.Show();
            richTextBox1.Hide();
            viewLogButton.Hide();
            viewAuditButton.Show();
            //chưa sửa
            string sql = "select * from " + "SYS" + ".V_LOG";
            //HIển thị kết quả của bảng logDataGridView
            bool x = HelperControl.raiseTable(logDataGridView, sql, connection);
            if (!x)
            {
                richTextBox1.Show();
                richTextBox1.Text = "Log file is empty";
                richTextBox1.Font = new Font("Cambria", 20, FontStyle.Bold);
                richTextBox1.ForeColor = Color.OrangeRed; return;
            }
            
        }

    }
}
