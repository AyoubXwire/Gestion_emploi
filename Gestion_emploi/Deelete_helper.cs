using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_emploi
{
    class Deelete_helper
    {
        public int id { get; set; }
        public string chaine{ get; set; }

        public Deelete_helper(int id , string chaine)
        {
            this.id = id;
            this.chaine = chaine;
        }
}
}
