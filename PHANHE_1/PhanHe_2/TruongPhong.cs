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
    public partial class TruongPhong : Form
    {
        bool sidebarExpand;
        bool taskCollapsed;
        bool profileCollapsed;
        string username;
        OracleConnection connection;
        public TruongPhong()
        {
            InitializeComponent();
        }
        public TruongPhong(string user, OracleConnection con)
        {
            username = user;
            connection = con;
            InitializeComponent();
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

        private void TaskTimer_Tick(object sender, EventArgs e)
        {
            if (taskCollapsed)
            {
                TaskContainer.Height += 10;
                if (TaskContainer.Height == TaskContainer.MaximumSize.Height)
                {
                    taskCollapsed = false;
                    TaskTimer.Stop();
                }
            }
            else
            {
                TaskContainer.Height -= 10;
                if (TaskContainer.Height == TaskContainer.MinimumSize.Height)
                {
                    taskCollapsed = true;
                    TaskTimer.Stop();
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
        private void button15_Click(object sender, EventArgs e)
        {
            AllLayout.showTask(panelContainer);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TruongPhong_DSNV_HieuChinh ql = new TruongPhong_DSNV_HieuChinh();
            addUserControl(ql);
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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            addUserControl(new Home(panelContainer));
            Home.SetParentForm(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaskTimer.Start();
        }

        private void deptListBtn_Click(object sender, EventArgs e)
        {
            AllLayout.showDepartment(panelContainer);
        }

        private void prjListBtn_Click(object sender, EventArgs e)
        {
            AllLayout.showProject(panelContainer);
        }

        private void empListBtn_Click(object sender, EventArgs e)
        {
            TruongPhong_XemNV ql = new TruongPhong_XemNV();
            addUserControl(ql);
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            AllLayout.showNotification(panelContainer);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
