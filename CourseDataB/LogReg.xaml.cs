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
using System.Text.RegularExpressions;

namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для LogReg.xaml
    /// </summary>
    public partial class LogReg : Window
    {
        Regex regexpas = new Regex("^[a-zA-Z0-9]{8,16}$");
        Regex regexlog = new Regex("^[a-zA-Z0-9]{4,16}$");
        public LogReg()
        {
            InitializeComponent();   
        }

        private void Pasenterpb_PasswordChanged(object sender, RoutedEventArgs e)
        {

            SignInChecking();
        }

        private void Logentertb_TextChanged(object sender, TextChangedEventArgs e)
        {
            SignInChecking();
        }

        private void Logregtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            SignUpChecking();
        }

        private void Pasregpb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SignUpChecking();
        }

        private void Pasregpbconfirm_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SignUpChecking();
        }

        private void SignInChecking()
        {

            if (regexlog.IsMatch(logentertb.Text) && regexpas.IsMatch(pasenterpb.Password.ToString()))
            {
                enterbutton.IsEnabled = true;
            }
            else enterbutton.IsEnabled = false;

        }

        private void SignUpChecking()
        {
            if (regexlog.IsMatch(logregtb.Text) && regexpas.IsMatch(pasregpb.Password.ToString()) && pasregpb.Password == pasregpbconfirm.Password)
            {
                regbutton.IsEnabled = true;
            }
            else regbutton.IsEnabled = false;
        }

        private void Regbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gameshopEntities gameshop = new gameshopEntities();
                gameshop.SignUp(logregtb.Text, pasregpb.Password.ToString());
                pasregpb.Password = "";
                logregtb.Text = "";
                pasregpbconfirm.Password = "";
            }
            catch { MessageBox.Show("Пользователь с таким именем уже сущетсвует!"); }
            
        }

        private void Enterbutton_Click(object sender, RoutedEventArgs e)
        {
            using (gameshopEntities gameshop = new gameshopEntities())
            {
                var user = gameshop.Пользователь.FirstOrDefault(u => u.Логин == logentertb.Text);
                {
                    if (user != null)
                    {
                        if(user.Пароль == pasenterpb.Password.ToString())
                        {
                            CurrentUser.Login = logentertb.Text;
                            CurrentUser.Id = user.id_пользователя;
                            MainWindow main = new MainWindow();
                            main.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует.");
                    }
                }
               
            }
        }
    }
}
