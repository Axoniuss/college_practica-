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
    /// Логика взаимодействия для redect.xaml
    /// </summary>
    public partial class redect : Window
    {
        private Entities.Client _currentcar = new Entities.Client();
        public redect()
        {
            InitializeComponent();
            DataContext = _currentcar;


        }
        public redect(Entities.Client client)
        {
            InitializeComponent();

            _currentcar = client;
            Title = "Редактировать услугу";
            tboxname.Text = _currentcar.FirstName;
            tboxcount.Text = _currentcar.LastName;
            tboxprice.Text = _currentcar.Patronymic;
            tboxdesc.Text = _currentcar.Email;
        }
        private void SaveClk(object sender, RoutedEventArgs e)
        {
            
            
            _currentcar.FirstName = tboxname.Text;
            _currentcar.LastName = tboxcount.Text;
            _currentcar.Patronymic = tboxprice.Text;
            _currentcar.Email = tboxdesc.Text;
            App.Context.SaveChanges();
            MessageBox.Show("Редактирование выполнено");
            window.admin admi = new window.admin(null);
            admi.Show();
            this.Close();
            
        }
    }
}
