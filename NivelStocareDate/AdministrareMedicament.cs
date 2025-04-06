using FarmacieLibrarie;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareMedicament
    {
        private const int NR_MAX_MEDICAMENTE = 50;

        private Medicament[] medicamente;
        private int nrMedicamente;

        public AdministrareMedicament()
        {
            medicamente = new Medicament[NR_MAX_MEDICAMENTE];
            nrMedicamente = 0;
        }

        public void AddMedicament(Medicament medicament)
        {
            medicamente[nrMedicamente] = medicament;
            nrMedicamente++;
        }

        public Medicament[] GetMedicamente(out int nrMedicamente)
        {
            nrMedicamente = this.nrMedicamente;
            return medicamente;
        }

        public static Medicament[] cautareINdenumire(Medicament[] medicamente, string cuvantCautat)
        {
            return medicamente
                .Where(m => m != null && m.denumire.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToArray();
        }


    }
}