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
    public partial class NhanVien_PhanCong : UserControl
    {
        public NhanVien_PhanCong()
        {
            InitializeComponent();
            //pictureBox1.Hide();
            richTextBox2.Hide();
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                //Trả về kết quả của bảng dataGridView1
                bool x =  HelperControl.raiseTable(dataGridView1, "select * from PH2.V_PHANCONG", Form1.getConnection());
                if (!x)
                {
                    richTextBox2.Font = new Font("Cambira", 15, FontStyle.Regular);
                    richTextBox2.ForeColor = Color.LawnGreen;
                    richTextBox2.Text = "Congratulation !! You have no task to do :))";
                    //pictureBox1.Show();
                    richTextBox2.Show();
                    dataGridView1.Hide();
                    return;
                }
                dataGridView1.Show();
            }
            catch (OracleException ex)
            {
                System.Diagnostics.Debug.WriteLine("OracleException: " + ex.Message);
            }
        }

        private void NhanVien_PhanCong_Load(object sender, EventArgs e)
        {

        }
    }
}
