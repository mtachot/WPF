using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public class Personne : INotifyPropertyChanged
    {
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; OnPropertyChanged(); }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; OnPropertyChanged(); }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(); }
        }

        private bool isMarried;
        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; OnPropertyChanged(); }
        }

        private Address address;
        public Address Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
