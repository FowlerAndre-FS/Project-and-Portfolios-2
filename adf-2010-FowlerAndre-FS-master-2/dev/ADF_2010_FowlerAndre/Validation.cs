/**
 * Name: Andre Fowler Jr
 * Date: 10/11/2020
 * Class: ADF
 * Assignment: Data Integration 1
 */
using System;
using System.Text.RegularExpressions;

namespace ADF_2010_FowlerAndre
{
    /*
     * class name: Validation
     * Purpose: This is class takes input from user and validates it.
     */
    public static class Validations
    {
        public static Boolean validateString(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$");
            
        }
        public static bool ValidateInt(string str)
        {
            return Regex.IsMatch(str, @"^[0-9]+$");
        }
    }
}

