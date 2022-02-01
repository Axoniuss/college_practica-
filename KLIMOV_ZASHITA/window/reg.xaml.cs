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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public reg()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var Client = new Entities.Client
            {
                FirstName = txtLast.Text,
                LastName = textBox.Text,
                Patronymic = txtPatr.Text,
                Email = textBox_Copy3.Text,
                Phone = textBox_Copy4.Text,
                GenderCode = textBox_Copy6.Text
            };
            var usir = new Entities.User
            {
                Login = txtLogin.Text,
                Password = txtPass.Text

            };
            App.Context.User.Add(usir);
            App.Context.Client.Add(Client);
            App.Context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно");
            MainWindow auth = new MainWindow();
            auth.Show();
            this.Close();
        }
    }
}
