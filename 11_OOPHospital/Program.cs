using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hastane uygulaması
             Hastane-> class
            -List<Hasta>Hastalar ->(IEntity interface)
            -hastane adı
            -List<Doktorlar>

            Doktor ->class
            -string adı,
            -soyadı,
            -Hastane Hastane
            -bolumu
            -List<Hasta> Hastaları
            -ReceteYaz(hasta)

            Hasta->class
            -adı-> ad ve soyad propertisi için abstract base class
            -soyadı
            -hastalığı
            -Hastane 
            //Main
            1 hasta nesne üretilecek bu hasta ilgili hastanenin doktorlarından birine onun hastalar kişisine kayıt olcak ve doktor da iligili hastaya recete yazacak

            https://codeshare.io/X8J98z
             */

            var hasta = new Patient("Arda", "Dinkçioğlu");
            var hastane = new Hospital("Devlet hastanesi");
            var doktor = new Doctor("ibrahim", "kaya");

            hastane.AddPatient(hasta);
            hastane.AddDoctor(doktor);
            doktor.AddPatient(hasta);

            doktor.Prescripiton(hasta);
            Console.Read();
        }
    }
}
