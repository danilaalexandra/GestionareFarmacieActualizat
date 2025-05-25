using System;

namespace FarmacieLibrarie
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';


        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int DATA_NASTERII = 2;

        public string nume { get; set; }
        public string prenume { get; set; }
        public DateTime data_nasterii { get; set; }

        public Client()
        {
            nume = string.Empty;
            prenume = string.Empty;
            data_nasterii = DateTime.MinValue;
        }
        public Client(string _nume, string _prenume, DateTime _data_nasterii)
        {
            nume = _nume;
            prenume = _prenume;
            data_nasterii = _data_nasterii;
        }
        public string Info()
        {
            return $"Numele Clientului : {nume} {prenume}, data nasterii a clientului : {data_nasterii}";
        }
        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

     

            this.nume = dateFisier[NUME];
            this.prenume = dateFisier[PRENUME];
            this.data_nasterii = DateTime.ParseExact(dateFisier[DATA_NASTERII],"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectClientPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "),
                data_nasterii.ToString("dd/MM/yyyy"));

            return obiectClientPentruFisier;
        }
       

    }
}