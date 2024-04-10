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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANHE_1.PhanHe_2
{
    public partial class NhanVien : Form
    {
        bool sidebarExpand;
        bool profileCollapsed;
         
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public NhanVien()
        {
            InitializeComponent();
            
        }
        private void picAvatar_Click(object sender, EventArgs e)
        {
            ProfileTimer.Start();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            AllLayout.showProfile(panelContainer);

        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void btnPhongban_Click(object sender, EventArgs e)
        {
            AllLayout.showDepartment(panelContainer);
        }

        private void btnDeAn_Click(object sender, EventArgs e)
        {
            AllLayout.showProject(panelContainer);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            AllLayout.showNotification(panelContainer);
        }

        private void button24_Click(object sender, EventArgs e)
        {
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            addUserControl(new Home(panelContainer));
            Home.SetParentForm(this);

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            addUserControl(new NhanVien_PhanCong());
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
