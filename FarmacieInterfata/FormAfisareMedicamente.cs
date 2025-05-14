using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormAfisareMedicamente : Form
    {
        private AdministrareMedicamentFisier adminMedicamente;

        public FormAfisareMedicamente()
        {
            InitializeComponent();

            adminMedicamente = new AdministrareMedicamentFisier("medicamente.txt");

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Denumire";
            dataGridView1.Columns[1].Name = "Pret";
            dataGridView1.Columns[2].Name = "Necesita Reteta?";
            dataGridView1.Columns[3].Name = "Categorie";

            IncarcaMedicamenteDinFisier();
        }

        public void AdaugaMedicamentInTabel(Medicament medicament)
        {
            dataGridView1.Rows.Add(medicament.denumire, medicament.pret, medicament.necesitaReteta ? "Da" : "Nu", medicament.categorie);
        }

        public void IncarcaMedicamenteDinFisier()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows.Clear();

            int nrMedicamente;
            Medicament[] medicamente = adminMedicamente.GetMedicamente(out nrMedicamente);

            foreach (var medicament in medicamente)
            {
                if (medicament != null)
                {
                    AdaugaMedicamentInTabel(medicament);
                }
            }
        }

        private void buttonAdauga_click(object sender, EventArgs e)
        {
            FormMedicament formMedicament = new FormMedicament();
            formMedicament.Show();
            this.Hide();
        }

        private void buttonInapoi_click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

           private void btnCauta_Click(object sender, EventArgs e)
        {
            string cuvant = textCautare.Text.Trim();

            if (string.IsNullOrEmpty(cuvant))
            {
                IncarcaMedicamenteDinFisier();
                return;
            }

            int nrMedicamente;
            Medicament[] toateMedicamentele = adminMedicamente.GetMedicamente(out nrMedicamente);

            Medicament[] rezultate = AdministrareMedicamentFisier.cautareINdenumire(toateMedicamentele, cuvant);

            dataGridView1.Rows.Clear();
            foreach (var medicament in rezultate)
            {
                if (medicament != null)
                {
                    AdaugaMedicamentInTabel(medicament);
                }
            }
        }

        

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string denumireSelectata = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                var confirmare = MessageBox.Show($"Sigur dorești să ștergi medicamentul '{denumireSelectata}'?", "Confirmare", MessageBoxButtons.YesNo);
                if (confirmare == DialogResult.Yes)
                {
                    bool sters = adminMedicamente.StergeMedicament(denumireSelectata);

                    if (sters)
                    {
                        MessageBox.Show("Medicamentul a fost șters.");
                        IncarcaMedicamenteDinFisier(); // Reîncarcă tabelul
                    }
                    else
                    {
                        MessageBox.Show("Medicamentul nu a fost găsit sau nu a putut fi șters.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament din listă pentru a-l șterge.");
            }
        }

        private void Editare_doubleclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

               //Daca Valoarea este diferita de null, o schimba intr-o valoare implicita
                string denumire = row.Cells[0].Value?.ToString();
                float pret = float.Parse(row.Cells[1].Value?.ToString());
                bool necesitaReteta = row.Cells[2].Value?.ToString() == "Da";
                Categorie categorie = (Categorie)Enum.Parse(typeof(Categorie), row.Cells[3].Value?.ToString());

                
                Medicament medicamentEditat = new Medicament();
                
                medicamentEditat.denumire = denumire;
                medicamentEditat.pret = pret;
                medicamentEditat.necesitaReteta = necesitaReteta;
                medicamentEditat.categorie = categorie;



                FormMedicament formEditare = new FormMedicament(medicamentEditat);
                formEditare.Show();
                this.Hide();
            }
        }
    }
}
