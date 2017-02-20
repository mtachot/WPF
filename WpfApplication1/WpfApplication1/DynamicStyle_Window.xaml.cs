using System;
using System.Windows;
using System.Windows.Media;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour DynamicStyle_Window.xaml
    /// </summary>
    public partial class DynamicStyle_Window : Window
    {
        public DynamicStyle_Window()
        {
            InitializeComponent();
            DefineEvents();
        }

        private void DefineEvents()
        {
            btnRed.Click += btnRed_Click;
            btnGreen.Click += btnGreen_Click;
            btnPink.Click += btnPink_Click;
        }

        #region Page Life Cycle

        void DynamicStyle_Window_Closed(object sender, EventArgs e)
        {
            // Unbinding events (prevents memory leaks)
            btnRed.Click -= btnRed_Click;
            btnGreen.Click -= btnGreen_Click;
            btnPink.Click -= btnPink_Click;
        }

        #endregion

        #region Events

        private void btnPink_Click(object sender, RoutedEventArgs e)
        {
            gridMain.Resources["backgroundWhite"] = new SolidColorBrush(Colors.Pink);
        }
        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            gridMain.Resources["backgroundWhite"] = new SolidColorBrush(Colors.Green);
        }
        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            gridMain.Resources["backgroundWhite"] = new SolidColorBrush(Colors.Red);
        }

        #endregion

    }
}
