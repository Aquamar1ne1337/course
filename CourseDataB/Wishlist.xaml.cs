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
using Notifications.Wpf;

namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для Wishlist.xaml
    /// </summary>
    public partial class Wishlist : UserControl
    {
        gameshopEntities gameshop = new gameshopEntities();
        public Wishlist()
        {
            InitializeComponent();
            LilView.ItemsSource = gameshop.WishlistView(CurrentUser.Id).ToList();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(LilView.ItemsSource);
           
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var item = button.DataContext as WishlistView_Result ;
            int id = item.id_игры;
            string name = item.Название;

            var notification = new NotificationManager();
            notification.Show(new NotificationContent
            {
                Title = "Удаление из списка желаемого.",
                Message = name + " успешно удалена из списка желаемого. ",
                Type = NotificationType.Information
            });
            gameshop.WishlistDelete(CurrentUser.Id, id);
            LilView.ItemsSource = gameshop.WishlistView(CurrentUser.Id).ToList();
        }
    }
}
