using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormClient : Form
    {
        private AdministrareClientFisier adminClienti;

        public FormClient()
        {
            InitializeComponent();
            adminClienti = new AdministrareClientFisier("clienti.txt");

           
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Prenumele este obligatoriu!");
                label4.Text = "Prenumele este obligatoriu!";
                label4.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Numele este obligatoriu!");
                label5.Text = "Numele este obligatoriu!";
                label5.Visible = true;
                valid = false;
            }

            if (dateTimePicker1.Value > DateTime.Today)
            {
                errorProvider1.SetError(dateTimePicker1, "Data nașterii nu a fost adăugată!");
                label6.Text = "Data nașterii nu a fost adăugată!";
                label6.Visible = true;
                valid = false;
            }

            return valid;
        }

        private void buttonAdauga_Click_1(object sender, EventArgs e)
        {
            if (!ValidareInput())
            {
                return;
            }

            try
            {
                Client client = new Client(textBox1.Text.Trim(), textBox2.Text.Trim(), dateTimePicker1.Value);


                if (adminClienti.ClientExista(client))
                {
                    MessageBox.Show("Clientul există deja!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                adminClienti.AddClient(client);

                this.Hide();
                FormAfisareClienti formAfisare = new FormAfisareClienti();
                formAfisare.Show();

                MessageBox.Show("Client adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Today;
                textBox1.Focus();

                errorProvider1.Clear();
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonInapoi_click(object sender, EventArgs e)
        {
            FormAfisareClienti form = new FormAfisareClienti();
            form.Show();
            this.Hide();
        }

    }
}
