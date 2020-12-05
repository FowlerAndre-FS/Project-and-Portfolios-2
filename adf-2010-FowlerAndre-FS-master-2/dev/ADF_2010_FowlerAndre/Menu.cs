/**
 * Name: Andre Fowler Jr
 * Date: 10/11/2020
 * Class: ADF
 * Assignment: Data Integration 1
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADF_2010_FowlerAndre
{
    /*
     * class name: Menu
     * Purpose: Shows menu and prompts
     */
    class Menu
    {
        public string _title { get; set; }
        public List<string> _menuItems { get; set; }

        public void Init(String[] arrMenuItems)
        {
            _title = arrMenuItems[0];
            _menuItems = new List<string>();
            for(int i = 1; i < arrMenuItems.Length; i++)
            {
                _menuItems.Add(arrMenuItems[i]);
            }
        }
        public void Display()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("===========================================================");
            Console.WriteLine("   "+this._title);
            Console.WriteLine("===========================================================");
            for(int i = 0; i < _menuItems.Count; i++)
            {
                Console.WriteLine("[" + (i) + "]" + " " + this._menuItems.ElementAt(i));
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Select a Menu Option: _");
        }
    }
}
