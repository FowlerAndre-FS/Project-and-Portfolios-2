/**
 * Name: Andre Fowler Jr
 * Date: 10/11/2020
 * Class: ADF
 * Assignment: Data Integration 1
 */
using System;

namespace ADF_2010_FowlerAndre
{
    /*
     * class name: Login
     * Purpose: This class manages user login 
     */
    public class User
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string city { get; set; }

        public User()
        {

        }
        public User(int userId,String name,string city,String password)
        {
            this.Name = name;
            this.Password = password;
            this.Id = userId;
            this.city = city;
        }

        public static Boolean Login(User user)
        {
            Console.Clear();
            Console.Write("Enter your id ");
            String strid = Console.ReadLine();
            int id = 0;
            while (!Validations.ValidateInt(strid))
            {
                Console.Write("Wrong Input.....Enter again! ");
                strid = Console.ReadLine();
            }
            id = Convert.ToInt32(strid);
            Console.Write("Enter your password ");
            String strPassword = Console.ReadLine();
            while (!Validations.validateString(strid))
            {
                Console.Write("Wrong Input.....Enter again! ");
                strPassword = Console.ReadLine();
            }
            if (id.Equals(user.Id) && strPassword.Equals(user.Password))
            {
                Console.WriteLine("User Found");
                return true;
            }
            else
            {
                Console.WriteLine("User login not recognized");
                return false;
            }
        }
    }
}
