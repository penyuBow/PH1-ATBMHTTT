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
    public partial class GiamDoc_XemDSNhanVien : UserControl
    {
        OracleConnection connection;
        String username;
        public GiamDoc_XemDSNhanVien()
        {
            InitializeComponent();
        }
        public GiamDoc_XemDSNhanVien(String user, OracleConnection connection)
        {
            InitializeComponent();
            this.username = user;
            this.connection = connection;
        }
        private void GiamDoc_XemDSNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "select * FROM " + "PH2" + ".V_NS_NHANVIEN";
            OracleDataAdapter adt = new OracleDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adt.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
