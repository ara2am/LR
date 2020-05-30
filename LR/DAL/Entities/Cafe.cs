using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Cafe
    {
        public int Id { get; set; }

        public List<Place> Places = new List<Place> ();

        public List<Worker> Workers = new List<Worker> ();

        public int CountOfPlace { get; private set; }
        public string Name { get; private set; }
        public string Location { get; private set; }

        public Cafe ()
        {

        }

        public Cafe (string _Name, string _Location, int _CountOfPlace)
        {
            Name = _Name;
            Location = _Location;
            CountOfPlace = _CountOfPlace;

            for (int number = 1; number <= CountOfPlace; number++)
            {
                Places.Add (new Place (number));
            }

        }

        public bool Reserve (int number)
        {
            if (number < CountOfPlace)
                return Places [number].ReservePlace ();
            else
                throw new ArgumentOutOfRangeException (number + " > " + CountOfPlace);
        }

        public void AddWorker (string _FName, string _LName)
        {
            Workers.Add (new Worker (_FName, _LName));
        }



        public CafeInfo Info { get; set; }
    }
}
