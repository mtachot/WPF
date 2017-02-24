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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ObservableCollection_Window.xaml
    /// </summary>
    public partial class ObservableCollection_Window : Window
    {
        private ObservableCollection<Personne> displayedItems = new ObservableCollection<Personne>();
        public ObservableCollection<Personne> DisplayedItems
        {
            get { return displayedItems; }
            set { displayedItems = value; }
        }

        public ObservableCollection_Window()
        {
            InitializeComponent();
            // Events
            DefineEvents();
            listPersonnes.ItemsSource = displayedItems;
        }

        private void DefineEvents()
        {
            btnAddPerson.Click += btnAddPerson_Click;
            btnDelPerson.Click += btnDelPerson_Click;

            Closed += ObservableCollection_Window_Closed;
        }

        private void ObservableCollection_Window_Closed(object sender, EventArgs e)
        {
            // Unbinding events (prevents memory leaks)
            btnAddPerson.Click -= btnAddPerson_Click;
            btnDelPerson.Click -= btnDelPerson_Click;

            Closed -= ObservableCollection_Window_Closed;
        }

        private void btnDelPerson_Click(object sender, RoutedEventArgs e)
        {
            var person = listPersonnes.DataContext;
            displayedItems.Remove((Personne)person);
        }
        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            displayedItems.Add(new Personne { Prenom = txtPrenom.Text, Nom = txtNom.Text });
        }
    }
}
