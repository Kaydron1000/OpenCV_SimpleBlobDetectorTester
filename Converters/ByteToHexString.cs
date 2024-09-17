using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OpenCV_SimpleBlobDetectorTester.Converters
{
    internal class ByteToHexString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is byte)
            {
                return ((byte)value).ToString("X2");
            }
            return "00";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return byte.Parse((string)value, NumberStyles.HexNumber);
            }
            return 0;
        }
    }
}
