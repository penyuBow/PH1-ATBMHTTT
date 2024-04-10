using Oracle.ManagedDataAccess.Client;
using PHANHE_1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase_1.UserControls
{
    public partial class NhanSu_EditNhanVien : UserControl
    {
        OracleConnection connection;
        String username;
        public NhanSu_EditNhanVien()
        {
            InitializeComponent();
        }
        public NhanSu_EditNhanVien(String user, OracleConnection connection)
        {
            InitializeComponent();
            this.username = user;
            this.connection = connection;
        }
        private void NhanSu_EditNhanVien_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adt = new OracleDataAdapter("select * FROM PH2.V_NS_NHANVIEN", connection);

            DataTable table = new DataTable();

            adt.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.ReadOnly = false;
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Xác định hành động được thực hiện là Update hay Insert
            //string action = (row.Cells["MAPB"].Value == null) ? "Insert" : "Update";
            //if (action=="Update")
            //{
            if (e.ColumnIndex == dataGridView1.Columns["TENNV"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set TENNV='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;

            }
            else if (e.ColumnIndex == dataGridView1.Columns["PHAI"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set PHAI='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["NGAYSINH"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set NGAYSINH=TO_DATE('" + newName + "') where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DIACHI"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set DIACHI='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["SODT"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set SODT='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["VAITRO"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set VAITRO='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["MANQL"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set MANQL='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["PHG"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set PHG=" + newName + " where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["KHUVUC"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set KHUVUC='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["LINHVUC"].Index)
            {
                string newName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                String id = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                string query = "UPDATE PH2.V_NS_NHANVIEN set LINHVUC='" + newName + "' where MANV='" + id+"'";

                OracleCommand command = new OracleCommand(query, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }

            else if (e.ColumnIndex == dataGridView1.Columns["MANV"].Index)
            {
                String MANV = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                String sql = "INSERT INTO PH2.V_NS_NHANVIEN (MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG, KHUVUC, LINHVUC) VALUES('" + MANV+"', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)";
                OracleCommand command = new OracleCommand(sql, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }


        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Kiểm tra nếu dòng mới được thêm vào là dòng cuối cùng của DataGridView
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Xác định hành động được thực hiện là Update hay Insert
            string action = (row.Cells["MANV"].Value == null) ? "Insert" : "Update";
            if (action == "Insert")
            {
                String mapb = row.Cells["MANV"].Value.ToString();
                String tenpb = row.Cells["TENPB"].Value.ToString();
                String trphg = row.Cells["TRPHG"].Value.ToString();
                String sql = "insert into PH2.V_NS_NHANVIEN(MANV) values (" + mapb + ")";
                OracleCommand command = new OracleCommand(sql, Form1.getConnection());


                command.ExecuteNonQuery();
                return;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        
    }
}