
using System;

namespace W3Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnDomain("kamalrh@code.edu.az")); // Task 1

            Console.WriteLine(IsLetter("HelloWorld")); // Task 2

            Console.WriteLine(FirstLetterUpper("salaM NeceSEn?")); // Task 3

            string[] arr = { "Arif Sultanov", "Namiq Abbasov", "Samir Eliyev" };
            NameArray(arr); // Task 4

            DateTime birthYear = new DateTime(2005, 4, 28, 0, 0, 0);
            Console.WriteLine(FindAge(birthYear)); // Task 5

            
            
        }


        // 1. Verilmiş email dəyərinin domain hissəni qaytaran metod (elchin@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)

        static string ReturnDomain(string gmail)
        {
            gmail.Trim();
            int startIndex = gmail.IndexOf('@') + 1;
            string domain = gmail.Substring(startIndex);
            return domain;
        }

        // 2. Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod

        static bool IsLetter(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                }
            }
            if (str.Length == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 3. Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
        // (Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)

        static string FirstLetterUpper(string str)
        {
            str = str.Trim();
            string emptyStr = "";
            str = str.ToLower();
            char firstindex = char.ToUpper(str[0]);

            for (int i = 1; i < str.Length; i++)
            {
                char.ToLower(str[i]);
                emptyStr += str[i];
            }

            return string.Join("",firstindex, emptyStr);            
        }

        // 4. Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
        // (ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)

        static void NameArray(string[] arr)
        {
            int startIndex;
            int endIndex;
            string[] nameArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                startIndex = 0;
                endIndex = arr[i].IndexOf(' ');
                nameArr[i] = arr[i].Substring(startIndex, endIndex);
            }

            for (int i = 0; i < nameArr.Length; i++)
            {
                Console.WriteLine(nameArr[i]);
            }
        }

        // 5. Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod

        static int FindAge(DateTime birthYear)
        {
            DateTime thisYear;
            int age;
            do
            {
                thisYear = DateTime.Today;
                age = thisYear.Year - birthYear.Year;
                
            } while (thisYear < birthYear);

            return age;

        }

        
    }
}
