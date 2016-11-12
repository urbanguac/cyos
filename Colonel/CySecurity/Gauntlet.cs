using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel
{
    class Gauntlet
    {
        public static bool secure = true;
        public static string[] usernames = { "cyan", "Professor Falken" };
        public static string[] passwords = { "scnminus", "Joshua" };

        /*
         * Gauntlet is the ultra secure system designed to protect CyOS.
         * Nothing gets in, nothing gets out.
         * Once a password is programmed into the Kernel, there's no going back.
         * Source code is the only method of retrieving passwords.
        */

        public static void login(bool type)
        {
            if (type != secure)
            {
                string username = "";
                string password = "";
                bool loggedIn = false;
                int attempts = 0;
                while (!loggedIn)
                {
                    Console.Write("Username:");
                    username = Console.ReadLine();
                    Console.Write("Password:");
                    password = Console.ReadLine();
                    for (int i = 0; i < usernames.Length; i++)
                    {
                        if (username == (usernames[i]) && password == (passwords[i]))
                        {
                            loggedIn = true;
                            if (i == 1) Console.WriteLine("\n\n\nGreetings Professor Falken.");
                        }
                        else { attempts++; Console.WriteLine("Error: password mismatch. Try again."); }
                    }
                    if (attempts >= 3)
                    {
                        Console.WriteLine("Too many attempts. Please power down.");
                        throw new Exception("BadLogin");
                        while (!loggedIn) { }
                    }
                }
            }
        }
    }
}
