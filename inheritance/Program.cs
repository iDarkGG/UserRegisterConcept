using System;
using System.Linq;
using System.Collections;
class inheritance
{
    public List<inheritance> userData = new List<inheritance>();       
    private string userName { get; set; }
    private string password { get; set; }
    private static Int32 userID = 0;
    private bool USER_LOG_STATUS = false;
    private bool USER_TAKEN = false;
    public void Inheritance(string var1, string var2, string var3, string var4)
    {

        
    }

    public void RegisterUser(string newUser, string password, string confPassword)
    {
        //UserChecker
        if(newUser != null)
        {
            for(int i = 0; i < userData.Count; i++)
            {
                if (newUser.Equals(userData[i]))
                {
                    Console.WriteLine("El Nombre de Usuario Ya existe por favor selecciona otro.");
                    USER_TAKEN = true;
                }
                else
                {
                    Console.WriteLine("Por favor ingresa la contraseña.");
                    if (password.Equals(confPassword))
                    {
                        Console.WriteLine("Registrado Correctamente");
                        this.userData.Add(new inheritance() { userName = newUser, password = confPassword });
                    }
                }
            }
            
        }
    }

    public static Int32 AddUser()
    {

        return ++userID;
    }
}
