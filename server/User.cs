using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        public uint Id; // Идентификатор пользователя
        public string Login; // Логин для авторизации
        public string Password; // Пароль для авторизации

        public User()
        {
            Id = 0;
            Login = Password = "";
        }

        public User(uint id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
