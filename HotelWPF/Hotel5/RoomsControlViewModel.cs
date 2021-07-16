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
    public class RoomsControlViewModel : INotifyPropertyChanged
    {
        public RoomsControlViewModel()
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

        private List<Room> _rooms;
        public List<Room> rooms {
            get {
                return _rooms;
            }
            set {
                _rooms = (List<Room>)value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("rooms"));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
