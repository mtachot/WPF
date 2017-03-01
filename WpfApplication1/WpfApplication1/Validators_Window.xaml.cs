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
using System.Windows.Shapes;
using WpfApplication1.Classes.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Validators_Window.xaml
    /// </summary>
    public partial class Validators_Window : Window
    {
        public Validators_Window()
        {
            InitializeComponent();
            this.DataContext = new ViewModel_Validators();
        }
    }
}
