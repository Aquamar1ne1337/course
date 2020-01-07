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

namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для Librarium.xaml
    /// </summary>
    public partial class Librarium : UserControl
    {
        gameshopEntities gameshop = new gameshopEntities();
        public Librarium()
        {
            InitializeComponent();
            LilView.ItemsSource = gameshop.LibraryView(CurrentUser.Id).ToList();
        }
    }
}
