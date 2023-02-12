using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOPEft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nesneler
             bir kişi başka bir kişi havale yapsın
            1 ziraat_hesabı
            1 x müsteri

            1 halkbank_hesabı
            1 y müsteri

            customer->class
            ad,soyad
            List bankaHesabıları
            eftSend(gonderici_hesap,alıcı hesap)

            bankaHesabı->class
            customer
            Banka Adı
            ıban
            bakiyesi
            BakiyeEkle(decimal bakiye)
            //cmd
            eft
            Gönderen kişinin
            ad:
            soyad:
            ıbanı:
            bankası:
            bakiye:

            Alan kisinin
            ad:
            soyad:
            ıbanı
            bankası:
             */

            var ziraat_hesab = new BankAccount("ziraat", "Tr1", 10000);
            Customer sender = new Customer("ibrahim", "kaya", ziraat_hesab);

            ziraat_hesab.AddBalance(5000);
            var teb_hesabı = new BankAccount("teb", "Tr2", 10000);
            Customer receiver = new Customer("İlker", "şenel", teb_hesabı);

            sender.EftSend(ziraat_hesab,teb_hesabı,60);
            Console.Read();
        }
    }
}
