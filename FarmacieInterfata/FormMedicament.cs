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

            textBox1.Text = medicament.denumire;
            numericUpDown1.Value = (decimal)medicament.pret;
            radioButton1.Checked = medicament.necesitaReteta;
            radioButton2.Checked = !medicament.necesitaReteta;
            comboBox1.SelectedItem = medicament.categorie;
        }
        private void InitializareComboBoxCategorie()
        {
            List<object> categorii = new List<object>();
            categorii.Add("-- Selectează categoria --");
            categorii.AddRange(Enum.GetValues(typeof(Categorie)).Cast<object>());
            comboBox1.DataSource = categorii;
            comboBox1.SelectedIndex = 0;
        }


        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Denumirea este obligatorie!");
                label5.Text = "Denumirea este obligatorie!";
                label5.Visible = true;
                valid = false;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorProvider1.SetError(radioButton2, "Selectați dacă necesită rețetă!");
                label7.Text = "Selectați dacă necesită rețetă!";
                label7.Visible = true;
                valid = false;
            }
            if (numericUpDown1.Value <= 0)
            {
                errorProvider1.SetError(numericUpDown1, "Introduceți un preț mai mare decât 0!");
                label6.Text = "Introduceți un preț mai mare decât 0!";
                label6.Visible = true;
                valid = false;
            }

            if (!(comboBox1.SelectedItem is Categorie))
            {
                errorProvider1.SetError(comboBox1, "Selectați o categorie!");
                label8.Text = "Selectați o categorie!";
                label8.Visible = true;
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
                string denumire = textBox1.Text.Trim();
                float pret = (float)numericUpDown1.Value;
                bool necesitaReteta = radioButton1.Checked;
                Categorie categorieAleasa = (Categorie)comboBox1.SelectedItem;

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


                textBox1.Clear();
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();

                errorProvider1.Clear();
                label4.Visible = false;
                label6.Visible = false;
                label8.Visible = false;
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
