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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        private Entities.Client _currentcar = new Entities.Client();

        public admin(Entities.Client client)
        {
            InitializeComponent();
            if (client != null)
                _currentcar = client;
            DataContext = _currentcar;
         

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            window.add_user adm = new window.add_user();
            adm.Show();

        }

        private void UpdatateCar()
        {
            var _currentcar = Entities.remont_tehnikiEntities.GetContext().Client.ToList();
            _currentcar = _currentcar.Where(p => p.FirstName.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            dtclient.ItemsSource = _currentcar.OrderBy(p => p.LastName).ToList();


        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatateCar();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            var CarsForRemoving = dtclient.SelectedItems.Cast<Entities.Client>().ToList();


            if (MessageBox.Show($"Вы уверены, что хотите удалить данные о " + $"{CarsForRemoving.Count}?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Entities.remont_tehnikiEntities.GetContext().Client.RemoveRange(CarsForRemoving);
                    Entities.remont_tehnikiEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удаление завершено");
                    dtclient.ItemsSource = Entities.remont_tehnikiEntities.GetContext().Client.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_isvisible(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.remont_tehnikiEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dtclient.ItemsSource = Entities.remont_tehnikiEntities.GetContext().Client.ToList();
            }
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            window.redect edi = new window.redect((sender as Button).DataContext as Entities.Client);
            edi.Show();
            this.Close();
        }
    }
}

