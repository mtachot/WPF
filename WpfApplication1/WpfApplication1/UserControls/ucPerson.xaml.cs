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

namespace WpfApplication1.UserControls
{
    /// <summary>
    /// Interaction logic for ucPerson.xaml
    /// </summary>
    public partial class ucPerson : UserControl
    {
        public ucPerson()
        {
            InitializeComponent();

            // Validation
            Validation.AddErrorHandler(this.txtAge, AgeValidationHandler);
        }

        #region Page Life Cycle

        private void ucPerson_Loaded(object sender, EventArgs e)
        {
        }

        #endregion

        #region Events

        #endregion

        #region Validation

        private void AgeValidationHandler(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                MessageBox.Show(e.Error.ErrorContent.ToString());
            }
        }

        #endregion
    }
}
