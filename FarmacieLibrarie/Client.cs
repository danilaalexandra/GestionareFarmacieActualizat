﻿using System;

namespace FarmacieLibrarie
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';


        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int DATA_NASTERII = 2;

        string nume { get; set; }
        string prenume { get; set; }
        DateTime data_nasterii { get; set; }

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

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()

            this.nume = dateFisier[NUME];
            this.prenume = dateFisier[PRENUME];
            this.data_nasterii = DateTime.Parse(dateFisier[DATA_NASTERII]);
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
        public static bool ValidareNume(string nume)
        {
            if (string.IsNullOrWhiteSpace(nume))
                return false;
            else return true;
        }
        public static bool ValidarePrenume(string prenume)
        {
            if (string.IsNullOrWhiteSpace(prenume))
                return false;
            else return true;
        }


    }
}