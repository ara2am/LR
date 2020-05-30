using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Object
{
    public class CafeInfo
    {
        public int Id { get; set; }
        public int Licence { get; private set; }
        public bool Work { get; private set; }
        public Cafe Cafe { get; set; }
    }
}
