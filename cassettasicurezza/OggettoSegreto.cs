using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassettasicurezza
{
    internal class OggettoSegreto
    {
        private string valore;
        private string identificativo;
        private double valoreAssicurato;
        public OggettoSegreto(string identificativo, string valore)
        {
            this.identificativo = identificativo;
            this.valore = valore;
        }
    }
}
