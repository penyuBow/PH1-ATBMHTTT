using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE_1
{
    enum CurrentObject
    {
        USER,
        ROLE
    }
    public partial class GrantPrivs : Form

    {
        private int _currentObject; //0: user ; 1: role
        private string _objectName;
        //List<string> _privileges;
        public GrantPrivs(string objectName, int currentObject)
        {
            InitializeComponent();
            _objectName = objectName;
            this._currentObject = currentObject;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrantPrivs_Load(object sender, EventArgs e)
        {
            textBox1.Text = _objectName;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Class.DBUtils.ConAdmin;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Login_Info.USERNAME.ToUpper() + "'";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    cbbTenBang.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }

                //cmd.CommandText = "SELECT USERNAME FROM ALL_USERS";
                //OracleDataAdapter da1 = new OracleDataAdapter(cmd);
                //DataSet ds1 = new DataSet();
                //da1.Fill(ds1);
                //for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                //{
                //    cbb.Items.Add(ds1.Tables[0].Rows[i][0].ToString());

                //}


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //string privilege = _privileges[comboBox1.SelectedIndex];
                //string privilege = cbbTenQuyen.Text;
                string table = cbbTenBang.Text;
                string collumn = cbbCot.Text;
                string grantQuery;
                string grantQuery1;
                string permission = cbbTenQuyen.Text;
                string grantOption = checkBox1.Checked == true ? " WITH GRANT OPTION" : " ";
                if (_currentObject == (int)CurrentObject.USER)
                {

                    if (cbbTenQuyen.Text == "UPDATE")
                    {
                        if (collumn == "")
                        {
                            grantQuery = "GRANT " + permission + " ON " + table + " TO " + textBox1.Text + grantOption;
                        }
                        else
                        {
                            grantQuery = "GRANT " + permission + "(" + collumn + ") ON " + table + " TO " + textBox1.Text + grantOption;
                        }
                    }
                    else if (cbbTenQuyen.Text == "SELECT")
                    {
                        if (collumn != "")
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + textBox1.Text + "_" + table + "_" + collumn + " AS SELECT " + collumn + " FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + textBox1.Text + "_" + table + "_" + collumn + " TO " + textBox1.Text + grantOption;
                        }
                        else
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + textBox1.Text + "_" + table + " AS SELECT * FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + textBox1.Text + "_" + table + " TO " + textBox1.Text + grantOption;
                        }
                        OracleCommand cmd1 = Class.DBUtils.ConAdmin.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = grantQuery1;
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Tạo view cho việc phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName, grantOption });
                    }
                    else
                    {
                        grantQuery = "GRANT " + permission + " ON " + table + " TO " + textBox1.Text + grantOption;
                    }
                    OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = grantQuery;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cấp quyền cho user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_currentObject == (int)CurrentObject.ROLE)
                {

                    if (cbbTenQuyen.Text == "UPDATE")
                    {
                        if (collumn == "")
                        {
                            grantQuery = "GRANT " + permission + " ON " + table + " TO " + textBox1.Text;
                        }
                        else
                        {
                            grantQuery = "GRANT " + permission + "(" + collumn + ") ON " + table + " TO " + textBox1.Text;
                        }
                    }
                    else if (cbbTenQuyen.Text == "SELECT")
                    {
                        if (collumn != "")
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + textBox1.Text + "_" + table + "_" + collumn + " AS SELECT " + collumn + " FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + textBox1.Text + "_" + table + "_" + collumn + " TO " + textBox1.Text;
                        }
                        else
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + textBox1.Text + "_" + table + " AS SELECT * FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + textBox1.Text + "_" + table + " TO " + textBox1.Text;
                        }

                        OracleCommand cmd1 = Class.DBUtils.ConAdmin.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = grantQuery1;


                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Tạo view cho việc phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        grantQuery = "GRANT " + permission + " ON " + table + " TO " + textBox1.Text;
                    }

                    OracleCommand cmd = Class.DBUtils.ConAdmin.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = grantQuery;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cấp quyền cho role thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //string query = "BEGIN proc_OracleScript; BEGIN proc_GrantForRole( :n_privilege, :n_table , :n_objectName); END; END;";
                    //OracleCommand cmd = Class.DBUtils.Con.CreateCommand();
                    //cmd.CommandType = CommandType.Text;

                    //cmd.CommandText = query;
                    //cmd.ExecuteNonQuery();
                    //OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName });
                }
                else
                {
                    MessageBox.Show("Đối tượng không hợp lệ!\n\n", "Kết quả");
                }
                MessageBox.Show("Cấp quyền thành công!\n\n", "Kết quả");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cấp quyền!\n\n" + ex.Message, "Kết quả");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void cbbuser_permission_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbTenQuyen.Text == "DELETE" || cbbTenQuyen.Text == "INSERT" || cbbTenBang.Text == "")
                {
                    cbbCot.Text = "none";
                    cbbCot.Enabled = false;
                }
                else
                {
                    cbbCot.Enabled = true;
                    cbbCot.Text = null;
                }
            }
        }
        private void cbbuser_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbTenBang.Text != "" && cbbTenQuyen.Text != "DELETE" && cbbTenQuyen.Text != "INSERT" && cbbTenQuyen.Text != "")
                {
                    cbbCot.Enabled = true;
                    cbbCot.Text = null;
                    //OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                    try
                    {
                        //conn.Open();
                        if (_currentObject == (int)CurrentObject.USER)
                        {
                            OracleCommand cmd = new OracleCommand();
                            cmd.Connection = Class.DBUtils.ConAdmin;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME= '" + cbbTenBang.Text + "'";
                            OracleDataAdapter da = new OracleDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            cbbCot.Items.Clear();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                cbbCot.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                            }
                            //OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName, grantOption });
                        }
                        else if (_currentObject == (int)CurrentObject.ROLE)
                        {
                            OracleCommand cmd = new OracleCommand();
                            cmd.Connection = Class.DBUtils.ConAdmin;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME= '" + cbbTenBang.Text + "'";
                            OracleDataAdapter da = new OracleDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            cbbCot.Items.Clear();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                cbbCot.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                            }
                            //OracleCommand cmd = DataProvider.Instance.ExcuteNonQuery(query, new object[] { privilege, table, _objectName });
                        }
                        else
                        {
                            MessageBox.Show("Đối tượng không hợp lệ!\n\n", "Kết quả");
                        }
                        //OracleCommand cmd = new OracleCommand();
                        //cmd.Connection = Class.DBUtils.Con;
                        // cmd.CommandType = CommandType.Text;
                        // cmd.CommandText = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME= '" + cbbuser_table.Text + "'";
                        // OracleDataAdapter da = new OracleDataAdapter(cmd);
                        //DataSet ds = new DataSet();
                        //da.Fill(ds);
                        //cbbuser_collum.Items.Clear();
                        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        //{
                        //    cbbuser_collum.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        //}


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }


                }
            }
        }
    }
}
