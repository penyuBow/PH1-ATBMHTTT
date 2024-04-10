﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class QLTrucTiep_ThongTinNV : UserControl
    {
        public QLTrucTiep_ThongTinNV()
        {
            InitializeComponent();
            try
            {
                //Trả về data cho bảng dataGridView1
                HelperControl.raiseTable(dataGridView1, "SELECT * FROM PH2.V_QL_NHANVIEN", Form1.getConnection());
                dataGridView1.Show();
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }
    }
}
