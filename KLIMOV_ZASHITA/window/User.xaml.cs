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
using System.Windows.Shapes;

namespace KLIMOV_ZASHITA.window
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        private Entities.Service currentService = null;
        public User(Entities.Service service)
        {
            InitializeComponent();
            if (service != null)
                currentService = service;
            DataContext = currentService;
            dtclient.ItemsSource = App.Context.Service.ToList();
        }

        private void Page_isvisible(object sender, DependencyPropertyChangedEventArgs e)
        {
         
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            //window.add_user edi = new window.add_user((sender as Button).DataContext as Entities.Service);
            //edi.Show();
            //this.Close();
        }
    }
}
