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
    /// Логика взаимодействия для GamePage.xaml
    /// </summary>
    public partial class GamePage : UserControl
    {
        private static int Id { get; set; }
        private static int Price { get; set; }
        private static string Gamename { get; set; }
        public GamePage(int id)
        {
            InitializeComponent();
            Id = id;
            gameshopEntities entities = new gameshopEntities();

            WishCheck();
            int platid = entities.Игра.Where(w => w.id_игры == id).FirstOrDefault().id_платформы;
            string filmphoto = entities.Игра.Where(w => w.id_игры == id).FirstOrDefault().Обложка;
            string description = entities.Игра.Where(w => w.id_игры == id).FirstOrDefault().Описание;
            string name = entities.Игра.Where(w => w.id_игры == id).FirstOrDefault().Название;
            string date = entities.Игра.Where(w => w.id_игры == id).FirstOrDefault().Дата_выхода.ToString("dd/MM/yyyy");
            string plafromname = entities.Платформа.Where(w => w.id_платформы == platid).FirstOrDefault().Название;
            string price = (entities.Игра.Where(w => w.id_игры == id).FirstOrDefault()).Цена.ToString();
            Price = Convert.ToInt32(price);
            Gamename = name;
            var uri = new Uri(filmphoto, UriKind.RelativeOrAbsolute);
            ImageDoge.Source = new BitmapImage(uri);     
            

            DescriptionTB.Text = description;
            GameNameTB.Text += name;
            DateTB.Text += date;
            PlatformTB.Text += plafromname;
            PriceTB.Text += price + " $";

        }

        private void BuyBT_Click(object sender, RoutedEventArgs e)
        {
            gameshopEntities gameshop = new gameshopEntities();
            gameshop.CartAdd(Id, CurrentUser.Id, Price);
            BuyBT.IsEnabled = false;
            WishlistBT.IsEnabled = false;
            Notification("корзину!");
        }

        private void WishlistBT_Click(object sender, RoutedEventArgs e)
        {
           
                gameshopEntities gameshop = new gameshopEntities();
                gameshop.WishlistAdd(Id, CurrentUser.Id, Price);
                WishlistBT.IsEnabled = false;
                Notification("список желаемого!");

        }

        public void Notification(string type)
        {
            var notification = new NotificationManager();
            notification.Show(new NotificationContent
            {
                Title = "Игра добавлена в " + type,
                Message = Gamename + " успешно добавлена в " + type,
                Type = NotificationType.Information
            });
        }

        public void WishCheck()
        {
            
            using (gameshopEntities gameshop = new gameshopEntities())
            {
                var user = gameshop.Корзина.FirstOrDefault(w => w.id_игры == Id && w.id_пользователя == CurrentUser.Id);
                {
                    if (user != null)
                    {
                        if (user.Статус == "В списке желаемого")
                        {
                            WishlistBT.IsEnabled = false;
                        }
                        else if (user.Статус == "В ожидании" || user.Статус == "Куплена")
                        {
                            WishlistBT.IsEnabled = false;
                            BuyBT.IsEnabled = false;
                        }
                    }
                    else
                    {
                        BuyBT.IsEnabled = true;
                        WishlistBT.IsEnabled = true;
                    }
                }

            }
        }
    }
}
