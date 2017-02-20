using System.Collections.Generic;
using System.Windows;
using WpfApplication1.Classes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DataGrid_Window.xaml
    /// </summary>
    public partial class DataGrid_Window : Window
    {
        private List<Personne> personnes = new List<Personne>
            {
                new Personne{Nom="Dalton", Prenom="Joe", Age=12},
                new Personne{Nom="Dalton", Prenom="Jack", Age=14},
                new Personne{Nom="Dalton", Prenom="William", Age=16},
                new Personne{Nom="Dalton", Prenom="Averell", Age=18}
            };
        public DataGrid_Window()
        {
            InitializeComponent();
            gridPersonne.ItemsSource = personnes;
        }
    }
}
