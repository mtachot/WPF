using System;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1.Classes.Converters
{
    public class AgeToBrushConverter : IValueConverter
    {
        private const int SEUIL_AGE = 18;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Si l'âge est inférieur au seuil défini, il sera coloré en rouge, sinon en vert
            SolidColorBrush redBrush = new SolidColorBrush(Color.FromArgb(255, 160, 0, 0));
            SolidColorBrush greenBrush = new SolidColorBrush(Color.FromArgb(255, 0, 120, 0));

            int res = 0;
            if (!String.IsNullOrEmpty(value.ToString()) && int.TryParse(value.ToString(), out res) && res < SEUIL_AGE)
                return redBrush;
            else
                return greenBrush;
        }

        // Ne sera jamais utilisé
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
