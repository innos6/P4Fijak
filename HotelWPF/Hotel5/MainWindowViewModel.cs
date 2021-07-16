using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel5
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel() {
            _IsRoomVisible = Visibility.Collapsed;
            _IsGuestVisible = Visibility.Collapsed;
            _IsReservationVisible = Visibility.Collapsed;
        }

        private Visibility _IsRoomVisible;
        public Visibility IsRoomVisible
        { 
            get { 
                return _IsRoomVisible; 
            } 
            set {
                _IsRoomVisible = (Visibility)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRoomVisible"));
            }
        }

        private Visibility _IsGuestVisible;
        public Visibility IsGuestVisible
        {
            get
            {
                return _IsGuestVisible;
            }
            set
            {
                _IsGuestVisible = (Visibility)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsGuestVisible"));
            }
        }

        private Visibility _IsReservationVisible;
        public Visibility IsReservationVisible
        {
            get
            {
                return _IsReservationVisible;
            }
            set
            {
                _IsReservationVisible = (Visibility)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsReservationVisible"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
