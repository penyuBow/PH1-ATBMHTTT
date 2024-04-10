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
using PHANHE_1.Class;
using PHANHE_1.PhanHe_2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PHANHE_1
{
    public partial class Form1 : Form
    {
        private static string usernameLogin;
        private static string role;
        private static OracleConnection connection;
        private static string pass_hash;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {

        }

        private void lbn_Password_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            //Class.DBUtils.Disconnect();
            Application.Exit();
        }

        private void lbn_Username_Click(object sender, EventArgs e)
        {

        }
        public static string authenFunc(OracleConnection connection)
        {
            try
            {
                OracleCommand command = new OracleCommand("select vaitro from PH2.V_NHANVIEN", connection);
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

            return "admin";
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            string hostname = txtHostname.Text.ToString();
            string port = txtPort.Text.ToString();
            string isSYSDBA = check_DBASYS.Checked == true ? ";DBA Privilege = SYSDBA" : " ";
            System.Diagnostics.Debug.WriteLine(usernameLogin + " " + password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username hoặc Mật Khẩu Trống");
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
            else
            {
                usernameLogin = username;

           

                if (check_DBASYS.Checked == true)
                {


                    connection = Class.DBUtils.GetConnectionPhase2(usernameLogin, password, hostname, port, isSYSDBA);
                    
                    
                    if ((Login(username, password, hostname, port, isSYSDBA)))
                    {
                        Login_Info.USERNAME = username;
                        Login_Info.PASSWORD = password;
                        Form2 f1 = new Form2();
                        this.Hide();
                        f1.ShowDialog();
                        this.Show();
                        return;




                    }
                    else
                    {
                        MessageBox.Show("Something went wrong ! Please try again");
                        return;

                    }

                }
                else
                {
                    (string pass_salt, string salt) = Cryptography.addSalt(password, username);
                    pass_hash = Cryptography.SHA512_ComputeHash(pass_salt);
                    string noDBASYS = " ";
                    connection = Class.DBUtils.GetConnectionPhase2(usernameLogin, password, hostname, port, noDBASYS);
                    string checkPWS = Class.DBUtils.authenMSNV(username, Form1.getConnection());
                    if (checkPWS != "null" && checkPWS == pass_hash)
                    {
                        role = authenFunc(connection);
                        System.Diagnostics.Debug.WriteLine(role);
                        switch (role.ToUpper())
                        {

                            case "QUAN LY":
                                {
                                    QuanLyTrucTiep l = new QuanLyTrucTiep(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "TRUONG PHONG":
                                {
                                    TruongPhong l = new TruongPhong(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "NHAN SU":
                                {
                                    NhanSu l = new NhanSu(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "TAI CHINH":
                                {
                                    TaiChinh l = new TaiChinh(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "BAN GIAM DOC":
                                {
                                    GiamDoc l = new GiamDoc(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "GIAM DOC":
                                {
                                    GiamDoc l = new GiamDoc(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case "TRUONG DE AN":
                                {
                                    TruongDeAn l = new TruongDeAn(username, connection);
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            default:
                                {  //default se la nhan vien
                                    NhanVien l = new NhanVien();
                                    this.Hide();
                                    l.ShowDialog();
                                    this.Show();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu !!!");

                        return;
                    }

                }

                //this.Hide();


                //Login_Info.USERNAME = username;
                //Login_Info.PASSWORD = password;
                //Form2 f = new Form2();
                //this.Hide();
                //f.ShowDialog();
                //this.Show();
            }


        }
        /* ALL USER:
        -- Truong de an:    TDA037
        -- Nhan vien:       NV100
        -- Nhan su:         NS015
        -- TaiChinh:        TC010
        -- Truong phong:    TP040
        -- Quan li:         QL030
        -- admin phase 1:   DB_manage
        -- admin OLS:       OLS_Admin
        -- audit Admi:
        -- security admin:
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool Login(string username, string password, string host, string port, string isSYSDBA)
        {

            bool isConnect = Class.DBUtils.Connect(username, password, host, port, isSYSDBA);

            if (isConnect)
            {
                try
                {
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtHostname.Text = "";
                txtPort.Text = " ";
                return false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void check_DBASYS_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static string getUsername()
        {
            return usernameLogin;
        }

        public static string getRole()
        {
            return role;
        }

        //public static OracleConnection getConnection()
        //{
        //    return connection;
        //}
        public static OracleConnection getConnection()
        {
            return connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            string hostname = txtHostname.Text.ToString();
            string port = txtPort.Text.ToString();
            string isSYSDBA = check_DBASYS.Checked == true ? ";DBA Privilege = SYSDBA" : " ";
            System.Diagnostics.Debug.WriteLine(usernameLogin + " " + password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username hoặc Mật Khẩu Trống");
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
            else
            {
                usernameLogin = username;

                System.Diagnostics.Debug.WriteLine(role);

                if (check_DBASYS.Checked == true)
                {


                    connection = Class.DBUtils.GetConnectionPhase2(usernameLogin, password, hostname, port, " ");
                   

                    if ((Login(username, password, hostname, port, " ")))
                    {
                        Admin l = new Admin(username, connection);
                        this.Hide();
                        l.ShowDialog();
                        this.Show();
                        return;




                    }
                    else
                    {
                        MessageBox.Show("Something went wrong ! Please try again");
                        return;

                    }
                }
            }
        }
    }
}
