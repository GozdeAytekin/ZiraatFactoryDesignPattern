using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    public class Gold : Bankkart
    {

        public int KartLimiti()
        {
            return 15000;
        }

        public string KartAdi()
        {
            return "Gold";
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
