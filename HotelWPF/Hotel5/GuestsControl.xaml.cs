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

namespace Hotel5
{
    /// <summary>
    /// Logika interakcji dla klasy GuestsControl.xaml
    /// </summary>
    public partial class GuestsControl : UserControl
    {
        GuestControlViewModel guestControlViewModel = new GuestControlViewModel();
        HotelContext context = new HotelContext();
        public GuestsControl()
        {
            guestControlViewModel.guests = context.Guests.ToList();
            InitializeComponent();
            DataContext = guestControlViewModel;
        }

        public delegate void OnGuestControlClosedEventHandler(Object o, EventArgs e);
        public event OnGuestControlClosedEventHandler OnGuestControlClosed;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in context.Guests)
                {
                    context.Guests.Remove(item);
                }
                context.SaveChanges();
                foreach (var item in guestControlViewModel.guests)
                {
                    context.Guests.Add(item);
                }
                context.SaveChanges();
                guestControlViewModel.guests = context.Guests.ToList();
            }
            catch (Exception exeption)
            {

                MessageBox.Show(exeption.Message);
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (guestControlViewModel.EditingMode)
            {
                guestControlViewModel.EditingMode = false;
            }
            else
            {
                guestControlViewModel.EditingMode = true;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            guestControlViewModel.guests = context.Guests.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OnGuestControlClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
