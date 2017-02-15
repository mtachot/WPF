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
        }

        // Evénement appelé lorsque la fenêtre se ferme (juste avant la fermeture)
        void MainWindow_Closed(object sender, EventArgs e)
        {
            // Killing remaining events (prevents memory leaks)
            btnOK.Click -= btnOK_Click;
            btnCancel.Click -= btnCancel_Click;
            btnAbonnement.Click -= btnAbonnement_Click;
        }

        #endregion

        #region Events

        private void DefiningEvents()
        {
            // Page
            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;

            // Components
            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;
            btnAbonnement.Click += btnAbonnement_Click;
        }

        private void btnAbonnement_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks !");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            new HeaderControls_Window().Show();
        }

        #endregion
        
    }
}
