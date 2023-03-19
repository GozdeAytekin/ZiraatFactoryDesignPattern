using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    public class Genc : Bankkart
    {
        public int KartLimiti()
        {
            return 1500;

        }

        public string KartAdi()
        {
            return "Genc";

        }

        public int NakitAvansLimiti()
        {
            return 500;

        }

        public bool SanalKartDurumu()
        {
            return true;
        }
    }
}
