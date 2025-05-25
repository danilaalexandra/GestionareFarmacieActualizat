using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace FarmacieInterfata
{
    public partial class FormMedicament : Form
    {
        private AdministrareMedicamentFisier adminMedicamente;
        private Medicament medicamentEditat;
        public FormMedicament()
        {
            InitializeComponent();
            adminMedicamente = new AdministrareMedicamentFisier("medicamente.txt");

            
            InitializareComboBoxCategorie();
        }

        public FormMedicament(Medicament medicament)
        {
            InitializeComponent();
            adminMedicamente = new AdministrareMedicamentFisier("medicamente.txt");
            InitializareComboBoxCategorie();

           
            medicamentEditat = medicament;

            textBoxDenumire.Text = medicament.denumire;
            numericUpDownPret.Value = (decimal)medicament.pret;
            radioButtonDa.Checked = medicament.necesitaReteta;
            radioButtonNu.Checked = !medicament.necesitaReteta;
            comboBoxCategorie.SelectedItem = medicament.categorie;
        }
        private void InitializareComboBoxCategorie()
        {
            List<object> categorii = new List<object>();
            categorii.Add("-- Selectează categoria --");
            categorii.AddRange(Enum.GetValues(typeof(Categorie)).Cast<object>()); // adauga in lista creata mai sus elementele din enum
            comboBoxCategorie.DataSource = categorii;
            comboBoxCategorie.SelectedIndex = 0;
        }


        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            
            labelDenumire.Visible = false;
            labelPret.Visible = false;
            labelNecesitaReteta.Visible = false;
            labelCategorie.Visible = false;


            if (string.IsNullOrWhiteSpace(textBoxDenumire.Text))
            {
                errorProvider1.SetError(textBoxDenumire, "Denumirea este obligatorie!");
                labelDenumire.Text = "Denumirea este obligatorie!";
                labelDenumire.Visible = true;
                valid = false;
            }

            if (!radioButtonDa.Checked && !radioButtonNu.Checked)
            {
                errorProvider1.SetError(radioButtonNu, "Selectați dacă necesită rețetă!");
                labelNecesitaReteta.Text = "Selectați dacă necesită rețetă!";
                labelNecesitaReteta.Visible = true;
                valid = false;
            }
            if (numericUpDownPret.Value <= 0)
            {
                errorProvider1.SetError(numericUpDownPret, "Introduceți un preț mai mare decât 0!");
                labelPret.Text = "Introduceți un preț mai mare decât 0!";
                labelPret.Visible = true;
                valid = false;
            }

            if (!(comboBoxCategorie.SelectedItem is Categorie))
            {
                errorProvider1.SetError(comboBoxCategorie, "Selectați o categorie!");
                labelCategorie.Text = "Selectați o categorie!";
                labelCategorie.Visible = true;
                valid = false;
            }
            

            return valid;
        }

         
        private void buttonAdauga_click(object sender, EventArgs e)
        {
            if (!ValidareInput())
            {
                return;
            }

            try
            {
                string denumire = textBoxDenumire.Text.Trim();
                float pret = (float)numericUpDownPret.Value;
                bool necesitaReteta = radioButtonDa.Checked;
                Categorie categorieAleasa = (Categorie)comboBoxCategorie.SelectedItem;

                Medicament medicament = new Medicament(denumire, pret, necesitaReteta)
                {
                    categorie = categorieAleasa
                };

                if (medicamentEditat != null)
                {
                    medicament.denumire = medicamentEditat.denumire; 
                    adminMedicamente.StergeMedicament(medicamentEditat.denumire);
                }
                if (adminMedicamente.MedicamentExista(medicament))
                {
                    MessageBox.Show("Medicamentul există deja!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                adminMedicamente.AddMedicament(medicament);
                this.Hide();
                FormAfisareMedicamente formAfisare = new FormAfisareMedicamente();
                formAfisare.Show();

                MessageBox.Show("Medicament adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                textBoxDenumire.Clear();
                numericUpDownPret.Value = 0;
                radioButtonDa.Checked = false;
                radioButtonNu.Checked = false;
                comboBoxCategorie.SelectedIndex = -1;
                textBoxDenumire.Focus();

                errorProvider1.Clear();
                labelDenumire.Visible = false;
                labelPret.Visible = false;
                labelCategorie.Visible = false;
                labelNecesitaReteta.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInapoi_click(object sender, EventArgs e)
        {
            FormAfisareMedicamente form = new FormAfisareMedicamente();
            
            form.Show();
            this.Hide();
        }

       
    }
}
