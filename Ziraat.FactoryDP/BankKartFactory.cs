using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    internal class BankKartFactory
    {
        // bu sınıf uygun ürün nesnesini oluşturur ve döndürür
        //Bu kod, fabrika tasarım deseninin nasıl uygulanacağına dair bir fikir verir.
        //Open-Closeda uymaz.
        //kod tekrarını önler ve kodun daha okunaklı olmasını sağlar.
        public static Bankkart BankkartGetir(string kartAdi)
        {
            Bankkart bankkartDetayi = null;
            if (kartAdi == "Genc")
            {
                bankkartDetayi = new Genc();
            }
            else if (kartAdi == "Gold")
            {
                bankkartDetayi = new Gold();
            }
            else if (kartAdi == "Platinum")
            {
                bankkartDetayi = new Platinum();
            }
            return bankkartDetayi;
        }
    }
}
