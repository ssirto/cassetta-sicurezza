using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassettasicurezza
{
    internal class cassetta
    {
        private List<OggettoSegreto> oggettiContenuti;

        private string produttore;
        private string codiceUnivoco;
        private string codiceSegreto;
        private bool vuota;

        public List<OggettoSegreto> OggettiContenuti
        {
            get {  return oggettiContenuti; }
        }

        public cassetta (string codiceUnivoco, string produttore, string codiceSegreto, bool vuota)
        {
            this.codiceUnivoco = codiceUnivoco;
            this.produttore = produttore;
            this.codiceSegreto = codiceSegreto;
            this.vuota = vuota;
        }

        public void Rimuovi (OggettoSegreto oggetto)
        {
            if (oggetto == null)
                return;
            OggettiContenuti.Remove(oggetto);
        }

        public void Aggiungi(OggettoSegreto oggetto)
        {
            oggettiContenuti.Add(oggetto);
        }

        public void ModificaPIN (string codiceVecchio, string codiceNuovo)
        {
            if (codiceNuovo == null || codiceNuovo == codiceVecchio || codiceVecchio != codiceSegreto)
                return;
            codiceSegreto = codiceNuovo;
        }
    }
}
