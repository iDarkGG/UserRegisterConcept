using System;
using System.Linq;
using System.Collections;
using System.IO.IsolatedStorage;
using System.Net.Http.Headers;

namespace UserRegisterConceptUI
{
    public class inheritance
    {
        public static void Main(String[] args)
        {
                
        }
        public List<inheritance> userData = new List<inheritance>();
        private int currentID;
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public static Int32 userID = 0;
        public bool USER_LOG_STATUS = false;
        private bool USER_TAKEN = false;
        public void RegisterUser(string email, string newUser, string password, string confPassword)
        {
            if(userData.Count > 0)
            {
                //UserChecker
                for (int i = 0; i < userData.Count; i++)
                {
                    if (email.Equals(userData.ElementAt(i).email) | newUser.Equals(userData.ElementAt(i).userName))
                    {
                        Console.WriteLine("El Usuario o Correo ya existe, Por favor prueba otro");
                        USER_TAKEN = true;
                    }
                    else
                    {
                        if (password.Equals(confPassword))
                        {
                            this.userData.Add(new inheritance() { email = email, userName = newUser, password = confPassword, currentID = Generator() });
                            USER_LOG_STATUS = true;
                        }
                    }
                }
                
            }
            else
            {
                if (password.Equals(confPassword))
                {
                    this.userData.Add(new inheritance() { email = email, userName = newUser, password = confPassword, currentID = Generator() });
                    USER_LOG_STATUS = true;
                }
                
            }


        }

        public void UserLogin(string newUser, string password)
        {
            for (int i = 0; i < userData.Count; i++)
            {
                if (newUser.Equals(userData.ElementAt(i).userName) | (newUser.Equals(userData.ElementAt(i).email)))
                {
                    if (password.Equals(userData.ElementAt(i).password))
                    {
                        Console.WriteLine("Logeado Correctamente");
                        USER_LOG_STATUS = true;
                    }
                    else
                    {
                        Console.WriteLine("Contraseñas no coinciden");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario no existe, verifica la escritura");
                }
            }
        }

        public bool UserChecker()
        {
            return USER_LOG_STATUS;
        }
        private int Generator() => ++userID;
    }
}

