using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public class Address : BindableBase
    {
        private int voie;
        public int Voie
        {
            get { return voie; }
            set { SetProperty(value, ref voie); }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { SetProperty(value, ref ville); }
        }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set { SetProperty(value, ref codePostal); }
        }
    }
}
