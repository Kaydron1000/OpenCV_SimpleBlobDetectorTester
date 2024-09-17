using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OpenCV_SimpleBlobDetectorTester.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BlobDectectionParameters _BlobParams;
        private ObservableCollection<FrameworkElement> _Objs;

        public BlobDectectionParameters BlobParams
        { 
            get => _BlobParams;
            set => SetField(ref _BlobParams, value);
        }

        public ObservableCollection<FrameworkElement> Objs 
        { 
            get => _Objs; 
            set => _Objs = value; 
        }
        public string ImgFilePath { get; set; }
        public Mat ImgMat { get; set; }
        public MainViewModel()
        {
            _BlobParams = new BlobDectectionParameters();
        }
        public MainViewModel(MainWindow Parent)
        {
            _BlobParams = new BlobDectectionParameters(this);
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
    }
}
