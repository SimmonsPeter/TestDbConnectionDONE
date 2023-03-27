using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoireSQL10
{
    internal class Programme
    {
        //définition des attributs

        private int programmeID;
        private string programmeName;

        public Programme(int programmeID, string programmeName)
        {
            ProgrammeID = programmeID;
            ProgrammeName = programmeName;
        }

        public int ProgrammeID { get => programmeID; set => programmeID = value; }
        public string ProgrammeName { get => programmeName; set => programmeName = value; }
        //definition des méthode d'accès , les propriétés (getter, setter)

    }
}
