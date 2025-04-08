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

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nume";
            dataGridView1.Columns[1].Name = "Prenume";
            dataGridView1.Columns[2].Name = "Data Nașterii";
            
            IncarcaClientiDinFisier();

        }

       
        public void AdaugaClientInTabel(Client client)
        {
            dataGridView1.Rows.Add(client.nume, client.prenume, client.data_nasterii.ToShortDateString());
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
                    dataGridView1.Rows.Add(client.nume, client.prenume, client.data_nasterii.ToString("dd/MM/yyyy"));
                }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
           
            FormClient formClient = new FormClient();

            
            formClient.Show();


            this.Hide();
        }

        private void button2_click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

       
    }
}
