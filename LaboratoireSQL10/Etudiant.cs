using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoireSQL10
{
    internal class Etudiant
    {
        

        //déclaration des attributs
        public int EtudiantID { get; set; }
        public int ProgrammeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adresse { get; set; }

        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }

        public Etudiant(int etudiantID, int programmeID, string firstName, string lastName, string adresse, DateTime birthDay, string gender)
        {
            EtudiantID = etudiantID;
            ProgrammeID = programmeID;
            FirstName = firstName;
            LastName = lastName;
            Adresse = adresse;
            BirthDay = birthDay;
            Gender = gender;
        }

    }
}
