using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<Object> displayedItems = new ObservableCollection<object>();
        public ObservableCollection<Object> DisplayedItems
        {
            get { return displayedItems; }
            set { displayedItems = value; }
        }

        private List<Personne> personnes = new List<Personne>();
        public List<Personne> Personnes
        {
            get { return personnes; }
            set { personnes = value; }
        }
    }
}
