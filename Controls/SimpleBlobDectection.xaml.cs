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

namespace OpenCV_SimpleBlobDetectorTester
{
    /// <summary>
    /// Interaction logic for SimpleBlobDectection.xaml
    /// </summary>
    public partial class SimpleBlobDectection : UserControl
    {
        public SimpleBlobDectection()
        {
            InitializeComponent();
        }

        private void Bttn_ColorPicker_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            e = e;
        }
    }
}
