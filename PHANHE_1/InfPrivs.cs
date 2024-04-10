using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE_1
{
    public partial class InfPrivs : Form
    {
        public InfPrivs()
        {
            InitializeComponent();
        }

        private void HienThiTatCa()
        {
            DataTable tbl = new DataTable();
            string sql = " SELECT grantee, privilege, table_name FROM dba_tab_privs  UNION ALL SELECT grantee, privilege, null  FROM dba_sys_privs  ORDER BY grantee ";
            tbl = Class.DBUtils.GetDataToTable(sql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tbl;
        }
        private void HienThi(string name)
        {
            DataTable tbl = new DataTable();
            string sql = " SELECT grantee, privilege, table_name\r\n    FROM dba_tab_privs\r\n    where GRANTEE ="+"'"+name.ToUpper()+"'"+"\r\n    UNION ALL\r\n    SELECT grantee, privilege, null\r\n    FROM dba_sys_privs\r\n    where GRANTEE = "+"'"+name.ToUpper()+"'";
            tbl = Class.DBUtils.GetDataToTable(sql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tbl;
        }
        private void HienThiTatCaRole()
        {
            DataTable tbl = new DataTable();
            string sql = " SELECT role, privilege, table_name, null as granted_role\r\n    FROM role_tab_privs\r\n    UNION ALL\r\n    SELECT role, null, null, granted_role\r\n    FROM role_role_privs\r\n    UNION ALL\r\n    SELECT role, privilege, null, null\r\n    FROM role_sys_privs\r\n    ORDER BY role ";
            tbl = Class.DBUtils.GetDataToTable(sql);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = tbl;
        }
        private void HienThiRole(string name)
        {
            DataTable tbl = new DataTable();
            string sql = " SELECT role, privilege, table_name, null as granted_role\r\n    FROM role_tab_privs\r\n    where ROLE =" + "'" + name.ToUpper() + "'" + "\r\n    UNION ALL\r\n    SELECT role, null, null, granted_role\r\n    FROM role_role_privs\r\n    where ROLE = " + "'" + name.ToUpper() + "'"+ "\r\n UNION ALL\r\n    SELECT role, privilege, null, null\r\n    FROM role_sys_privs\r\n     where ROLE = " + "'" + name.ToUpper() + "'";
            tbl = Class.DBUtils.GetDataToTable(sql);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = tbl;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThi(txtUserName.Text);
        }

        private void btn_XemAll_Click(object sender, EventArgs e)
        {
            HienThiTatCa();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XemRole_Click(object sender, EventArgs e)
        {
           
            HienThiRole(txtRoleName.Text);
        }

        private void btn_XemAllRole_Click(object sender, EventArgs e)
        {
            
            HienThiTatCaRole();
        }

        private void InfPrivs_Load(object sender, EventArgs e)
        {
            HienThiTatCa();
            HienThiTatCaRole();
        }
    }
}
