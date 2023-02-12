using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    public class Doctor : Base, IEntity
    {
        /*  Doktor ->class
            -string adı,
            -soyadı,
            -Hastane Hastane
            -bolumu
            -List<Hasta> Hastaları
            -ReceteYaz(hasta)*/


        public Hospital Hospital { get; set; }
        public string Polyclinic { get; set; }
        public List<Patient> Patients { get; set; }
        public Doctor(string name, string surname) : base(name, surname)
        {
            Patients = new List<Patient>();
        }
        public Doctor()
        {
            Patients = new List<Patient>();
        }
        public void Prescripiton(Patient patient)
        {
            System.Console.WriteLine($"{patient.Name} {patient.Surname} reçete yazıldı.\nYazan:{this.Name} {this.Surname}\nHastane : {this.Hospital.Name}");
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
            patient.Doctor = this;
        }
    }
}
