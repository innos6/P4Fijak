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
    /// Logika interakcji dla klasy ReservationsControl.xaml
    /// </summary>
    public partial class ReservationsControl : UserControl
    {
        ReservationControlViewModel reservationControlViewModel = new ReservationControlViewModel();
        HotelContext context = new HotelContext();
        public ReservationsControl()
        {
            reservationControlViewModel.reservations = context.Reservations.ToList();
            InitializeComponent();
            DataContext = reservationControlViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in context.Reservations)
                {
                    context.Reservations.Remove(item);
                }
                context.SaveChanges();
                foreach (var item in reservationControlViewModel.reservations)
                {
                    context.Reservations.Add(item);
                }
                context.SaveChanges();
                reservationControlViewModel.reservations = context.Reservations.ToList();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (reservationControlViewModel.EditingMode)
            {
                reservationControlViewModel.EditingMode = false;
            }
            else
            {
                reservationControlViewModel.EditingMode = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            reservationControlViewModel.reservations = context.Reservations.ToList();
        }
    }
}
