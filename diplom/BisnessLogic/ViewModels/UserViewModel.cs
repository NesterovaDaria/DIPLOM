using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLogic.ViewModels
{
    //класс, описывающий пользователя для отображения
    public class UserViewModel
    {
        public int Id { get; set; }
        //Логин
        public string Login { get; set; }
        //Пароль
        public string Password { get; set; }
        //Почта
        public string Email { get; set; }
        //список языков, которые изучает пользователь
        public List<string> Languages { get; set; }
        //Роль
        public Role Role { get; set; }
    }
}
