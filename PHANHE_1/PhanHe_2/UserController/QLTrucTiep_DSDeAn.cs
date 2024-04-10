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

namespace PHANHE_1.PhanHe_2.UserController
{
    public partial class QLTrucTiep_DSDeAn : UserControl
    {
        public QLTrucTiep_DSDeAn()
        {
            InitializeComponent();
            try
            {
                //Trả về kết quả cho bảng dataGridView1 với kết nối Login
                HelperControl.raiseTable(dataGridView1, "select * from PH2.DEAN", Form1.getConnection());
                dataGridView1.Show();
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }

        private void QLTrucTiep_DSDeAn_Load(object sender, EventArgs e)
        {

        }
    }
}
