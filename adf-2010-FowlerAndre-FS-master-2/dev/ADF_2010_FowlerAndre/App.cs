/**
 * Name: Andre Fowler Jr
 * Date: 10/11/2020
 * Class: ADF
 * Assignment: Data Integration 1
 */
using System;
using System.IO;

namespace ADF_2010_FowlerAndre
{
    /*
     * class name: App
     * Purpose: This class does all the main functionalities like sign in, sign up and exit etc.
     */
    class App
    {
        public User _activeUser { get; set; }
        public Boolean _loggedIn { get; set; }


        public App()
        {
            Menu menu = new Menu();
            menu.Init(new String[] { "Main Menu", "Create User", "Login", "About","UserDetails", "Exit" });
            menu.Display();
            Selection(menu);
        }
        public void Selection(Menu menu)
        {
            if (_loggedIn == false)
            {
                String strOption = Console.ReadLine();
                while (!Validations.ValidateInt(strOption))
                {
                    Console.WriteLine("Wrong input.... Try Again!");
                    strOption = Console.ReadLine();
                }
                int option = Convert.ToInt32(strOption);
                switch (option)
                {
                    case 0:
                        CreateUser(menu);
                        menu.Display();
                        Selection(menu);
                        break;
                    case 1:
                        SignIn(menu);
                        break;
                    case 2:
                        About();
                        Console.WriteLine("Return to Home Menu:_");
                        Console.ReadKey();
                        Console.Clear();
                        menu.Display();
                        Selection(menu);
                        break;
                    case 3:
                        Console.Clear();
                        UserDetails();
                        Console.WriteLine("Return to Home Menu:_");
                        Console.ReadKey();
                        Console.Clear();
                        menu.Display();
                        Selection(menu);
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Exit();
                        break;
                }
            }
            else
            {
                String strOption = Console.ReadLine();
                while (!Validations.ValidateInt(strOption))
                {
                    Console.WriteLine("Wrong input.... Try Again!");
                    strOption = Console.ReadLine();
                }
                int option = Convert.ToInt32(strOption);
                switch (option)
                {
                    case 0:
                        About();
                        Console.WriteLine("Return to Home Menu:_");
                        Console.ReadKey();
                        Console.Clear();
                        menu.Display();
                        Selection(menu);
                        break;
                    case 1:
                        //Additional function option
                        Console.Clear();
                        ShowProfile();
                        Console.WriteLine("Return to Home Menu:_");
                        Console.ReadKey();
                        Console.Clear();
                        menu.Display();
                        Selection(menu);
                        break;
                    case 2:
                        _loggedIn = false;
                        _activeUser = null;
                        menu = new Menu();
                        menu.Init(new String[] { "Main Menu", "Create User", "Login", "About", "Exit" });
                        Console.WriteLine("Return to Home Menu:_");
                        Console.ReadKey();
                        Console.Clear();
                        menu.Display();
                        Selection(menu);
                        break;
                    default:
                        Exit();
                        break;
                }

            }
        }

        private void Continue(Menu menu)
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
            menu.Display();
            Selection(menu);
        }

        private void Exit()
        {
            Console.WriteLine("Exiting");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private void About()
        {
            Console.WriteLine("This is the about section");
        }
        //Additional function to read data from file
        private void ShowProfile()
        {

            string n = _activeUser.Name;
            Console.WriteLine("===========================================================");
            Console.WriteLine("Profile :" + "~|" + n + "|~");
            Console.WriteLine("===========================================================");
            Console.WriteLine("ID\t\tName\t\t\tPassword");
            try
            {
                FileStream fout = new FileStream("user.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fout);
                string s;
                while ((s = sr.ReadLine()) != null)
                {

                    string[] data = s.Split(',');
                    //Console.WriteLine(data[1]);
                    //Search for Active User's Data
                    if (n == data[1])
                    {
                        Console.Write(Convert.ToInt32(data[0]) + "\t\t");
                        Console.Write(data[1] + "\t\t");
                        Console.WriteLine(data[2] + "\t\t");

                    }
                }


                Console.WriteLine("----------------------------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void UserDetails()
        {
            Console.WriteLine("\n===========================================================");
            Console.WriteLine("Users");
            Console.WriteLine("===========================================================\n");
           // Console.WriteLine("\tName\t\tCity\t\t\tPassword");

            try
            {
                FileStream fout = new FileStream("user.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fout);
                string s;
                int i = 0;
                while ((s = sr.ReadLine()) != null)
                {

                    string[] data = s.Split(',');

                    i = i + 1;
                    Console.WriteLine("|User " + i + "|");
                    Console.WriteLine("Name :" + data[1]);
                    Console.WriteLine("City :" + data[2]);
                    Console.WriteLine("Password :" + data[3] + "\n");



                }


                Console.WriteLine("----------------------------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void SignIn(Menu menu)
        {
            if (User.Login(_activeUser))
            {
                _loggedIn = true;
                Console.WriteLine("Successfully loggged in");
                //Console.Clear();
                String title = "Welcome " + _activeUser.Name;
                menu = new Menu();
                menu.Init(new String[] { title, "About", "Show Profile", "Logout", "Exit" });
                Console.WriteLine("===========================================================");
                menu.Display();
                Selection(menu);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }


        private void CreateUser(Menu menu)
        {
            int id = 1;

            Console.Clear();
            Console.Write("\t\t\tEnter username : ");
            String name = Console.ReadLine();
            while (!Validations.validateString(name))
            {
                Console.Write("Wrong input.....Try Again!");
                name = Console.ReadLine();
            }
            Console.Write("\t\t\tEnter city : ");
            String city = Console.ReadLine();
            while (!Validations.validateString(city))
            {
                Console.Write("Wrong input.....Try Again!");
                city = Console.ReadLine();
            }
            Console.Write("\t\t\tEnter password : ");
            String password = Console.ReadLine();
            while (!Validations.validateString(name))
            {
                Console.Write("Wrong input.....Try Again!");
                password = Console.ReadLine();
            }
            //Console.WriteLine(inc());


            Console.WriteLine("Your id is: " + id);
            Console.WriteLine("User's data is saved in File");



            //ADDITIONAL WORK TO ADD DATA OF USER IN FILE
            try
            {
                FileStream fin = new FileStream("user.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fin);

                _activeUser = new User(id, name, city, password);
                sw.WriteLine(id + "," + name + "," + city + "," + password);
                sw.Close();
                fin.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Continue(menu);
        }
    }
}

