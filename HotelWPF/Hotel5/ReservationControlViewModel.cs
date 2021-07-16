using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel5
{
    public class ReservationControlViewModel : INotifyPropertyChanged
    {
        public ReservationControlViewModel()
        {
            _EditingMode = false;
        }

        private bool _EditingMode;
        public bool EditingMode
        {
            get
            {
                return _EditingMode;
            }
            set
            {
                _EditingMode = (bool)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EditingMode"));
            }
        }


        private List<Reservation> _reservations;
        public List<Reservation> reservations
        {
            get
            {
                return _reservations;
            }
            set
            {
                _reservations = (List<Reservation>)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("reservations"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
