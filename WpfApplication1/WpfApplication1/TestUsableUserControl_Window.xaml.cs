using System.Collections.Generic;
using System.Windows;
using WpfApplication1.Classes;
using WpfApplication1.Classes.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TestUsableUserControl_Window.xaml
    /// </summary>
    public partial class TestUsableUserControl_Window : Window
    {
        private ViewModel_Commands viewModel = new ViewModel_Commands();
        public TestUsableUserControl_Window()
        {
            InitializeComponent();


            // VM
            viewModel.DisplayedItems.Add(new Personne { Nom = "Dalton", Prenom = "Joe", Age = 12, Address = new Address { CodePostal = "BP102", Ville = "FarWest", Voie = 54 } });
            viewModel.DisplayedItems.Add(new Personne { Nom = "Dalton", Prenom = "Jack", Age = 14, Address = new Address { CodePostal = "BP102", Ville = "FarWest", Voie = 54 } });
            viewModel.DisplayedItems.Add(new Personne { Nom = "Dalton", Prenom = "William", Age = 16, Address = new Address { CodePostal = "BP102", Ville = "FarWest", Voie = 54 } });
            viewModel.DisplayedItems.Add(new Personne { Nom = "Dalton", Prenom = "Averell", Age = 18, Address = new Address { CodePostal = "BP102", Ville = "FarWest", Voie = 54 } });

            DataContext = viewModel;
            listboxPersonnes.ItemsSource = viewModel.DisplayedItems;
        }
    }
}
