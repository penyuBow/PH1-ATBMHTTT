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
    public partial class QLTrucTiep_TaskEmp : UserControl
    {
        public QLTrucTiep_TaskEmp()
        {
            InitializeComponent();

            try
            {
                //Trả về kết quả cho bảng dataGridView1 với acc Login
                HelperControl.raiseTable(dataGridView1, "SELECT * FROM PH2.V_QL_PHANCONG", Form1.getConnection());
                dataGridView1.Show();
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }

        private void QLTrucTiep_TaskEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
