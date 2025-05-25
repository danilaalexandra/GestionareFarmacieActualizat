using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormClient : Form
    {
        private AdministrareClientFisier adminClienti;
        private Client clientEditat;
        public FormClient()
        {
            InitializeComponent();
            adminClienti = new AdministrareClientFisier("clienti.txt");

           
            labelNume.Visible = false;
            labelPrenume.Visible = false;
            labelDataNasterii.Visible = false;
        }

        public FormClient(Client client)
        {
            InitializeComponent();
            adminClienti = new AdministrareClientFisier("clienti.txt");


            labelNume.Visible = false;
            labelPrenume.Visible = false;
            labelDataNasterii.Visible = false;

            clientEditat = client;

            textBoxNume.Text = client.nume;
            textBoxPrenume.Text = client.prenume;
            dateTimePickerDataNasterii.Value = client.data_nasterii;
        }
        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            labelNume.Visible = false;
            labelPrenume.Visible = false;
            labelDataNasterii.Visible = false;

            if (string.IsNullOrWhiteSpace(textBoxNume.Text))
            {
                errorProvider1.SetError(textBoxNume, "Prenumele este obligatoriu!");
                labelNume.Text = "Prenumele este obligatoriu!";
                labelNume.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrenume.Text))
            {
                errorProvider1.SetError(textBoxPrenume, "Numele este obligatoriu!");
                labelPrenume.Text = "Numele este obligatoriu!";
                labelPrenume.Visible = true;
                valid = false;
            }

            if (dateTimePickerDataNasterii.Value > DateTime.Today)
            {
                errorProvider1.SetError(dateTimePickerDataNasterii, "Data nașterii nu a fost adăugată!");
                labelDataNasterii.Text = "Data nașterii nu a fost adăugată!";
                labelDataNasterii.Visible = true;
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
                Client client = new Client(textBoxNume.Text.Trim(), textBoxPrenume.Text.Trim(), dateTimePickerDataNasterii.Value);

                if(clientEditat != null)
                {
                    client.nume = clientEditat.nume;
                    adminClienti.StergeClient(clientEditat.nume, clientEditat.prenume);
                }

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

                textBoxNume.Clear();
                textBoxPrenume.Clear();
                dateTimePickerDataNasterii.Value = DateTime.Today;
                textBoxNume.Focus();

                errorProvider1.Clear();
                labelNume.Visible = false;
                labelPrenume.Visible = false;
                labelDataNasterii.Visible = false;
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
