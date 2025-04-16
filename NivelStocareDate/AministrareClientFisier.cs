using FarmacieLibrarie;
using System.IO;
using System.Linq;
using System;

namespace NivelStocareDate
{
    public class AdministrareClientFisier
    {
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;

        public AdministrareClientFisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public Client[] GetClient(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }

            return clienti;
        }
        public static Client[] cautareINnume(Client[] clienti, string cuvantCautat)
        {
            return clienti
                .Where(m => m != null && m.nume.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToArray();
        }

        public bool ClientExista(Client clientNou)
        {
            int nrClienti;
            Client[] clienti = GetClient(out nrClienti);

            foreach (var client in clienti)
            {
                if (client != null &&
                    client.nume.Equals(clientNou.nume, StringComparison.OrdinalIgnoreCase) &&
                    client.prenume.Equals(clientNou.prenume, StringComparison.OrdinalIgnoreCase) &&
                    client.data_nasterii.Date == clientNou.data_nasterii.Date)
                {
                    return true;
                }
            }

            return false;
        }
    }
}