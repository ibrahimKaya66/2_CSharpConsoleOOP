using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    public class Hospital : IEntity
    {
        /*
            Hastane-> class
            -List<Hasta>Hastalar ->(IEntity interface)
            -hastane adı
            -List<Doktorlar>
         */

        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Hospital(string name)
        {
            Name = name;
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
            patient.Hospital = this;
        }
        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            doctor.Hospital = this;
        }
    }
}
