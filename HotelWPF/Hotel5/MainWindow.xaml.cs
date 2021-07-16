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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
            

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindowViewModel.IsGuestVisible = Visibility.Collapsed;
            mainWindowViewModel.IsReservationVisible = Visibility.Collapsed;
            mainWindowViewModel.IsRoomVisible = Visibility.Visible;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainWindowViewModel.IsReservationVisible = Visibility.Collapsed;
            mainWindowViewModel.IsRoomVisible = Visibility.Collapsed;
            mainWindowViewModel.IsGuestVisible = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mainWindowViewModel.IsRoomVisible = Visibility.Collapsed;
            mainWindowViewModel.IsGuestVisible = Visibility.Collapsed;
            mainWindowViewModel.IsReservationVisible = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
