using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormAdministrare : Form
    {
        public FormAdministrare()
        {
            InitializeComponent();

        }

        private void buttonAdaugaClient_Click(object sender, EventArgs e)
        {
            FormAfisareClienti formAClient = new FormAfisareClienti();

            formAClient.Show();


            this.Hide();
        }



        private void buttonAdaugaMedicament_Click(object sender, EventArgs e)
        {
            
            FormAfisareMedicamente formAMedicament = new FormAfisareMedicamente();

            
            formAMedicament.Show();


            this.Hide();
        }

        private void buttonDeconectare_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur dorești să te deloghezi?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormLogIn loginForm = new FormLogIn();
                loginForm.Show();
                this.Close();
            }
        }
    }
}


