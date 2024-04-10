using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace PHANHE_1.PhanHe_2.UserController
{
    public partial class PhanCongEveryone: UserControl
    {
        OracleConnection connection;
        String Username;
        public PhanCongEveryone()
        {
            InitializeComponent();
        }
        public PhanCongEveryone(string user, OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.Username = user;
        }


        private void PhanCongEveryone_Load(object sender, EventArgs e)
        {

            OracleDataAdapter adt = new OracleDataAdapter("select * from PH2.PHANCONG", Form1.getConnection());

            DataTable table = new DataTable();

            adt.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
