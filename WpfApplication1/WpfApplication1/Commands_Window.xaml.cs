using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.Classes;
using WpfApplication1.Classes.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ObservableCollection_Window.xaml
    /// </summary>
    public partial class Commands_Window : Window
    {
        private ViewModel_Commands viewModel = new ViewModel_Commands();

        public Commands_Window()
        {
            InitializeComponent();

            // Events
            DefineEvents();

            // VM
            DataContext = viewModel;
            listPersonnes.ItemsSource = viewModel.DisplayedItems;
        }

        private void DefineEvents()
        {
            btnAddPerson.Click += btnAddPerson_Click;
            btnDelPerson.Click += btnDelPerson_Click;

            Closed += Commands_Window_Closed;
        }

        private void Commands_Window_Closed(object sender, EventArgs e)
        {
            // Unbinding events (prevents memory leaks)
            btnAddPerson.Click -= btnAddPerson_Click;
            btnDelPerson.Click -= btnDelPerson_Click;

            Closed -= Commands_Window_Closed;
        }

        private void btnDelPerson_Click(object sender, RoutedEventArgs e)
        {
            var personne = listPersonnes.DataContext;
            viewModel.DisplayedItems.Remove((Personne)personne);
        }
        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            viewModel.DisplayedItems.Add(new Personne { Prenom = txtPrenom.Text, Nom = txtNom.Text });
        }
    }
}
