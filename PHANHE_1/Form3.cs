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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            HienThi("Tất cả");
        }
        private void HienThi(string ob)
        {
            DataTable tbl = new DataTable();
            string sql = "SELECT OBJECT_NAME, OBJECT_TYPE, CREATED, STATUS" +
               " FROM USER_OBJECTS WHERE OBJECT_TYPE != 'SEQUENCE'";
            if (ob != "Tất cả")
            {
                sql = sql + " AND OBJECT_TYPE = '" + ob.ToUpper() + "'";
            }
            tbl = Class.DBUtils.GetDataToTable(sql);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tbl;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            HienThi(button.Text.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CreateTable_Click(object sender, EventArgs e)
        {
            ThemBang f = new ThemBang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
