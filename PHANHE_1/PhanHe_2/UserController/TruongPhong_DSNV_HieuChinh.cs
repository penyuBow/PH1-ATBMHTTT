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
    public partial class TruongPhong_DSNV_HieuChinh : UserControl
    {
        String updateMADA, updateNV, updateThoiGian;
        OracleConnection connection;
        public TruongPhong_DSNV_HieuChinh()
        {
            InitializeComponent();

            try
            {
                OracleDataAdapter adt = new OracleDataAdapter("select * from PH2.V_TP_PHANCONG", Form1.getConnection());

                DataTable table = new DataTable();

                adt.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Show();
                //Lấy class OracleConnection

            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            //Trả kết quả về dataGridView1
            OracleDataAdapter adt = new OracleDataAdapter("select * from PH2.V_TP_PHANCONG", Form1.getConnection());

            DataTable table = new DataTable();

            adt.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Show();

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (empIdTxt.Text == updateNV && prjIdTxt.Text == updateMADA)
                {
                    MessageBox.Show("Không thể thêm Phân công đã có sẵn vào CSDL!!!");
                    return;
                }
                Console.WriteLine(timeTxt.Value);
                DateTime dateTimeValue = timeTxt.Value;
                string formattedDate = dateTimeValue.ToString("yyyy-MM-dd");
                String query = "INSERT INTO PH2.V_TP_PHANCONG VALUES('" + empIdTxt.Text + "', '" + prjIdTxt.Text + "', TO_DATE('" + formattedDate + "','YYYY-MM-DD'))";
                MessageBox.Show(query);
                OracleCommand cmd = new OracleCommand(query, Form1.getConnection());

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công!!!");
                else
                    MessageBox.Show("Thêm thất bại!!!");
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTimeValue = timeTxt.Value;
                string formattedDate = dateTimeValue.ToString("yyyy-MM-dd");
                String query = "DELETE FROM PH2.V_TP_PHANCONG WHERE MANV = '" + empIdTxt.Text + "' AND MADA = '" + prjIdTxt.Text + "'AND THOIGIAN = DATE '" + formattedDate + "'";


                MessageBox.Show(query);
                OracleCommand cmd = new OracleCommand(query, Form1.getConnection());

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Xóa thành công!!!");
                else
                    MessageBox.Show("Xóa thất bại!!!");
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }



        private void updateBtn_Click(object sender, EventArgs e)
        {
            try

            {
                DateTime dateTimeValue = timeTxt.Value;
                string formattedDate = dateTimeValue.ToString("yyyy-MM-dd");
                String query = " UPDATE PH2.V_TP_PHANCONG SET MANV = '" + empIdTxt.Text + "', MADA = '" + prjIdTxt.Text + "', THOIGIAN = TO_DATE('" + formattedDate + "', 'YYYY-MM-DD') WHERE MANV = '" + updateNV + "' AND MADA = '" + updateMADA + "'";
                //MessageBox.Show(query);
                OracleCommand cmd = new OracleCommand(query, Form1.getConnection());

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Cập nhật thành công!!!");
                else
                    MessageBox.Show("Cập nhật thất bại!!!");

            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            updateNV = empIdTxt.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();
            updateMADA = prjIdTxt.Text = dataGridView1.CurrentRow.Cells["MADA"].Value.ToString();

        }

        //private void raiseTable(DataGridView dgv, string SQLCommand)
        //{


        //    OracleDataAdapter adt = new OracleDataAdapter(SQLCommand, connection);

        //    DataTable userTable = new DataTable();

        //    adt.Fill(userTable);
        //    if (userTable.Rows.Count < 1)
        //    {
        //        System.Diagnostics.Debug.WriteLine("here we go again");
        //        return;
        //    }

        //    dgv.DataSource = userTable;
        //}
        //public TruongPhong_DSNV_HieuChinh(string user, OracleConnection con)
        //{
        //    //username = user;
        //    connection = con;
        //    InitializeComponent();

        //    try
        //    {
        //        raiseTable(dataGridView1, "select * from ATBM.Vw_TruongPhongToNhanVien");
        //        dataGridView1.Show();
        //    }
        //    catch (OracleException ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
