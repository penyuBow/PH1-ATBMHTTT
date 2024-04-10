using PHANHE_1.PhanHe_2;
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

namespace PHANHE_1.PhanHe_2.UserController
{
    public partial class Home : UserControl
    {
        private Panel pContainer;
        private static Form parentForm;
        public Home()
        {
            InitializeComponent();
        }
        public static void SetParentForm(Form form)
        {
            parentForm = form;
        }
        public Home(Panel panelX)
        {
            InitializeComponent();
            pContainer = panelX;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AllLayout.addUserControl(new XemProfile(), pContainer);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            parentForm.Close();

        }
    }
}
