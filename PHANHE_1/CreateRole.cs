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
    public partial class CreateRole : Form
    {
        public CreateRole()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string creRole = "create role ";
            try
            {


                OracleCommand cmd2 = Class.DBUtils.ConAdmin.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = creRole + txtRoleName.Text;
                cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (rs == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            
        }
    }
}
