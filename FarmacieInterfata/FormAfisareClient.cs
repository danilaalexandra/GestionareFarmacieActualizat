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

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nume";
            dataGridView1.Columns[1].Name = "Prenume";
            dataGridView1.Columns[2].Name = "Data Nașterii";
            dataGridView1.Columns[3].Name = "Varsta";

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
            dataGridView1.Rows.Add(client.nume, client.prenume, client.data_nasterii.ToShortDateString(), varsta);
        }


        public void IncarcaClientiDinFisier()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Rows.Clear();


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
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void buttonCauta(object sender, EventArgs e)
        {
            string cuvant = textCautare.Text.Trim();

            if (string.IsNullOrEmpty(cuvant))
            {
                IncarcaClientiDinFisier();
                return;
            }

            int nrClienti;
            Client[] totiClientii = adminClienti.GetClient(out nrClienti);

            Client[] rezultate = AdministrareClientFisier.CautareDupaNumeSauPrenume(totiClientii, cuvant);

            dataGridView1.Rows.Clear();
            foreach (var client in rezultate)
            {
                if (client != null)
                {
                    AdaugaClientInTabel(client);
                }
            }
        }

        private void btnStergeClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nume = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string prenume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                var confirmare = MessageBox.Show($"Sigur dorești să ștergi clientul {nume} {prenume}?", "Confirmare", MessageBoxButtons.YesNo);

                if (confirmare == DialogResult.Yes)
                {
                    bool sters = adminClienti.StergeClient(nume, prenume); // vezi pasul următor

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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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
