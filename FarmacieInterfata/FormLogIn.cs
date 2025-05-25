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
    public partial class FormLogIn: Form
    {
        private ToolTip toolTipAfisare = new ToolTip();
        private string caleParola = "parola.txt";
        private string parolaCurenta;
        public FormLogIn()
        {
             
        InitializeComponent();

            if (File.Exists(caleParola))
            {
                parolaCurenta = File.ReadAllText(caleParola).Trim();
            }
            else
            {
                parolaCurenta = "admin123"; 
                File.WriteAllText(caleParola, parolaCurenta);
            }

            toolTipAfisare.SetToolTip(buttonAfiseazaParola, "Click pentru a vedea parola");
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParola.Text.Trim()))
            {
                labelEroare.Text = "Parola trebuie completată!";
                labelEroare.Visible = true;
                return;
            }

            if (textBoxParola.Text.Trim() == parolaCurenta)
            {
                FormAdministrare fAdmin = new FormAdministrare();
                fAdmin.Show();
                this.Hide();
            }
            else
            {
                labelEroare.Text = "Parolă incorectă!";
                labelEroare.Visible = true;
                textBoxParola.Clear();
                textBoxParola.Focus();
            }
        }

        private void buttonSchimba_Click(object sender, EventArgs e)
        {
            FormSchimba fSchimba = new FormSchimba();
            fSchimba.Show();
            this.Hide();
        }

        private void buttonAfiseazaParola_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Parola curentă este: {parolaCurenta}", "Parolă recuperată");
        }
    }
    }

