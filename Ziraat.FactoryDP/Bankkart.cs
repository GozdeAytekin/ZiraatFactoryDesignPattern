using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    public interface Bankkart
    {
        string KartAdi();
        int KartLimiti();
        bool SanalKartDurumu(); // true : açik false:kapali
        int NakitAvansLimiti();
    }
}
