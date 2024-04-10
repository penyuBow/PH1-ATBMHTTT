﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PHANHE_1
{
    public partial class AddNotification : UserControl
    {
        private string username;
        private OracleConnection connection;
        Dictionary<string, string> obj = new Dictionary<string, string> { { "Giam Doc", "GD" }, { "Truong Phong", "TP" }, { "Nhan Vien", "NV" }, { "All", "NV" } };
        Dictionary<string, string> field = new Dictionary<string, string> { { "Gia Cong", "GC" }, { "San Xuat", "SX" }, { "Mua Ban", "MB" }, { "All", "null" } };
        Dictionary<string, string> region = new Dictionary<string, string> { { "Mien Bac", "MB" }, { "Mien Trung", "MT" }, { "Mien Nam", "MN" }, { "All", "null" } };

        public AddNotification()
        {
            InitializeComponent();
        }

        public AddNotification(string user, OracleConnection conn)
        {
            username = user;
            connection = conn;
            InitializeComponent();
            addComboBox(objectComboBox, obj);
            addComboBox(fieldComboBox, field);
            addComboBox(regionComboBox, region);

            contentTextBox.Show();
            dataGridView1.Hide();
            assignToLabel.Hide();
            objectTextBox.Hide();
            assignButton.Hide();

        }

        public void addNotification()
        {

            string doiTuong, linhVuc, khuVuc, label;



        }

        public void addComboBox(CheckedListBox cb, Dictionary<string, string> value)
        {
            foreach (KeyValuePair<string, string> x in value)
            {
                cb.Items.Add(x.Key);
            }
        }

        public void sendNotificationButton_Click(object sender, EventArgs e)
        {

            string[] finalLabel = getDataRow();
            string content = contentTextBox.Text;

            foreach (string x in finalLabel)
            {
                System.Diagnostics.Debug.WriteLine(x);
            }
            contentTextBox.Text = "";

            //assignDataLabel(p_noiDung IN VARCHAR2,p_doiTuong IN VARCHAR2,p_linhVuc IN VARCHAR2,p_khuVuc IN VARCHAR2, p_label IN VARCHAR2);
            try
            {
                OracleCommand command = new OracleCommand("PH2_OLS" + ".THONGBAO_ADD", connection);
                // set the command type to stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // create input parameter
                OracleParameter noiDung = new OracleParameter("p_noiDung", OracleDbType.Varchar2, ParameterDirection.Input);
                noiDung.Value = content;
                OracleParameter nguoiGui = new OracleParameter("p_nguoiGui", OracleDbType.Varchar2, ParameterDirection.Input);
                nguoiGui.Value = Form1.getUsername();
                OracleParameter doiTuong = new OracleParameter("p_doiTuong", OracleDbType.Varchar2, ParameterDirection.Input);
                doiTuong.Value = finalLabel[1];
                OracleParameter linhVuc = new OracleParameter("p_linhVuc", OracleDbType.Varchar2, ParameterDirection.Input);
                if (finalLabel[2] == "")
                {
                    finalLabel[2] = null;
                }
                linhVuc.Value = finalLabel[2];
                OracleParameter khuVuc = new OracleParameter("p_khuVuc", OracleDbType.Varchar2, ParameterDirection.Input);
                if (finalLabel[3] == "")
                {
                    finalLabel[3] = null;
                }
                khuVuc.Value = finalLabel[3];
                OracleParameter label = new OracleParameter("p_label", OracleDbType.Varchar2, ParameterDirection.Input);
                label.Value = finalLabel[0];
                // add parameters to the command object
                command.Parameters.Add(noiDung);
                command.Parameters.Add(nguoiGui);
                command.Parameters.Add(doiTuong);
                command.Parameters.Add(linhVuc);
                command.Parameters.Add(khuVuc);
                command.Parameters.Add(label);


                // execute the command
                command.ExecuteNonQuery();
                MessageBox.Show("Send successful");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public string[] getDataRow()
        {
            string[] dataRow = new string[4];

            string finalLabel;
            // xu ly object (role)
            string obj = getLabelFromCheckBox(objectComboBox, ref dataRow[1]);


            if (obj == "" || obj.IndexOf("NV") != -1 || obj.IndexOf("All") != -1)
            {
                finalLabel = "NV:";
                dataRow[1] = "Nhan Vien";
            }
            else if (obj.IndexOf("TP") != -1)
            {
                finalLabel = "TP:";
                dataRow[1] = "Truong Phong";
            }
            else
            {
                finalLabel = "GD:";
                dataRow[1] = "Giam Doc";

            }

            // xu ly field - compartment
            string field = getLabelFromCheckBox(fieldComboBox, ref dataRow[2]);

            if (field == "" || field.IndexOf("All") != -1)
            {
                finalLabel += "";

            }
            else
            {
                finalLabel += field;
            }

            finalLabel += ":";

            // xu ly region - group
            string region = getLabelFromCheckBox(regionComboBox, ref dataRow[3]);

            if (region == "" || region.IndexOf("All") != -1)
            {
                finalLabel += "MB,MT,MN";
                dataRow[3] = "Mien Bac, Mien Trung, Mien Nam";

            }
            else
            {
                finalLabel += region;
            }
            dataRow[0] = finalLabel;

            return dataRow;
        }

        public string getUserLabel()
        {
            string temp = "";

            string finalLabel;
            // xu ly object (role)
            string obj = getLabelFromCheckBox(objectComboBox, ref temp);


            if (obj == "" || obj.IndexOf("NV") != -1)
            {
                finalLabel = "NV:";
            }
            else if (obj.IndexOf("TP") != -1)
            {
                finalLabel = "TP:";
            }
            else
            {
                finalLabel = "GD:";
            }

            // xu ly field - compartment
            string field = getLabelFromCheckBox(fieldComboBox, ref temp);

            if (field == "")
            {
                finalLabel += "";

            }
            else if (field.IndexOf("All") != -1)
            {
                finalLabel += "SX,GC,MB";
            }
            else
            {
                finalLabel += field;
            }

            finalLabel += ":";

            // xu ly region - group
            string region = getLabelFromCheckBox(regionComboBox, ref temp);

            if (region == "")
            {
                finalLabel += "";
            }
            else if (region.IndexOf("All") != -1)
            {
                finalLabel += "MB,MT,MN";
            }
            else
            {
                finalLabel += region;
            }

            return finalLabel;
        }

        public string getLabelFromCheckBox(CheckedListBox clb, ref string obj)
        {
            obj = "";
            string label = "";
            foreach (Object x in clb.CheckedItems)
            {
                obj += x.ToString();
                label += getShortLabel(x.ToString());
                label += ",";
                obj += ",";
            }
            clearChecked(clb);

            if (label == "") return "";

            label = label.Substring(0, label.Length - 1);
            obj = obj.Substring(0, obj.Length - 1);
            return label;
        }

        public void clearChecked(CheckedListBox clb)
        {
            foreach (int index in clb.CheckedIndices)
            {
                clb.SetItemChecked(index, false);
            }
        }


        public string getShortLabel(string x)
        {
            string label;
            switch (x)
            {
                case "San Xuat":
                    {
                        label = "SX";
                        break;
                    }
                case "Mua Ban":
                    {
                        label = "MB";
                        break;
                    }
                case "Gia Cong":
                    {
                        label = "GC";
                        break;
                    }
                case "Mien Bac":
                    {
                        label = "MB";
                        break;
                    }
                case "Mien Trung":
                    {
                        label = "MT";
                        break;
                    }
                case "Mien Nam":
                    {
                        label = "MN";
                        break;
                    }
                case "Giam Doc":
                    {
                        label = "GD";
                        break;
                    }
                case "Truong Phong":
                    {
                        label = "TP";
                        break;
                    }
                case "Nhan Vien":
                    {
                        label = "NV";
                        break;
                    }
                case "All":
                    {
                        label = "All";
                        break;
                    }
                default:
                    label = null;
                    break;
            }
            return label;
        }

        private void configEmpButton_Click(object sender, EventArgs e)
        {
            contentTextBox.Hide();
            dataGridView1.Show();
            assignToLabel.Show();
            objectTextBox.Show();
            assignButton.Show();
            string sql = "select * from " + "PH2" + ".V_NS_NHANVIEN ";
            // Hiện bảng ra dataGridView1
            HelperControl.raiseTable(dataGridView1, sql, connection);
            configEmpButton.Hide();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            contentTextBox.Show();
            dataGridView1.Hide();
            assignToLabel.Hide();
            objectTextBox.Hide();
            assignButton.Hide();
            configEmpButton.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                objectTextBox.Text = selectedRow.Cells["MANV"].Value.ToString();
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            string flabel = getUserLabel();
            System.Diagnostics.Debug.WriteLine(flabel);
            string user = objectTextBox.Text;
            objectTextBox.Text = "";
            if (user == "")
            {
                MessageBox.Show("Please choose Employee");
                return;
            }
            System.Diagnostics.Debug.WriteLine(flabel);

            try
            {
                OracleCommand command = new OracleCommand("PH2_OLS" + ".LABEL_USER", connection);
                // set the command type to stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // create input parameter

                OracleParameter doiTuong = new OracleParameter("p_user", OracleDbType.Varchar2, ParameterDirection.Input);
                doiTuong.Value = user;

                OracleParameter label = new OracleParameter("p_label", OracleDbType.Varchar2, ParameterDirection.Input);
                label.Value = flabel;
                // add parameters to the command object
                command.Parameters.Add(doiTuong);
                command.Parameters.Add(label);

                // execute the command
                command.ExecuteNonQuery();
                MessageBox.Show("Assign successful");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

      
    }
}
