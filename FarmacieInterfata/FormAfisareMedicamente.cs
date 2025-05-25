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

            dataGridViewMedicament.ColumnCount = 4;
            dataGridViewMedicament.Columns[0].Name = "Denumire";
            dataGridViewMedicament.Columns[1].Name = "Pret";
            dataGridViewMedicament.Columns[2].Name = "Necesita Reteta?";
            dataGridViewMedicament.Columns[3].Name = "Categorie";

            IncarcaMedicamenteDinFisier();
        }

        public void AdaugaMedicamentInTabel(Medicament medicament)
        {
            dataGridViewMedicament.Rows.Add(medicament.denumire, medicament.pret, medicament.necesitaReteta ? "Da" : "Nu", medicament.categorie);
        }

        public void IncarcaMedicamenteDinFisier()
        {
            dataGridViewMedicament.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicament.Rows.Clear();

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
            FormAdministrare form = new FormAdministrare();
            form.Show();
            this.Hide();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {   
            string cuvant = textBoxCautare.Text.Trim();

            if (string.IsNullOrEmpty(cuvant))
            {
                IncarcaMedicamenteDinFisier();
                return;
            }

              int nrMedicamente;
              Medicament[] toateMedicamentele = adminMedicamente.GetMedicamente(out nrMedicamente);

              Medicament[] rezultate = AdministrareMedicamentFisier.cautareINdenumire(toateMedicamentele, cuvant);

              dataGridViewMedicament.Rows.Clear();
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
            if (dataGridViewMedicament.SelectedRows.Count > 0)
            {
                string denumireSelectata = dataGridViewMedicament.SelectedRows[0].Cells[0].Value.ToString();

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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMedicament.Rows.Count) // verifica indexul sa fie valid
            {
                DataGridViewRow row = dataGridViewMedicament.Rows[e.RowIndex];

               
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
