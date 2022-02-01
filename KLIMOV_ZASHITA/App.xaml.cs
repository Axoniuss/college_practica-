using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KLIMOV_ZASHITA
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.remont_tehnikiEntities Context
        { get; set; } = new Entities.remont_tehnikiEntities();
        private Entities.Client _currentcar = new Entities.Client();
        private Entities.Service currentService = new Entities.Service();
    }
}
