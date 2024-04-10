﻿using System;
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
    public partial class Notification : UserControl
    {
        private string username;
        private OracleConnection connection;
        Panel container;
        Dictionary<string, string> obj = new Dictionary<string, string> { { "Giam Doc", "GD" }, { "Truong Phong", "TP" }, { "Nhan Vien", "NV" }, { "All", "NV" } };
        Dictionary<string, string> field = new Dictionary<string, string> { { "Gia Cong", "GC" }, { "San Xuat", "SX" }, { "Mua Ban", "MB" }, { "All", "null" } };
        Dictionary<string, string> region = new Dictionary<string, string> { { "Mien Bac", "MB" }, { "Mien Trung", "MT" }, { "Mien Nam", "MN" }, { "All", "null" } };

        public Notification()
        {
            InitializeComponent();
        }

        public Notification(string user, OracleConnection conn, Panel panelContainer)
        {
            username = user;
            connection = conn;
            container = panelContainer;
            InitializeComponent();

            if (Form1.getRole() == "admin" || Form1.getRole().ToUpper() == "NHAN SU")
            {
                sendNotificationButton.Show();

            } else
            {
                sendNotificationButton.Hide();
            }
            //Trả kết quả về cho dataGridView1
            bool x = HelperControl.raiseTable(dataGridView1, "select * from PH2_OLS.V_THONGBAO", Form1.getConnection());
            if (x)
            {
                dataGridView1.Columns[0].Width = 300; // set the width of the first column to 100 pixels
            }
            
        }

  
       
        private void sendNotificationButton_Click(object sender, EventArgs e)
        {
            AddNotification an = new AddNotification(username, connection);
            //this.Hide();
            
            HelperControl.addUserControl(container, an);
            an.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
