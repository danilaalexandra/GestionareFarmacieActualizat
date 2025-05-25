using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FarmacieInterfata
{
    public partial class FormSchimba: Form
    {
        public FormSchimba()
        {
            InitializeComponent();
        }

        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            
            labelEroareParolaVeche.Visible = false;
            labelEroareParolaNoua.Visible = false;
            labelEroareParolaConfirmata.Visible = false;

            string caleParola = "parola.txt";
            string parolaCurenta = File.Exists(caleParola) ? File.ReadAllText(caleParola).Trim() : "admin123";

            string parolaVeche = textBoxParolaVeche.Text.Trim();
            string parolaNoua = textBoxParolaNoua.Text.Trim();
            string confirmareParola = textBoxConfirmare.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(parolaVeche))
            {
                errorProvider1.SetError(textBoxParolaVeche, "Completează parola veche.");
                labelEroareParolaVeche.Text = "Completează parola veche.";
                labelEroareParolaVeche.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(parolaNoua))
            {
                errorProvider1.SetError(textBoxParolaNoua, "Completează parola nouă.");
                labelEroareParolaNoua.Text = "Completează parola nouă.";
                labelEroareParolaNoua.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(confirmareParola))
            {
                errorProvider1.SetError(textBoxConfirmare, "Confirmă parola nouă.");
                labelEroareParolaConfirmata.Text = "Confirmă parola nouă.";
                labelEroareParolaConfirmata.Visible = true;
                valid = false;
            }

            
            if (!valid) return false;

           
            if (parolaVeche != parolaCurenta)
            {
                errorProvider1.SetError(textBoxParolaVeche, "Parola veche este incorectă.");
                labelEroareParolaVeche.Text = "Parola veche este incorectă.";
                labelEroareParolaVeche.Visible = true;
                valid = false;
            }

            
            if (parolaNoua != confirmareParola)
            {
                errorProvider1.SetError(textBoxConfirmare, "Parolele nu coincid.");
                labelEroareParolaConfirmata.Text = "Parolele nu coincid.";
                labelEroareParolaConfirmata.Visible = true;
                valid = false;
            }

            return valid;
        }

        private void buttonSchimbaParola_Click(object sender, EventArgs e)
        {
            if (ValidareInput())
            {
                File.WriteAllText("parola.txt", textBoxParolaNoua.Text.Trim());

                MessageBox.Show("Parola a fost schimbată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormLogIn formLogin = new FormLogIn();
                formLogin.Show();
                this.Close();
            }
        }
    }
}
