using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User base abstract class
            /*
             ad,soyad,
            Courses
            abstract JoinCourse(Course course)

            Kurs classı
            ad,toplam_saat,haftalık saati,baslangıc_tarihi,bitiş_tarihi(kendi hesaplasın)
            Encapculation ad<3 hata versin
            baslangıc_tarihi<Datetime.Now
            Ogrecileri
            Eğitmeni

            Eğitmen class:User
            

            ÖĞrenciler:User

            Main
            2 eğitmen
            3 öğrenci 
            3 Kurs oluşturulacak

            1 eğitmen-2 kurs
            
             */

            Course erp = new Course("erp-205", 400, 40, DateTime.Now);
            Course yazılım = new Course("yazılım-201", 600, 40, DateTime.Now.AddDays(1));
            Course sql = new Course("sql-204", 300, 60, DateTime.Now);

            Educator ibrahim = new Educator("ibrahim", "kaya");
            Educator samil = new Educator("Şamil", "hoca");

            Student furkan = new Student("furkan", "ertantu");
            Student mehmet = new Student("mehmet", "bakmaz");

            ibrahim.JoinCourse(erp);
            ibrahim.JoinCourse(yazılım);
            samil.JoinCourse(sql);

            furkan.JoinCourse(erp);
            furkan.JoinCourse(sql);
            mehmet.JoinCourse(erp);


            Console.WriteLine("İbrahim Hocanın verdiği Kurslar");
            ibrahim.Courses.ForEach(course => Console.WriteLine($"{course.Name} {course.Educator.Name} {course.Educator.Surname} {course.EndDate}"));


            Console.WriteLine("furkan ın katılmış olduğu kurslar");
            furkan.Courses.ForEach(course => Console.WriteLine($"{course.Name} {course.Educator.Name} {course.Educator.Surname} {course.EndDate}"));

            Console.WriteLine("erp ");
            Console.Read();
        }
    }
}
