﻿using Oracle.ManagedDataAccess.Client;
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
using PHANHE_1.PhanHe_2.UserController;

namespace PHANHE_1.PhanHe_2.UserController
{
    public partial class Encryption : UserControl
    {
        String username;
        OracleConnection connection;


        public Encryption()
        {
            InitializeComponent();
        }
        public Encryption(String user, OracleConnection connection)
        {
            EnterKey dialog = new EnterKey();
            DialogResult result = dialog.ShowDialog();
            this.connection = connection;
            this.username = user;
            if (result == DialogResult.OK)
            {
                string text_key = dialog.Key;
                if (text_key == "")
                {
                    MessageBox.Show("Please enter key to continue");
                    return;
                }

                OracleCommand command = new OracleCommand("select key from PH2.V_KEY", connection);
                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    string key = reader.GetString(0);
                    if (key == text_key)
                    {
                        dialog.Close();
                        InitializeComponent();

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }


                }
            }


        }
        private void Encryption_Load(object sender, EventArgs e)
        {

            OracleDataAdapter adt = new OracleDataAdapter("select MANV, cast(key as varchar2(1000)) key from PH2.SAVE_KEY", connection);

            DataTable table = new DataTable();

            adt.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OracleCommand command = new OracleCommand("BEGIN PH2.KEY_UPDATE; END;", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Procedure executed successfully");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Hiển thị thông báo lỗi cho người dùng
            MessageBox.Show("Error: " + e.Exception.Message);

            // Ngăn không cho lỗi được ném ra và hiển thị hộp thoại mặc định
            e.ThrowException = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
