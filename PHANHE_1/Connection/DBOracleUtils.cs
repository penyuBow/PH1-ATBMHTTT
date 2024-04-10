using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANHE_1.Class
{
    class DBUtils
    {
        public static OracleConnection ConAdmin;  //Khai báo đối tượng kết nối
        private static OracleConnection connection;
        public static string authenMSNV(string mssv,OracleConnection connection)
        {
            try
            {
                OracleCommand command = new OracleCommand(" SELECT PASSWORD FROM PH2.V_NHANVIEN WHERE MANV ='" + mssv+ "'", connection);
                //tim tu mang phan vaitro de tra ra vai tro
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string columnName = reader.GetString(0);
                    return columnName;
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.ToString());
            }

            return "null";
        }
        public static OracleConnection GetConnectionPhase2(string user, string pw, string host, string port,string isSYSDBA)
        {
            string username = user;
            string password = pw;
            try
            {
                string sid = "XE";
                string strConn = "User Id=" + user + ";Password=" + pw + ";Data Source=" + host + ":" + port + "/PDB0;Persist Security Info=True;" + isSYSDBA;
                
                connection = new OracleConnection(strConn);
                connection.Open();
                return connection;
                


            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return null;
            }
        }
        public static bool Connect(string username, string password, string host, string port, string isSYSDBA)
        {

            string sid = "XE";
            string strConn = "User Id=" + username + ";Password=" + password + ";Data Source=" + host + ":" + port + "/PDB0;Persist Security Info=True;"+ isSYSDBA;

            //";DBA Privilege = SYSDBA"
            ConAdmin = new OracleConnection(strConn);

            try
            {
                if (ConAdmin == null)
                {
                    ConAdmin = new OracleConnection(strConn);
                    return true;
                }
                if (ConAdmin.State == ConnectionState.Closed)
                {
                    ConAdmin.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static void Disconnect()
        {
            if (ConAdmin.State == ConnectionState.Open)
            {
                ConAdmin.Close();   	//Đóng kết nối
                ConAdmin.Dispose(); 	//Giải phóng tài nguyên
                ConAdmin = null;
            }
            else
            {
                ConAdmin = null;
            }
        }

        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            //sql = "((" + sql + "))";
            OracleDataAdapter DataAdapter = new OracleDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp OracleCommand
            DataAdapter.SelectCommand = new OracleCommand();

            DataAdapter.SelectCommand.Connection = DBUtils.ConAdmin; //Kết nối cơ sở dữ liệu
            DataAdapter.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            DataAdapter.Fill(table);
            return table;
        }


    }
}
