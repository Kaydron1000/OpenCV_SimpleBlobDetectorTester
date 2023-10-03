using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BlobDectectionParameters _BlobParams;

        public BlobDectectionParameters BlobParams
        { 
            get => _BlobParams;
            set => SetField(ref _BlobParams, value);
        }
        public string ImgFilePath { get; set; }
        public Mat ImgMat { get; set; }
        public MainViewModel()
        {
            _BlobParams = new BlobDectectionParameters(this);
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
