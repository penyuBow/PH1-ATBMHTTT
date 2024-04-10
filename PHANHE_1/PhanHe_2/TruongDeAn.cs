﻿using Oracle.ManagedDataAccess.Client;
using PHANHE_1.PhanHe_2.UserController;
using Phase_1.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE_1.PhanHe_2
{
    public partial class TruongDeAn : Form
    {
        bool sidebarExpand;
        bool profileCollapsed;
        OracleConnection connection = null;
        String username;
        public TruongDeAn()
        {
            InitializeComponent();
        }
        public TruongDeAn(string user, OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.username = user;

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProfileTimer.Start();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AllLayout.showProfile(panelContainer);
        }

        private void button25_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(new Home(panelContainer));
            Home.SetParentForm(this);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            AllLayout.showTask(panelContainer);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AllLayout.showDepartment(panelContainer);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TruongDeAn_CapNhatDeAn tda = new TruongDeAn_CapNhatDeAn(username, connection);
            addUserControl(tda);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            AllLayout.showNotification(panelContainer);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
