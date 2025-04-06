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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creează o instanță a ferestrei FormClient
            FormClient formClient = new FormClient();

            // Afișează fereastra
            formClient.Show();


            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Creează o instanță a ferestrei FormClient
            FormMedicament formMedicament = new FormMedicament();

            // Afișează fereastra
            formMedicament.Show();


            this.Hide();
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void FarmacieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Apăsare Escape
            {
                Application.Exit();
            }
        }
    }
}


