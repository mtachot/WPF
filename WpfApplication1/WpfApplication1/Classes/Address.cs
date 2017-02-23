using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public class Address
    {
        private int voie;
        public int Voie
        {
            get { return voie; }
            set { voie = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
    }
}
