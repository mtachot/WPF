using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public class Personne : BindableBase
    {
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { SetProperty(value, ref prenom); }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { SetProperty(value, ref nom); }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { SetProperty(value, ref age); }
        }

        private bool isMarried;
        public bool IsMarried
        {
            get { return isMarried; }
            set { SetProperty(value, ref isMarried); }
        }

        private Address address;
        public Address Address
        {
            get { return address; }
            set { SetProperty(value, ref address); }
        }
    }
}
