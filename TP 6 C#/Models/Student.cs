using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6_C_.Models
{
    public class Student
    {
        public int Id { get; set; }          // Clé primaire
        public string FirstName { get; set; } // Prénom
        public string LastName { get; set; }  // Nom
        public int Age { get; set; }          // Âge
    }
}
