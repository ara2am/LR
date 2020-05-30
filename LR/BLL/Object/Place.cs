using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Object
{
        public class Place
        {
            public int Number { get; }

            public bool Free { get; private set; }

            public Place(int _Number)
            {
                Number = _Number;
                Free = true;
            }

            public void Play()
            {

            }

            public void WatchFilm()
            {

            }

            public bool ReservePlace()
            {
                if (Free)
                {
                    Free = false;
                    return true;
                }
                else
                    return false;
            }

        }
    }

