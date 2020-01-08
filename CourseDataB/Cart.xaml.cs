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
using Word = Microsoft.Office.Interop.Word;

namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : UserControl
    {
        private int Count { get; set; }
        private readonly string TemplateFileName = @"c:\Users\Герман\check.docx";
        gameshopEntities gameshop = new gameshopEntities();
        public Cart()
        {

            InitializeComponent();
            LilView.ItemsSource = gameshop.CartView(CurrentUser.Id).ToList();
            SumTB.Text = SumCount().ToString();
            if (CurrentUser.GamesCount() % 5 == 0)
            {
                var notification = new NotificationManager();
                notification.Show(new NotificationContent
                {
                    Title = "Скидка.",
                    Message = "На следующуюю покупку действует скидка в 5 рублей.",
                    Type = NotificationType.Information
                });
            }
            Checking();

        }
        private void Checking()
        {
            if (SumCount() == 0)
            {
                withbt.IsEnabled = false;
                withoutbt.IsEnabled = false;
            }
        }

        private int SumCount()
        {
            var menu = gameshop.Корзина.Where(u => u.id_пользователя == CurrentUser.Id && u.Статус == "В ожидании");
            int sum = 0;
            foreach (Корзина i in menu)
            {
                sum += i.Цена;
            }      
            if (sum == 0)
            {
                return 0;
            }
            else if (CurrentUser.GamesCount() % 5 == 0)
            {
                return sum - 5; 
            }
            else return sum;
        }


        private void Buy()
        {
           
            var notification = new NotificationManager();
            notification.Show(new NotificationContent
            {
                Title = "Покупка.",
                Message = CheckContent() + " успешно куплена/ы. ",
                Type = NotificationType.Information
            });
            var menu = gameshop.Корзина.Where(u => u.id_пользователя == CurrentUser.Id && u.Статус == "В ожидании").ToList();
            foreach (Корзина i in menu)
            {
                gameshop.LibraryAdd(i.id_игры, CurrentUser.Id, i.Цена);
            }
        }

        private string CheckContent()
        {
            var menu = gameshop.WaitView(CurrentUser.Id);
            string content = string.Empty;
            foreach (var i in menu)
            {
                content += i.Название + ", ";
            }
            int lenght = content.Length - 2;
            content = content.Remove(lenght);
            return content;
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var item = button.DataContext as CartView_Result;
            int id = item.id_игры;
            string name = item.Название;

            var notification = new NotificationManager();
            notification.Show(new NotificationContent
            {
                Title = "Удаление из корзины.",
                Message = name + " успешно удалена из корзины. ",
                Type = NotificationType.Information
            });
            gameshop.CartDelete(CurrentUser.Id, id);
            LilView.ItemsSource = gameshop.CartView(CurrentUser.Id).ToList();

            SumTB.Text = SumCount().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{games}", CheckContent(), wordDocument);
                ReplaceWordStub("{sum}", SumCount().ToString(), wordDocument);
                ReplaceWordStub("{date}", DateTime.Now.ToString(), wordDocument);

                // wordDocument.SaveAs2(@"c:\Users\Герман\check.docx");
                wordApp.Visible = true;
                //wordDocument.Close();  
            }
            catch { MessageBox.Show("Файл уже существует!"); }
            Buy();
            LilView.ItemsSource = gameshop.CartView(CurrentUser.Id).ToList();
            SumTB.Text = SumCount().ToString();
            Checking();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocement)
        {
            var range = wordDocement.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Buy();
            LilView.ItemsSource = gameshop.CartView(CurrentUser.Id).ToList();
            SumTB.Text = SumCount().ToString();
            Checking();
        }
    }
}

