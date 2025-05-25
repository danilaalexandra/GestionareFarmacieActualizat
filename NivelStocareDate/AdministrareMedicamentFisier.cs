using FarmacieLibrarie;
using System.IO;
using System.Linq;
using System;


namespace NivelStocareDate
{
    public class AdministrareMedicamentFisier
    {
        private const int NR_MAX_MEDICAMENTE = 50;
        private string numeFisier;

        public AdministrareMedicamentFisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMedicament(Medicament medicament)
        {
            
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }

        public Medicament[] GetMedicamente(out int nrMedicamente)
        {
            Medicament[] medicamente = new Medicament[NR_MAX_MEDICAMENTE];

            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrMedicamente = 0;

              
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    medicamente[nrMedicamente++] = new Medicament(linieFisier);
                }
            }

            return medicamente;
        }
        public static Medicament[] cautareINdenumire(Medicament[] medicamente, string cuvantCautat)
        {
            return medicamente
                .Where(m => m != null && m.denumire.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0 )
                .ToArray();
        }

        

        public bool MedicamentExista(Medicament medicamentNou)
        {
            int nrMedicamente;
            Medicament[] medicamente = GetMedicamente(out nrMedicamente);

            foreach (var medicament in medicamente)
            {
                if (medicament != null &&
                    medicament.denumire.Equals(medicamentNou.denumire, StringComparison.OrdinalIgnoreCase) &&
                    medicament.pret == medicamentNou.pret &&
                    medicament.necesitaReteta == medicamentNou.necesitaReteta &&
                    medicament.categorie == medicamentNou.categorie)
                {
                    return true;
                }

            }

            return false;
        }

        public bool StergeMedicament(string denumire)
        {
            int nrMedicamente;
            Medicament[] medicamente = GetMedicamente(out nrMedicamente);
            bool sters = false;

            using (StreamWriter sw = new StreamWriter("medicamente.txt", false))
            {
                foreach (var m in medicamente)
                {
                    if (m != null && m.denumire != denumire)
                    {
                        sw.WriteLine(m.ConversieLaSir_PentruFisier());
                    }
                    else if (m != null && m.denumire == denumire)
                    {
                        sters = true;
                    }
                }
            }

            return sters;
        }


    }
}