using System;
using System.Globalization;



namespace FarmacieLibrarie

{
    public class Medicament
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int DENUMIRE = 0;
        private const int PRET = 1;
        private const int NECESITARETETA = 2;
        private const int CATEGORIE = 3;
        public string denumire { get; set; }
        public float pret { get; set; }
        public bool necesitaReteta { get; set; }
        public Categorie categorie { set; get; }




        public Medicament()
        {
            denumire = string.Empty;
            pret = 0;
            necesitaReteta = false;

        }

        public Medicament(string _denumire, float _pret, bool _necesitaReteta)
        {
            denumire = _denumire;
            pret = _pret;
            necesitaReteta = _necesitaReteta;

        }

        public string InfoMedicament()
        {
            return $"Denumirea medicamentului: {denumire}, Pretul medicamentului: {pret} , Reteta: {necesitaReteta} , Categorie : {categorie}";
        }

        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

    

            this.denumire = dateFisier[DENUMIRE];
            this.pret = float.Parse(dateFisier[PRET].Replace(',', '.'), CultureInfo.InvariantCulture);
            string retetaStr = dateFisier[NECESITARETETA].Trim().ToLower();
            this.necesitaReteta = (retetaStr == "da" || retetaStr == "true" || retetaStr == "1");
            this.categorie = (Categorie)Enum.Parse(typeof(Categorie), dateFisier[CATEGORIE]);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (denumire ?? " NECUNOSCUT "),
                pret.ToString(CultureInfo.InvariantCulture),
                (necesitaReteta ? "da" : "nu"),
                categorie.ToString());

            return obiectMedicamentPentruFisier;
        }

    }
}