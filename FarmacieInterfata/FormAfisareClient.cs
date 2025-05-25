using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormAfisareClienti : Form
    {
        private AdministrareClientFisier adminClienti;

        public FormAfisareClienti()
        {
            InitializeComponent();

            adminClienti = new AdministrareClientFisier("clienti.txt");

            dataGridViewClienti.ColumnCount = 4;
            dataGridViewClienti.Columns[0].Name = "Nume";
            dataGridViewClienti.Columns[1].Name = "Prenume";
            dataGridViewClienti.Columns[2].Name = "Data Nașterii";
            dataGridViewClienti.Columns[3].Name = "Varsta";

            IncarcaClientiDinFisier();

        }

        private int CalculeazaVarsta(DateTime dataNasterii)
        {
            DateTime azi = DateTime.Now;
            int varsta = azi.Year - dataNasterii.Year;
            if (azi.Month < dataNasterii.Month || (azi.Month == dataNasterii.Month && azi.Day < dataNasterii.Day))
            {
                varsta--;
            }
            return varsta;
        }



        public void AdaugaClientInTabel(Client client)
        {
            int varsta = CalculeazaVarsta(client.data_nasterii);
            dataGridViewClienti.Rows.Add(client.nume, client.prenume, client.data_nasterii.ToShortDateString(), varsta);
        }


        public void IncarcaClientiDinFisier()
        {
            dataGridViewClienti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewClienti.Rows.Clear();


            int nrClienti;
            Client[] clienti = adminClienti.GetClient(out nrClienti);


            foreach (var client in clienti)
            {
                if (client != null)
                {
                    AdaugaClientInTabel(client);
                }
            }
        }

        private void buttonAdauga_click(object sender, EventArgs e)
        {

            FormClient formClient = new FormClient();


            formClient.Show();


            this.Hide();
        }

        private void buttonInapoi_click(object sender, EventArgs e)
        {
            FormAdministrare form = new FormAdministrare();
            form.Show();
            this.Hide();
        }

        private void buttonCauta_click(object sender, EventArgs e)
        {
            string cuvant = textBoxCautare.Text.Trim();

            if (string.IsNullOrEmpty(cuvant))
            {
                IncarcaClientiDinFisier();
                return;
            }

            int nrClienti;
            Client[] totiClientii = adminClienti.GetClient(out nrClienti);

            Client[] rezultate = AdministrareClientFisier.CautareDupaNumeSauPrenume(totiClientii, cuvant);

            dataGridViewClienti.Rows.Clear();
            foreach (var client in rezultate)
            {
                if (client != null)
                {
                    AdaugaClientInTabel(client);
                }
            }
        }

        private void buttonStergeClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClienti.SelectedRows.Count > 0)
            {
                string nume = dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                string prenume = dataGridViewClienti.SelectedRows[0].Cells[1].Value.ToString();

                var confirmare = MessageBox.Show($"Sigur dorești să ștergi clientul {nume} {prenume}?", "Confirmare", MessageBoxButtons.YesNo);

                if (confirmare == DialogResult.Yes)
                {
                    bool sters = adminClienti.StergeClient(nume, prenume); 

                    if (sters)
                    {
                        MessageBox.Show("Clientul a fost șters.");
                        IncarcaClientiDinFisier();
                    }
                    else
                    {
                        MessageBox.Show("Clientul nu a fost găsit.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectează un client din listă pentru a-l șterge.");
            }
        }

        private void Editare_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewClienti.Rows.Count)
            {
                DataGridViewRow row = dataGridViewClienti.Rows[e.RowIndex];
                string nume = row.Cells[0].Value.ToString();
                string prenume = row.Cells[1].Value.ToString();
                DateTime dataNasterii = DateTime.Parse(row.Cells[2].Value.ToString());

                Client clientEditat = new Client(nume, prenume, dataNasterii);

                FormClient formClient = new FormClient(clientEditat);
                formClient.Show();
                this.Hide();


            }
        }


    }
}
