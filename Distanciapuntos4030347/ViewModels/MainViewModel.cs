using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Distanciapuntos4030347.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _result;
        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }

        private string _x1;
        public string X1
        {
            get { return _x1; }
            set
            {
                _x1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(X1)));
            }
        }

        private string _y1;
        public string Y1
        {
            get { return _y1; }
            set
            {
                _y1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Y1)));
            }
        }

        private string _x2;
        public string X2
        {
            get { return _x2; }
            set
            {
                _x2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(X2)));
            }
        }

        private string _y2;
        public string Y2
        {
            get { return _y2; }
            set
            {
                _y2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Y2)));
            }
        }

        public ICommand CalculateDistanceCommand => new Command(() =>
        {
            if (double.TryParse(X1, out double x1) && double.TryParse(Y1, out double y1) &&
                double.TryParse(X2, out double x2) && double.TryParse(Y2, out double y2))
            {
                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Result = $"Distancia: {distance:F2}";
                Application.Current.MainPage.Navigation.PushAsync(new ResultPage(distance));
            }
            else
            {
                Result = "Porfavor ingrese las coordenadas";
            }
        });

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
