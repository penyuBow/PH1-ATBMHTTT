using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace PHANHE_1
{
    public partial class QLUser_Role : Form
    {
        public QLUser_Role()
        {
            InitializeComponent();
        }
        private void LoadListUser()
        {
            string query = "SELECT * FROM ALL_USERS ORDER BY created DESC ";
            DataTable data = Class.DBUtils.GetDataToTable(query);
            dataGridView1.DataSource = data;
            
        }
        private void LoadListRole()
        {
            string query = "SELECT * FROM dba_roles ";
            DataTable data = Class.DBUtils.GetDataToTable(query);
            dataGridView2.DataSource = data;
        }
        private void btn_XoaRole_Click(object sender, EventArgs e)
        {
            try
            {
                string roleName = dataGridView2.CurrentRow.Cells["ROLE"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //string query = "BEGIN proc_OracleScript; proc_DropUser('" + UserName + "'); END;";
                    string query = "DROP ROLE " + roleName;
                    OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role đã được xóa thành công!\n\n", "Kết quả");
                    LoadListRole();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa role!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TaoUser_Click(object sender, EventArgs e)
        {
            CreateUser createDialog = new CreateUser();
            createDialog.ShowDialog();
            this.Show();    
            LoadListUser();
        }

        private void btn_TaoRole_Click(object sender, EventArgs e)
        {
            CreateRole createDialog = new CreateRole();
            createDialog.ShowDialog();
            this.Show();
            LoadListRole();
        }

        private void btn_ChinhRole_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_XoaUser_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = dataGridView1.CurrentRow.Cells["USERNAME"].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //string query = "BEGIN proc_OracleScript; proc_DropUser('" + UserName + "'); END;";
                    string query = "DROP USER " + UserName +" CASCADE";
                    OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User đã được xóa thành công!\n\n", "Kết quả");
                    LoadListUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa user!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void btn_ChinhUser_Click(object sender, EventArgs e)
        {
            string UserName = dataGridView1.CurrentRow.Cells["USERNAME"].Value.ToString();
            EditUser editDialog = new EditUser(UserName);
            editDialog.ShowDialog();
            this.Show();
            LoadListUser(); ;
        }

        private void QLUser_Role_Load(object sender, EventArgs e)
        {
            LoadListUser();
            LoadListRole();

        }
    }
}
