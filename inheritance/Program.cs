using System;
using System.Linq;
using System.Collections;
namespace UserRegisterConceptUI
{
    public class inheritance
    {
        public static void Main(String[] args)
        {
                
        }

        public List<inheritance> userData = new List<inheritance>();
        private int currentID;
        private string userName { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private static Int32 userID = 0;
        private bool USER_LOG_STATUS = false;
        private bool USER_TAKEN = false;
        public void RegisterUser(string email, string newUser, string password, string confPassword)
        {
            if(userData.Count > 0)
            {
                //UserChecker
                if (newUser != null)
                {
                    for (int i = 0; i < userData.Count; i++)
                    {
                        do
                        {
                            if (newUser.Equals(userData.ElementAt(i).userName))
                            {
                                Console.WriteLine("El Nombre de Usuario Ya existe por favor selecciona otro.");
                                USER_TAKEN = true;
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine("Por favor ingresa la contraseña.");
                                    if (password.Equals(confPassword))
                                    {
                                        Console.WriteLine("Registrado Correctamente");
                                        this.userData.Add(new inheritance() { email = email, userName = newUser, password = confPassword, currentID = Generator() });
                                        USER_LOG_STATUS = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Las Contraseñas no Coinciden");
                                    }
                                } while (password != confPassword);


                            }
                        } while (USER_TAKEN);
                        if (USER_LOG_STATUS)
                        {
                            break;
                        }
                    }

                }
            }
            else
            {
                this.userData.Add(new inheritance() { email = email, userName = newUser, password = confPassword, currentID = Generator() });
            }


        }

        public void UserLogin(string newUser, string password)
        {
            if (newUser != null)
            {
                for (int i = 0; i < userData.Count; i++)
                {

                    do
                    {
                        if (newUser.Equals(userData.ElementAt(i).userName) || (newUser.Equals(userData.ElementAt(i).email)))
                        {
                            Console.WriteLine("El Nombre de Usuario Ya existe por favor selecciona otro.");
                            USER_TAKEN = true;
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Por favor ingresa la contraseña.");
                                if (password.Equals(userData.ElementAt(i).password))
                                {
                                    Console.WriteLine("Ingresó correctamente");
                                    USER_LOG_STATUS = true;
                                }
                                else
                                {
                                    Console.WriteLine("Las Contraseñas no Coinciden");
                                }
                            } while (password != userData.ElementAt(i).password);


                        }
                    } while (USER_TAKEN);
                    if (USER_LOG_STATUS)
                    {
                        break;
                    }
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

