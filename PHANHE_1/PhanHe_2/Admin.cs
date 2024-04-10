using Oracle.ManagedDataAccess.Client;
using PHANHE_1.PhanHe_2;
using PHANHE_1.PhanHe_2.UserController;
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
    public partial class Admin : Form
    {
        bool sidebarExpand;
        bool profileCollapsed;
        String username;
        OracleConnection connection;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(String user, OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.username = user;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(new Home(panelContainer));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption(username, connection);
            addUserControl(encryption);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Admin_UpdateKey l = new Admin_UpdateKey(username, connection);
            addUserControl(l);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.sidebarTimer.Start();
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ProfileTimer.Start();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void ProfileTimer_Tick(object sender, EventArgs e)
        {
            if (profileCollapsed)
            {
                panelThongTin.Height += 10;
                if (panelThongTin.Height == panelThongTin.MaximumSize.Height)
                {
                    profileCollapsed = false;
                    ProfileTimer.Stop();
                }
            }
            else
            {
                panelThongTin.Height -= 10;
                if (panelThongTin.Height == panelThongTin.MinimumSize.Height)
                {
                    profileCollapsed = true;
                    ProfileTimer.Stop();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            AllLayout.showProfile(panelContainer);
        }

        private void panelThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
