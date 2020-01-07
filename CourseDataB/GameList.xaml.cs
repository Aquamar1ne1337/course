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
    /// Логика взаимодействия для GameList.xaml
    /// </summary>
    public partial class GameList : UserControl
    {
        gameshopEntities gameshop = new gameshopEntities();
       
        public GameList()
        {
            InitializeComponent();
            LilView.ItemsSource = gameshop.Игра.ToList();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(LilView.ItemsSource);
            view.Filter = UserFilter;
        }
        private bool UserFilter(object item)
        {
            return ((item as Игра).Название.IndexOf(filterTB.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
           
            var item = button.DataContext as Игра;
            int id = item.id_игры;
            ((MainWindow)Window.GetWindow(this)).NewWindow(new GamePage(id));
           
        }

        private void FilterTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(LilView.ItemsSource).Refresh();
        }
    }
}
