using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityTier;
using BusinessTier;

namespace PresentationTier
{
    public partial class User : Form
    {
        E_VISIT objEntity = new E_VISIT();
        B_VISIT objBusiness = new B_VISIT();
        B_USER objUser = new B_USER();
        E_USER objEUser = new E_USER();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            
            USERSDTVIEW.DataSource = objBusiness.ListAllVisit();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            const string message =
       "Estas seguro que deseas cerrar sesion?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            // If the no button was pressed ...  
            if (result == DialogResult.Yes)
            {
                this.Close();
                Home Form1_ = new Home();
                Form1_.Show();
                // cancel the closure of the form.  

            }
        }

        private void AdminVisitBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            AdminVisit Admin = new AdminVisit();
            Admin.Show();
        }

        private void Minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
