using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Worker
    {
        public string FName { get; private set; }
        public string LName { get; private set; }

        public Worker(string _FName, string _LName)
        {
            FName = _FName;
            LName = _LName;
        }

        public void Work()
        {

        }

    }
}
