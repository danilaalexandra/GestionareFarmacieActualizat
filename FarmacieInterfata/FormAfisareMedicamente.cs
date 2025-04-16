using FarmacieLibrarie;
using NivelStocareDate;
using System;
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

        private void button_click(object sender, EventArgs e)
        {
            FormMedicament formMedicament = new FormMedicament();
            formMedicament.Show();
            this.Hide();
        }

        private void button2_click(object sender, EventArgs e)
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

       
    }
}
