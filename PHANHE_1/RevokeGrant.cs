using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PHANHE_1
{
    public partial class RevokeGrant : Form
    {
        private int _currentObject; //0: user ; 1: role
        private string _objectName;
        public RevokeGrant(string objectName, int currentObject)
        {
            InitializeComponent();
            _objectName = objectName;
            this._currentObject = currentObject;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string privilege = txtPrivilegeName.Text;
                string table = txtTableName.Text;
               
                    string query = "REVOKE " + privilege + " ON " + table + " FROM " + _objectName;
                    OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thu hồi quyền thành công!\n\n", "Kết quả");
                    this.Close();
                
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không đúng !! Không thể thu hồi!\n\n" + ex.Message, "Kết quả");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RevokeGrant_Load(object sender, EventArgs e)
        {
            txtUserRoleName.Text = _objectName;
        }
    }
}
