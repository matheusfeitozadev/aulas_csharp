using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Classes
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberPassword { get; set; }

        private const string UserAuth = "MATHEUS";
        private const string PasswordAuth = "123";

        public Usuario(string username, string password, bool rememberPassword)
        {
            Username = username;
            Password = password;
            RememberPassword = rememberPassword;
        }

        public string CheckUserAuth()
        {
            var message = "";

            //Checar se o usuario e senha não estão vazios
            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                message = "Usuário ou Senha estão vazios!";
            }
            else
            {
                //Checar se o usuario e senha correspondem a minha constante
                if(!(Username.ToUpper().Equals(UserAuth.ToUpper()) && Password.Equals(PasswordAuth)))
                {
                    message = "Usuário ou Senha inválidos!";
                }
            }

            return message;
        }
    }
}
