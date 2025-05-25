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
            
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public Client[] GetClient(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;

               
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }

            return clienti;
        }

        public static Client[] CautareDupaNumeSauPrenume(Client[] clienti, string cuvantCautat)
        {
            return clienti
                .Where(c => c != null &&
                       (c.nume.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        c.prenume.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0))
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
        public bool StergeClient(string nume, string prenume)
        {
            int nrClienti;
            Client[] clienti = GetClient(out nrClienti);
            bool sters = false;

            using (StreamWriter sw = new StreamWriter("clienti.txt", false))
            {
                foreach (var c in clienti)
                {
                    if (c != null && (c.nume != nume || c.prenume != prenume))
                    {
                        sw.WriteLine(c.ConversieLaSir_PentruFisier());
                    }
                    else if (c != null && c.nume == nume && c.prenume == prenume)
                    {
                        sters = true;
                    }
                }
            }

            return sters;
        }

    }
}