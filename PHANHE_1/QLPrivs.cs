using Oracle.ManagedDataAccess.Client;
using PHANHE_1.Class;
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
    public partial class QLPrivs : Form
    {
        public QLPrivs()
        {
            InitializeComponent();
        }
        private void LoadListUser()
        {
            //string sql = " SELECT grantee, privilege, table_name FROM dba_tab_privs  UNION ALL SELECT grantee, privilege, null  FROM dba_sys_privs  ORDER BY grantee ";
            //string query = "SELECT * FROM ALL_USERS ORDER BY created DESC ";
            //SELECT grantee, privilege, table_name FROM dba_tab_privs WHERE GRANTEE IN(SELECT MaNV FROM PH2.NHANVIEN) or grantee LIKE 'RL_%' ORDER BY grantee
            string sqlcom = " SELECT grantee, privilege, table_name FROM dba_tab_privs  UNION ALL SELECT grantee, privilege, null  FROM dba_sys_privs  ORDER BY grantee ";
            DataTable data = Class.DBUtils.GetDataToTable(sqlcom);
            dataGridView1.DataSource = data;

        }
        private void LoadListRole()
        {
            string sql = " SELECT role, privilege, table_name, null as granted_role\r\n    FROM role_tab_privs\r\n    UNION ALL\r\n    SELECT role, null, null, granted_role\r\n    FROM role_role_privs\r\n    UNION ALL\r\n    SELECT role, privilege, null, null\r\n    FROM role_sys_privs\r\n    ORDER BY role ";
            //string query = "SELECT * FROM dba_roles ";
            DataTable data = Class.DBUtils.GetDataToTable(sql);
            dataGridView2.DataSource = data;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapQuyenUser_Click(object sender, EventArgs e)
        {
            string UserName = dataGridView1.CurrentRow.Cells["GRANTEE"].Value.ToString();
            GrantPrivs addGrantDialog = new GrantPrivs(UserName, (int)CurrentObject.USER);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btn_CapRoleChoUser_Click(object sender, EventArgs e)
        {
            string UserName = dataGridView1.CurrentRow.Cells["GRANTEE"].Value.ToString();
            GrantRole addGrantDialog = new GrantRole(UserName);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btn_ThuHoiQuyenUser_Click(object sender, EventArgs e)
        {
            string userName = dataGridView1.CurrentRow.Cells["GRANTEE"].Value.ToString();
            RevokeGrant revokeGrantDialog = new RevokeGrant(userName, (int)CurrentObject.USER);
            revokeGrantDialog.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btn_CapQuyenRole_Click(object sender, EventArgs e)
        {
            string roleName = dataGridView2.CurrentRow.Cells["ROLE"].Value.ToString();
            GrantPrivs addGrantDialog = new GrantPrivs(roleName, (int)CurrentObject.ROLE);
            addGrantDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void btn_ThuHoiQuyenRole_Click(object sender, EventArgs e)
        {
            string roleName = dataGridView2.CurrentRow.Cells["ROLE"].Value.ToString();
            RevokeGrant revokeGrantDialog = new RevokeGrant(roleName, (int)CurrentObject.ROLE);
            revokeGrantDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void QLPrivs_Load(object sender, EventArgs e)
        {
            LoadListUser();
            LoadListRole();
        }
    }
}
