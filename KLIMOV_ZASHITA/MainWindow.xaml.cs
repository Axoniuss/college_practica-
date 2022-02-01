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

namespace KLIMOV_ZASHITA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            if (App.Context.User.Where(p => p.Login == log_txt.Text && p.Password == pass_txt.Password && p.RoleId == 1).Count() >= 1)
            {
                MessageBox.Show("Здравствуйте администратор!");
                window.admin adm = new window.admin(null);
                adm.Show();
                this.Close();
            }
            else if (App.Context.User.Where(p => p.Login == log_txt.Text && p.Password == pass_txt.Password && p.RoleId == 2).Count() >= 1)
            {
                MessageBox.Show("Здравствуйте пользователь!");
                window.User user = new window.User(null);
                user.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Проверка не прошла");
            }
        }

       

        private void reg123(object sender, RoutedEventArgs e)
        {
            window.reg reg = new window.reg();
            reg.Show();
            this.Close();
        }
    }
    }

