using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OpenCV_SimpleBlobDetectorTester.Views
{
    internal class TranslationViewSelector : DataTemplateSelector
    {
        public DataTemplate ScaleTranslation { get; set; }
        public DataTemplate ErodeTranslation { get; set; }
        public DataTemplate BrightnessTranslation { get; set; }
        public DataTemplate ColorSpaceTranslation { get; set; }
    }
}
