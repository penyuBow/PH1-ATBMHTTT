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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_QuanLyQuyen_Click(object sender, EventArgs e)
        {
            QLPrivs qLPrivs = new QLPrivs();
            this.Hide();
            qLPrivs.ShowDialog();
            this.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1.txtUsername.Text = "";
            //Form1.txtPassword.Text = "";
        }

        private void btn_QuanLyUserRole_Click(object sender, EventArgs e)
        {
            QLUser_Role qLUserRole = new QLUser_Role();
            this.Hide();
            qLUserRole.ShowDialog();
            this.Show();
        }

        private void btn_ThongTinQuyen_Click(object sender, EventArgs e)
        {
            InfPrivs infPrivs = new InfPrivs();
            this.Hide();
            infPrivs.ShowDialog();
            this.Show();
        }

       

        private void btn_DSDoiTuong_Click(object sender, EventArgs e)
        {   Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

       
    }
}
