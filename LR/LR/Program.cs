using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace LR
{
    class Program
    {
        static void Main (string [] args)
        {
            API api = new API ();
            string input;
            while (true)
            {
                Console.WriteLine ("1. Додати нове кафе");
                Console.WriteLine ("2. Забронювати мiсце в кафе");
                Console.WriteLine ("3. Знайти мiсце в кафе");
                Console.WriteLine ("4. Вихiд");
                input = Console.ReadLine ();
                switch (input)
                {
                    case "1":
                    {
                        Console.WriteLine ("Введiть назву кафе");
                        var name = Console.ReadLine ();
                        Console.WriteLine ("Введiть локацiю");
                        var loc = Console.ReadLine ();
                        Console.WriteLine ("Введiть кiлькiсть мiсць");
                        var count = Console.ReadLine ();
                        api.AddnewCafe (new BLL.Object.Cafe (name, loc, Convert.ToInt32 (count)));
                    }
                    break;
                    case "2":
                    {
                        Console.WriteLine ("Введiть назву кафе");
                        var name = Console.ReadLine ();
                        Console.WriteLine ("Введiть кiлькiсть мiсць");
                        var numb = Console.ReadLine ();
                        api.Reserve (name, Convert.ToInt32 (numb));
                    }
                    break;
                    case "3":
                    {
                        Console.WriteLine ("Введiть назву кафе");
                        var name = Console.ReadLine ();
                        Console.WriteLine ("Введiть кiлькiсть мiсць");
                        var numb = Console.ReadLine ();
                        api.Find (name, Convert.ToInt32 (numb));
                    }
                    break;
                    case "4":
                    {
                        break;
                    }
                }
            }
        }
    }
}
