using BLL.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class API
    {
        Dictionary<string, Cafe> Caves = new Dictionary<string, Cafe> ();

        public void AddnewCafe (Cafe cafe)
        {
            Caves.Add (cafe.Name, cafe);
        }

        public bool Reserve (string NameCafe, int number)
        {
            return Caves [NameCafe].Reserve (number);
        }

        public bool Find (string NameCafe, int number)
        {
            return Caves [NameCafe].Places [number].Free;
        }
    }
}
