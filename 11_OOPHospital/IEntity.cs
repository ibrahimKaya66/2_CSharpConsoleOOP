using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPHospital
{
    internal interface IEntity
    {
        List<Patient> Patients { get; set; }//Patient:Hasta
    }
}
