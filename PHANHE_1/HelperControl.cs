using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE_1
{
    internal class HelperControl
    {
        public static bool raiseTable(DataGridView dgv, string SQLCommand, OracleConnection connection)
        {
            

            OracleDataAdapter adt = new OracleDataAdapter(SQLCommand, connection);

            DataTable userTable = new DataTable();

            adt.Fill(userTable);
            if (userTable.Rows.Count < 1)
            {
                return false;
            }

            dgv.DataSource = userTable;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            return true;
        }

        public static void addUserControl(Panel panelContainer, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
