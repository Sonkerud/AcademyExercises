using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Properties
{
    public class Car
    {
        private string licenseNumber;

        public string LicenseNumber
        {
            get 
            {
                return $"***{licenseNumber.ToUpper()}***"; 
            }
            set 
            {
                bool correctLicenseNumber = false;
                while (!correctLicenseNumber)
                {
                    int number;
                    if (value.Length == 6)
                    {
                        try
                        {
                            number = int.Parse(value.Substring(3, 3));
                        }
                        catch (Exception)
                        {
                            throw new Exception($"Bad license number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad bad license number. Try again");
                        SetLicenseNumber(Console.ReadLine());
                        break;
                    }
                    for (int i = 0; i < badWords.Length; i++)
                    {
                        if (value.Substring(0, 3).ToLower() == badWords[i])
                        {
                            Console.WriteLine("That is a bad word! Try again:");
                            SetLicenseNumber(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            licenseNumber = value;
                            correctLicenseNumber = true;
                        }
                    }
                }
            }
        }


        private string color;
        public string Color
        {
            get { return color; }
            set 
            {
                if (value.ToLower() != "red" && value.ToLower() != "blue" && value.ToLower() != "yellow" && value.ToLower() != "green")
                {
                    throw new Exception($"Wrong color");
                }
                else
                {
                    color = value;
                }
            }
        }



        string[] badWords = {"xxx","fck","fan"};
        
        public string GetLicenseNumber() 
        {
            return $"***{LicenseNumber.ToUpper()}***";
        }

        public void SetLicenseNumber(string str)
        {
            bool correctLicenseNumber = false;
            while (!correctLicenseNumber)
            {
                int number;
                if (str.Length == 6)
                {
                    try
                    {
                        number = int.Parse(str.Substring(3, 3));
                       
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Bad license number");
                    }
                }
                else
                {
                    Console.WriteLine("Bad bad license number. Try again");
                    SetLicenseNumber(Console.ReadLine());
                    break;
                }
                for (int i = 0; i < badWords.Length; i++)
                {
                    if (str.Substring(0, 3).ToLower() == badWords[i])
                    {
                        Console.WriteLine("That is a bad word! Try again:");
                        SetLicenseNumber(Console.ReadLine());
                        break;
                    }
                    else
                    {
                        LicenseNumber = str;
                        correctLicenseNumber = true;
                    }
                }
                
                
            } 
        }

        public void SetColor(string color)
        {
            if (color.ToLower() != "red" && color.ToLower() != "blue" && color.ToLower() != "yellow" && color.ToLower() != "green")
            {
                throw new Exception($"Wrong color");
            }
            else
            {
                Color = color;
            }
        }

        public string GetColor(bool toSwedish)
        {
            if (toSwedish)
            {
                switch (Color)
                {
                    case "red": Color = "röd";
                        break;
                    case "blue": Color = "blå";
                        break;
                    case "yellow": Color = "gul";
                        break;
                    case "green": Color = "grön";
                        break;
                    default:
                        break;
                }
            }
            return Color;
        }
    }
}
