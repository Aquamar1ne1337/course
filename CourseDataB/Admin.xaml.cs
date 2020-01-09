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
using System.IO;
namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Closebt_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gameshopEntities gameshop = new gameshopEntities();
                var ife = gameshop.Игра.ToList();
                foreach (Игра i in ife)
                {
                    if (i.Название == gamenametb.Text)
                    { MessageBox.Show("Такая игра уже есть."); return; }
                   
                }     
               
                    gameshop.GameAdd(gamenametb.Text, covertb.Text, desdb.Text, Convert.ToInt32(pricetb.Text), Convert.ToDateTime(datetb.Text));
                    String str = string.Format("Files");
                    string[] txtList = Directory.GetFiles(str, "*.txt");
                    foreach (string f in txtList)
                    {
                        File.Delete(f);
                    }
                gamenametb.Text = "";
                covertb.Text = "";
                desdb.Text = "";
                pricetb.Text = "";
                datetb.Text = "";
                
            }
            catch
            {
                MessageBox.Show("Вы что-то ввели не так!");
            }
        }
    }
}
