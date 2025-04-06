using FarmacieLibrarie;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmacieInterfata
{
    public partial class FormMedicament: Form
    {
        private AdministrareMedicamentFisier adminMedicamente;
        public FormMedicament()
        {
            InitializeComponent();
            adminMedicamente = new AdministrareMedicamentFisier("medicamente.txt");
            
        }

        private bool ValidareInput(out string mesaj)
        {
            mesaj = string.Empty;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                mesaj = "Denumirea este obligatorie!";
                return false;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                mesaj = "Selectați dacă medicamentul necesită rețetă.";
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidareInput(out string mesaj))
            {
                MessageBox.Show(mesaj, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string denumire = textBox1.Text.Trim();
                float pret = (float)numericUpDown1.Value;
                bool necesitaReteta = radioButton1.Checked;

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selectați o categorie pentru medicament.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Categorie categorieAleasa = (Categorie)comboBox1.SelectedItem;

                Medicament medicament = new Medicament(denumire, pret, necesitaReteta)
                {
                    categorie = categorieAleasa
                };
                adminMedicamente.AddMedicament(medicament);

                MessageBox.Show("Medicament adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                textBox1.Clear();
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
    }
        private void button3_click(object sender, EventArgs e)
        {
            // Creează o instanță a ferestrei FormClient
            Form1 form = new Form1();

            // Afișează fereastra
            form.Show();


            this.Hide();
        }

        private void comboBox(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Categorie));
        }
    }
}
