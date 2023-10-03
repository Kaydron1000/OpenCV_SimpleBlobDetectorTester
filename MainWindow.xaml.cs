using Microsoft.Win32;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private MainViewModel _MainView;
        
        public MainViewModel MainView 
        {
            get => _MainView; 
            set => SetField(ref _MainView, value);
        }

        public MainWindow()
        {
            _MainView = new MainViewModel(this);
            DataContext = MainView;
            InitializeComponent();
        }

        protected void OnPropertyChanged(string propertyName)
                => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private void Bttn_BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                _MainView.ImgFilePath = openFileDialog.FileName;

                _MainView.ImgMat = Cv2.ImRead(_MainView.ImgFilePath);
                Image img = new Image
                {
                    Width = _MainView.ImgMat.Width,
                    Height = _MainView.ImgMat.Height,
                    Name = "BODYIMG",
                    Source = new BitmapImage(new Uri(_MainView.ImgFilePath, UriKind.Absolute))
                };

                Canvas_Img.Children.Add(img);
                Canvas.SetTop(img, 0);
                Canvas.SetLeft(img, 0);

            }
            
        }
    }
}
