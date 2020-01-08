using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDataB
{
  
    static class CurrentUser
    {
        public static string Login { get; set; }
        public static int Id { get; set; }


        public static int GamesCount()
        {
            gameshopEntities gameshop = new gameshopEntities();
            var menu = gameshop.Корзина.Where(u => u.id_пользователя == CurrentUser.Id && u.Статус == "Куплена");
            int count = 0;
            foreach (Корзина i in menu)
            {
                count++;
            }
            if (count == 0)
            {
                return count + 1;
            }
            else return count;
        }
    }
}
