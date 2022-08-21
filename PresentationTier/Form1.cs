using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using EntityTier;
using BusinessTier;

namespace PresentationTier
{
    public partial class Home : Form
    {
        E_USER objEntity = new E_USER();
        B_USER ObjBusiness = new B_USER();
        public Home()
        {
            InitializeComponent();
        }
        
        static string Encrypt(string PASS)
        {
            //USAR MD5 PARA ENCRYPTAR STRING
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding(); 
                //HASH DATA
                byte[] DATA = md5.ComputeHash(utf8.GetBytes(PASS));
                return Convert.ToBase64String(DATA);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            
            if (radioBtnAdmin.Checked == true)
            {
                radioBtnUser.Checked = false;
            } else if (radioBtnUser.Checked == true)
            {
                radioBtnAdmin.Checked = false;
            }
        }

        public void clean()
        {
            NameTxt.Text = "NOMBRE";
            LastnameTxt.Text = "APELLIDO";
            UserTxt.Text = "USUARIO";
            PasswordTxt.Text = "PASSWORD";
            BirthDatePick.Text = DateTime.Now.Date.ToString();


        }

        //Estas funciones son para eliminar los placeholder de los textbox
        private void NameTxt_Enter(object sender, EventArgs e)
        {
            if (NameTxt.Text == "NOMBRE")
            {
                NameTxt.Text = "";    
            }
        }

        private void NameTxt_Leave(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                NameTxt.Text = "NOMBRE";
            }
        }   
        private void LastnameTxt_Enter_1(object sender, EventArgs e)
        {
            if (LastnameTxt.Text == "APELLIDO")
            {
                LastnameTxt.Text = "";
            }
        }
        private void LastnameTxt_Leave(object sender, EventArgs e)
        {
            if (LastnameTxt.Text == "")
            {
                LastnameTxt.Text = "APELLIDO";
            }
        }

        private void UserTxt_Enter(object sender, EventArgs e)
        {
            if (UserTxt.Text == "USUARIO")
            {
                UserTxt.Text = "";
            }
        }

        private void UserTxt_Leave(object sender, EventArgs e)
        {
            if (UserTxt.Text == "")
            {
                UserTxt.Text = "USUARIO";
            }
        } 
        
        private void PasswordTxt_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "PASSWORD")
            {
                PasswordTxt.Text = "";
            }
        }

        private void PasswordTxt_Leave(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "")
            {
                PasswordTxt.Text = "PASSWORD";
                PasswordTxt.ForeColor = Color.DimGray;
            }
        }
        private void MailSignInTxt_Enter(object sender, EventArgs e)
        {
            if (MailSignInTxt.Text == "CORREO")
            {
                MailSignInTxt.Text = "";
            }
        }
        private void MailSignInTxt_Leave(object sender, EventArgs e)
        {
            if (MailSignInTxt.Text == "")
            {
                MailSignInTxt.Text = "CORREO";
            }
        }   
        private void PassSignInTxt_Enter(object sender, EventArgs e)
        {
            if (PassSignInTxt.Text == "PASSWORD")
            {
                PassSignInTxt.Text = "";
            }
        }  
        private void PassSignInTxt_Leave(object sender, EventArgs e)
        {
            if (PassSignInTxt.Text == "")
            {
                PassSignInTxt.Text = "PASSWORD";
                PassSignInTxt.ForeColor = Color.DimGray;
            }
        }

        private void SignUpBtnpanel_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = true;
            SignInPanel.Visible = false;
            SignUpPanel.Left = 15;
            if (SignUpPanel.Visible == true)
            {
                SignUpPanel.Visible = false;

                panelAnimator2.ShowSync(SignUpPanel);

            }


        }

        private void SignInBtnpanel_Click(object sender, EventArgs e)
        {
            SignInPanel.Visible = true;
            SignUpPanel.Visible = false;
            SignUpPanel.Left = 15;
            if (SignInPanel.Visible == true)
            {
                SignInPanel.Visible = false;
                
                panelAnimator.ShowSync(SignInPanel);
                
            }

        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


 


        private void SignInBtn_Click(object sender, EventArgs e)
        {


            if (MailSignInTxt.Text == "")
            {
                MessageBox.Show("Dejaste un campo vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailSignInTxt.Focus();
                return;
            }
            if(PassSignInTxt.Text == "")
            {
                MessageBox.Show("Dejaste un campo vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PassSignInTxt.Focus();
                return;
            }

            DataTable dt = new DataTable();
            objEntity.USER = MailSignInTxt.Text;
            objEntity.PASSWORD = PassSignInTxt.Text;
            dt = ObjBusiness.LoginUser(objEntity);

            if (dt.Rows.Count > 0)
            {
                objEntity.USER_TYPE = dt.Rows[0][5].ToString();
                objEntity.USER = dt.Rows[0][6].ToString();
                objEntity.PASSWORD = dt.Rows[0][7].ToString();


                if (objEntity.USER_TYPE == "Admin")
                {
                    this.Opacity = 0.0f;
                    this.ShowInTaskbar = false;
                    User User = new User();
                    User.Show();
                   
                    User.AdminVisitBtn.Enabled = true;
                }
                if(objEntity.USER_TYPE == "User")
                {
                    this.Opacity = 0.0f;
                    this.ShowInTaskbar = false;
                    User User = new User();
                    User.Show();
                    User.AdminVisitBtn.Enabled = false;
                }
            }

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                objEntity.NAME = NameTxt.Text.ToString();
                objEntity.LASTNAME = LastnameTxt.Text.ToString();
                objEntity.BIRTHDATE = BirthDatePick.Value;
                if(radioBtnAdmin.Checked == true)
                {
                    objEntity.USER_TYPE = "Admin";
                }
                if(radioBtnUser.Checked == true)
                {
                    objEntity.USER_TYPE = "User";
                }
                objEntity.USER = UserTxt.Text.ToString();
                string PASS = PasswordTxt.Text;
                string PASS_ENCRYPTED = Encrypt(PASS);
                objEntity.PASSWORD = PASS_ENCRYPTED;

               

                ObjBusiness.InsertUser(objEntity);
                MessageBox.Show("Usuario creado con exito!.");
                clean();

                SignInPanel.Visible = true;
                SignUpPanel.Visible = false;
                SignUpPanel.Left = 15;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro." + ex);
            }
             /*

           */
        
        }
    }
}
