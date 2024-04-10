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
    public partial class QLTrucTiep_DSPhongBan : UserControl
    {
        public QLTrucTiep_DSPhongBan()
        {
            InitializeComponent();
            try
            {
                //Trả kết quả về dataGridView1
                HelperControl.raiseTable(dataGridView1, "select * from PH2.PHONGBAN", Form1.getConnection());
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                dataGridView1.Show();
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }
    }
}
