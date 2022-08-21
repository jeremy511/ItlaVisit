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
    public partial class AdminVisit : Form
    {
        private string ID_VISIT;
        private bool edit = false;
        E_VISIT objEntity = new E_VISIT();
        B_VISIT objBusiness = new B_VISIT();

        public AdminVisit()
        {
            InitializeComponent();
        }

        private void AdminVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itlaBuildingsDataSet.CAREER' table. You can move, or remove it, as needed.
            this.cAREERTableAdapter.Fill(this.itlaBuildingsDataSet.CAREER);
            USERSDTVIEW.DataSource = objBusiness.ListAllVisit();
            ReasonTxt.MaxLength = 255;
            
            // TODO: This line of code loads data into the 'itlaBuildingsDataSet.SECTION' table. You can move, or remove it, as needed.
            this.sECTIONTableAdapter.Fill(this.itlaBuildingsDataSet.SECTION);
            // TODO: This line of code loads data into the 'itlaBuildingsDataSet.BUILDING' table. You can move, or remove it, as needed.
            this.bUILDINGTableAdapter.Fill(this.itlaBuildingsDataSet.BUILDING);

        }

        private void SaveVisitBtn_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    objEntity.NAME = NameVisitTxt.Text.ToLower();
                    objEntity.LASTNAME = LastNameVisitTxt.Text.ToLower();
                    objEntity.ID_CAREER = CareerDrop.SelectedIndex;
                    objEntity.MAIL = MailVisitTxt.Text.ToLower();
                    objEntity.ID_BUILDING = BuildDrop.SelectedIndex;
                    objEntity.ID_SECTION = SectionDrop.SelectedIndex;
                    objEntity.CHECKIN = CheckInVisit.Value;
                    objEntity.CHECKOUT = CheckOutVisit.Value;
                    objEntity.REASON = ReasonTxt.Text.ToUpper();

                    objBusiness.InsertVisit(objEntity);
                    MessageBox.Show("Registro guardado.");
                   



                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                }
            }

            if (edit == true)
            {
                try
                {
                    objEntity.ID_VISIT = Convert.ToInt32(ID_VISIT);
                    objEntity.NAME = NameVisitTxt.Text.ToLower();
                    objEntity.LASTNAME = LastNameVisitTxt.Text.ToLower();
                    objEntity.ID_CAREER = CareerDrop.SelectedIndex + 1;
                    objEntity.MAIL = MailVisitTxt.Text.ToLower();
                    objEntity.ID_BUILDING = BuildDrop.SelectedIndex + 1;
                    objEntity.ID_SECTION = SectionDrop.SelectedIndex + 1;
                    objEntity.CHECKIN = CheckInVisit.Value;
                    objEntity.CHECKOUT = CheckOutVisit.Value;
                    objEntity.REASON = ReasonTxt.Text.ToUpper();

                    objBusiness.EditVisit(objEntity);
                    MessageBox.Show("Registro editado exitosamente.");
                    
                    edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                }
            }
        }



        private void EditVisitBtn_Click(object sender, EventArgs e)
        {
            if (USERSDTVIEW.SelectedRows.Count > 0)
            {
                edit = true;
            ID_VISIT = USERSDTVIEW.CurrentRow.Cells[0].Value.ToString();
            NameVisitTxt.Text = USERSDTVIEW.CurrentRow.Cells[2].Value.ToString();
            LastNameVisitTxt.Text = USERSDTVIEW.CurrentRow.Cells[3].Value.ToString();
            CareerDrop.Text = USERSDTVIEW.CurrentRow.Cells[5].Value.ToString();
            MailVisitTxt.Text = USERSDTVIEW.CurrentRow.Cells[6].Value.ToString();
            BuildDrop.Text = USERSDTVIEW.CurrentRow.Cells[8].Value.ToString();
            SectionDrop.Text = USERSDTVIEW.CurrentRow.Cells[10].Value.ToString();
            CheckInVisit.Text = USERSDTVIEW.CurrentRow.Cells[11].Value.ToString();
            CheckOutVisit.Text = USERSDTVIEW.CurrentRow.Cells[12].Value.ToString();
            ReasonTxt.Text = USERSDTVIEW.CurrentRow.Cells[13].Value.ToString();

           }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }

           
        }

        private void DeleteVisitBtn_Click(object sender, EventArgs e)
        {
            if (USERSDTVIEW.SelectedRows.Count > 0)
            {
                objEntity.ID_VISIT = Convert.ToInt32(USERSDTVIEW.CurrentRow.Cells[0].Value.ToString());
                objBusiness.DeleteVisit(objEntity);

                MessageBox.Show("El registro ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            User User = new User();
            User.Show();

            User.AdminVisitBtn.Enabled = true;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
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

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
  }
