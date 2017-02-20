using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1.UserControls
{
    /// <summary>
    /// Interaction logic for ucPerson.xaml
    /// </summary>
    public partial class ucUsablePerson : UserControl
    {
        public ucUsablePerson()
        {
            InitializeComponent();

            // Validation
            Validation.AddErrorHandler(this.txtAge, AgeValidationHandler);
        }

        #region Page Life Cycle

        private void ucUsablePerson_Loaded(object sender, EventArgs e)
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
