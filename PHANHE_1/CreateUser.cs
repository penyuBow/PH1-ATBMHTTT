using Oracle.ManagedDataAccess.Client;
using PHANHE_1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHANHE_1.PhanHe_2;

namespace PHANHE_1
{
    public partial class CreateUser : Form
    {
        string msnv;
        public CreateUser()
        {
            InitializeComponent();
        }
        string create_user = "create user ";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            
            string sql = " SELECT MANV FROM PH2.NHANVIEN WHERE MANV ='" + txtUsername.Text + "'";
            OracleCommand command = new OracleCommand(sql, DBUtils.ConAdmin);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                msnv = reader.GetString(0);
                
            }
            (string pass_salt,string salt) = Cryptography.addSalt(txtPassword.Text, msnv);
            create_user += txtUsername.Text + " identified by " + Cryptography.MD5_ComputeHash(pass_salt);
            try
            {
                if (txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp!\n\n");
                    return;
                }
                OracleCommand cmd2 = Class.DBUtils.ConAdmin.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = create_user;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo User!\n\n" + ex.Message, "Kết quả");
            }
            DialogResult rs = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (rs == DialogResult.OK)
                this.Close();
        }
    }
}
