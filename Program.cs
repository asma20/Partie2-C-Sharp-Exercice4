using System;

namespace Partie2Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            String login;
            String password;
            Console.WriteLine("Saisir votre login");
            login=Console.ReadLine();
            Console.WriteLine("Saisir votre login");
            password = Console.ReadLine();

            int i = 0;
            if(login=="asma"&& password == "123")
            {
                i= 1;
            }
            else
            {
                i = 0;
            }

             
            switch (i)
            {

                
                case 0:
                    
                    Console.WriteLine("Mavais login ou password .");
                    break;
               
                default:
                    Console.WriteLine("Bienvenue à la Manu.");
                    break;
            }

           

        }
    }
}
