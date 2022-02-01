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
    /// Логика взаимодействия для add_user.xaml
    /// </summary>
    public partial class add_user : Window
    {
        private Entities.Client _currentcar = new Entities.Client();
        //private Entities.Service currentService = null;
        public add_user()
        {
            InitializeComponent();
            DataContext = _currentcar;


        }
        //public add_user(Entities.Service service)
        //{
        //    InitializeComponent();

        //    currentService = service;
        //    Title = "Редактировать услугу";
        //    tboxname.Text = currentService.Title;
        //    txtLast.Text = currentService.Cost;
        //    txtPatr.Text = currentService.Discount;
        //}
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

        private void user(object sender, DependencyPropertyChangedEventArgs e)
        {
            Entities.remont_tehnikiEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());

        }

        private void SaveClk(object sender, RoutedEventArgs e)
        {
 StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentcar.LastName))
                errors.AppendLine("Добавьте название");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentcar.ID == 0)
                Entities.remont_tehnikiEntities.GetContext().Client.Add(_currentcar);
            try
            {
                Entities.remont_tehnikiEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
