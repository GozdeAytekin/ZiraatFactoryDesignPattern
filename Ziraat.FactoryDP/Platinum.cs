using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    public class Platinum : Bankkart
    {
        public string KartAdi()
        {
            return "Platinum";
        }

        public int KartLimiti()
        {
            return 50000;
        }

        public int NakitAvansLimiti()
        {
            return 5000;
        }

        public bool SanalKartDurumu()
        {
            return false;
        }
    }
}
