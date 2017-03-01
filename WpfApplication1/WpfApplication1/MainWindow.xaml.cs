using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Permet de fermer toutes les fenêtres lors dela fermeture de la fenêtre principale
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            
            InitializeComponent();
            DefiningEvents();
        }

        #region Page Life Cycle

        // Evénement appelé lorsque tous les éléments sont chargés et à leur place définitive
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtPrenom.Text = "Toto";

            // Style
            SolidColorBrush s = Application.Current.Resources["buttonOrange"] as SolidColorBrush;
            btnClose.Background = s;
        }

        // Evénement appelé lorsque la fenêtre se ferme (juste avant la fermeture)
        void MainWindow_Closed(object sender, EventArgs e)
        {
            // Killing remaining events (prevents memory leaks)
            Loaded -= MainWindow_Loaded;
            Closed -= MainWindow_Closed;

            btnHeaderedControls.Click -= btnHeaderedControls_Click;
            btnClose.Click -= btnClose_Click;
            btnAbonnement.Click -= btnAbonnement_Click;
            btnPanel.Click -= btnPanel_Click;
            btnUserControl.Click -= btnUserControl_Click;
            btnDynamicResources.Click -= btnDynamicResources_Click;
            btnTemplate.Click -= btnTemplate_Click;
            btnUsableUserControl.Click -= btnUsableUserControl_Click;
            btnDatagrid.Click -= btnDatagrid_Click;
            btnObservableCollection.Click -= btnObservableCollection_Click;
            btnViewModel.Click -= btnViewModel_Click;
            btnCommands.Click -= btnCommands_Click;
            btnValidators.Click -= btnValidators_Click;
        }

        #endregion

        #region Events

        private void DefiningEvents()
        {
            // Page
            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;

            // Components
            btnHeaderedControls.Click += btnHeaderedControls_Click;
            btnClose.Click += btnClose_Click;
            btnAbonnement.Click += btnAbonnement_Click;
            btnPanel.Click += btnPanel_Click;
            btnUserControl.Click += btnUserControl_Click;
            btnDynamicResources.Click += btnDynamicResources_Click;
            btnTemplate.Click += btnTemplate_Click;
            btnUsableUserControl.Click += btnUsableUserControl_Click;
            btnDatagrid.Click += btnDatagrid_Click;
            btnObservableCollection.Click += btnObservableCollection_Click;
            btnViewModel.Click += btnViewModel_Click;
            btnCommands.Click += btnCommands_Click;
            btnValidators.Click += btnValidators_Click;
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            new Commands_Window().Show();
        }
        private void btnViewModel_Click(object sender, RoutedEventArgs e)
        {
            new ViewModel_Window().Show();
        }
        private void btnObservableCollection_Click(object sender, RoutedEventArgs e)
        {
            new ObservableCollection_Window().Show();
        }
        private void btnDatagrid_Click(object sender, RoutedEventArgs e)
        {
            new DataGrid_Window().Show(); 
        }
        private void btnUsableUserControl_Click(object sender, RoutedEventArgs e)
        {
            new TestUsableUserControl_Window().Show();
        }
        private void btnTemplate_Click(object sender, RoutedEventArgs e)
        {
            new Template_Window().Show();
        }
        private void btnDynamicResources_Click(object sender, RoutedEventArgs e)
        {
            new DynamicStyle_Window().Show();
        }
        private void btnUserControl_Click(object sender, RoutedEventArgs e)
        {
            new TestUserControl_Window().Show();
        }
        private void btnAbonnement_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks !");
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnHeaderedControls_Click(object sender, RoutedEventArgs e)
        {
            new HeaderControls_Window().Show();
        }
        private void btnPanel_Click(object sender, RoutedEventArgs e)
        {
            new Panels_Window().Show();
        }
        private void btnValidators_Click(object sender, RoutedEventArgs e)
        {
            new Validators_Window().Show();
        }

        #endregion

        }
}
