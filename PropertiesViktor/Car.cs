using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesViktor
{
    public class Car
    {
        private string licenseNumber = "krj137";
        private string color;

        public string GetLicenceNumber()
        {
            return $"*** {licenseNumber.Substring(0, 3).ToUpper()} {licenseNumber.Substring(3, 3).ToUpper()} ***";
        }

        public void SetLicenceNumber(string newLN)
        {
            int length = newLN.Length;
            if (length == 6)
            {
                string firstHalf = newLN.Substring(0, 3);
                string secondHalf = newLN.Substring(3, 3);
                string[] forbiddenWords = { "fan", "ful" };

                bool isThreeLetters = CheckIfThreeLetters(firstHalf);
                bool safeWord = CheckUnsafeWords(firstHalf, forbiddenWords);
                bool safeNumber = CheckNumbers(secondHalf);

                if (isThreeLetters && safeWord == true && safeNumber == true)
                {
                    licenseNumber = newLN;
                }
                else
                {
                    Console.WriteLine("Improper licence number");
                }
            }
            else
            {
                Console.WriteLine("Improper licence number");
            }
        }

        private bool CheckIfThreeLetters(string firstHalf)
        {
            bool l1 = false;
            bool l2 = false;
            bool l3 = false;
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (var c in letters)
            {
                if (c == firstHalf[0])
                {
                    l1 = true;
                }
                if (c == firstHalf[1])
                {
                    l2 = true;
                }
                if (c == firstHalf[2])
                {
                    l3 = true;
                }
            }
            if (l1 && l2 && l3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckNumbers(string secondHalf)
        {
            foreach (var character in secondHalf)
            {
                try
                {
                    int.TryParse(character.ToString(), out int intChar);
                    if (intChar >= 0 && intChar <= 9)
                    {
                        continue;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckUnsafeWords(string firstHalf, string[] forbiddenWords)
        {
            foreach (var word in forbiddenWords)
            {
                if (firstHalf == word)
                {
                    return false;
                }
            }
            return true;
        }
        public void SetColor(string color)
        {
            bool isOkColor = false;
            string[] validColors = { "red", "green", "blue", "yellow" };
            foreach (var vColor in validColors)
            {
                if (color.ToLower() == vColor.ToLower())
                {
                    this.color = color;
                    isOkColor = true;
                    break;
                }
                else
                {
                    isOkColor = false;
                }
            }
            if (!isOkColor)
            {
                throw new Exception($"{color} is not allowed as color");
            }
        }
        public string GetColor()
        {
            return this.color;
        }
    }
}
