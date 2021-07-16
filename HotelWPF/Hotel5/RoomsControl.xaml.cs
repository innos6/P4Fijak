using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Logika interakcji dla klasy RoomsControl.xaml
    /// </summary>
    public partial class RoomsControl : UserControl
    {
        RoomsControlViewModel roomsControlViewModel = new RoomsControlViewModel();
        HotelContext context = new HotelContext();

        public RoomsControl()
        {
            
            roomsControlViewModel.rooms = context.Rooms.ToList();
            InitializeComponent(); 
            DataContext = roomsControlViewModel;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in context.Rooms)
                {
                    context.Rooms.Remove(item);
                }
                context.SaveChanges();
                foreach (var item in roomsControlViewModel.rooms)
                {
                    context.Rooms.Add(item);
                }
                context.SaveChanges();
                //roomsControlViewModel.rooms = context.Rooms.ToList();
            }
            catch (Exception exeption)
            {

                MessageBox.Show(exeption.Message);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (roomsControlViewModel.EditingMode) { 
                roomsControlViewModel.EditingMode = false; 
            } else { 
                roomsControlViewModel.EditingMode = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            roomsControlViewModel.rooms = context.Rooms.ToList();
        }
    }
}
