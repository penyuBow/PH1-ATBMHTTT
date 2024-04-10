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

namespace PHANHE_1
{
    public partial class EditUser : Form
    {
        private string _username;
        public EditUser(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            textBox1.Text = _username;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!\n\n");
                return;
            }
            try
            {
                string query = "ALTER USER username IDENTIFIED BY new_password;";
                OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("User đã được chỉnh sửa thành thành công!\n\n", "Kết quả");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa user!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
