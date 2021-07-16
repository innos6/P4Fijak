using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel5
{
    public class GuestControlViewModel : INotifyPropertyChanged
    {
        public GuestControlViewModel()
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


        private List<Guest> _guests;
        public List<Guest> guests
        {
            get
            {
                return _guests;
            }
            set
            {
                _guests = (List<Guest>)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("rooms"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
