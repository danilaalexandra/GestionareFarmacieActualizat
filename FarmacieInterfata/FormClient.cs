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
            // Inițializare cu numele fișierului dorit
            adminClienti = new AdministrareClientFisier("clienti.txt");
        }

        private bool ValidareInput(out string mesaj)
        {
            mesaj = string.Empty;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                mesaj = "Toate câmpurile trebuie completate!";
                return false;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                mesaj = "Data nașterii nu poate fi în viitor.";
                return false;
            }

            return true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!ValidareInput(out string mesaj))
            {
                MessageBox.Show(mesaj, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Client client = new Client(textBox1.Text.Trim(), textBox2.Text.Trim(), dateTimePicker1.Value);
                adminClienti.AddClient(client);

                MessageBox.Show("Client adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_click(object sender, EventArgs e)
        {
            // Creează o instanță a ferestrei FormClient
            Form1 form = new Form1();

            // Afișează fereastra
            form.Show();


            this.Hide();
        }
    }
}