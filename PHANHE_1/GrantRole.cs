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
    public partial class GrantRole : Form
    {
        private string _userName;
        public GrantRole(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " GRANT " + txtRoleName.Text + " TO " + _userName;
                OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { txbRoleName.Text, _userName });
                MessageBox.Show("Cấp role cho user thành công!\n\n", "Kết quả");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cấp role cho user!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void GrantRole_Load(object sender, EventArgs e)
        {
            txtUsername.Text = _userName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
