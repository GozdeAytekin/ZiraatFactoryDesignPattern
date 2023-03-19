using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziraat.FactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bankkart kartDetay = null;
            //string operation = "Bankkart Kart Tipleri:\n" +
            //                    "1.Genc \n" +
            //                    "2.Gold \n" +
            //                    "3.Platinum";
            //Console.WriteLine(operation);
            //string kartAdi = "Genc";
            //if (kartAdi == "Genc")
            //{
            //    kartDetay = new Genc();
            //}
            //else if (kartAdi == "Gold")
            //{
            //    kartDetay = new Gold();
            //}
            //else if (kartAdi == "Platinum")
            //{
            //    kartDetay = new Platinum();
            //}
            //if (kartDetay != null)
            //{
            //    Console.WriteLine("Kart Adı : " + kartDetay.KartAdi());
            //    Console.WriteLine("Kart Limiti : " + kartDetay.KartLimiti());
            //    Console.WriteLine("Sanal Kart Var Mı :" + kartDetay.SanalKartDurumu());
            //    Console.WriteLine("Nakit Avans Limiti :" + kartDetay.NakitAvansLimiti());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}

            /*
             * Yeni bir Kredi kartı eklenirse,Main metoduna ekstra bir if-else koşulu eklememiz gerekecek.
             * Bu geliştirmek sürecinde ve test sürecinde yüksek bir maliyete sebep olur.
             * 
             * 
             */
            Bankkart kartDetayi = BankKartFactory.BankkartGetir("Platinum");

            if (kartDetayi != null)
            {
                Console.WriteLine("Kart Adi : " + kartDetayi.KartAdi());
                Console.WriteLine("Kart Limiti : " + kartDetayi.KartLimiti());
                Console.WriteLine("Sanal Kart Durumu :" + kartDetayi.SanalKartDurumu());
                Console.WriteLine("Nakit Avans Limiti:" + kartDetayi.NakitAvansLimiti());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}
