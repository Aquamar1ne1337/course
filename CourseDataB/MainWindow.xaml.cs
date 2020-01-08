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
using System.IO;
using Stimulsoft.Report;
using Notifications.Wpf;

namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HelloTB.Text = "Здравствуйте, " + CurrentUser.Login;
            String str = string.Format("Files/{0}.txt", CurrentUser.Login.ToString());
            var notification = new NotificationManager();
            if (File.Exists(str))
            {

                notification.Show(new NotificationContent
                {
                    Title = "Новинок нет :C",
                    Message = "Вы узнали про все новинки!",
                    Type = NotificationType.Information
                });
            }
            else
            {
                using (FileStream fstream = new FileStream(str, FileMode.Create))
                {
                    fstream.Close();
                }
                gameshopEntities gameshop = new gameshopEntities();
                var menu = gameshop.Novelty;
                string content = string.Empty;
                foreach (var i in menu)
                {
                    content += i.Название + ", ";
                }

                notification.Show(new NotificationContent
                {
                    Title = "Новинки!.",
                    Message = "Доступны новые игры! " + content.Remove(content.Length - 2, 2) + " прямо сейчас в магазине! ",
                    Type = NotificationType.Information
                });
            }
           
            
        }

        public void NewWindow(UIElement obj)
        {
            Framegrid.Children.Clear();
            Framegrid.Children.Add(obj);
        }

        private void CloseBt_Click(object sender, RoutedEventArgs e)
        {
         
            Application.Current.Shutdown();
            
        }

        private void LilView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = LilView.SelectedIndex;
            switch (item)
            {
                case 0:
                    {
                        NewWindow(new GameList());
                        break;
                    }
                case 1:
                    {
                        NewWindow(new Cart());
                        break;
                    }
                case 2:
                    {
                        NewWindow(new Wishlist());
                        break;
                    }
                case 3:
                    {
                        NewWindow(new Librarium());
                        break;
                    }
                default:
                    {
                        MessageBox.Show(item.ToString());
                        break;
                    }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewWindow(new Help());
        }

        private void Reportbt_Click(object sender, RoutedEventArgs e)
        {
            StiReport report = new StiReport();
            report.Load("Report.mrt");
            report.ShowWithWpf();
        }
    }
}
