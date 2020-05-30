using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;


namespace DAL
{
    public class API
    {
        private readonly GeneralContext _context;

        public API (GeneralContext context)
        {
            _context = context;
            Quests = new CafeRepository (_context);
        }

        public CafeRepository Quests { get; private set; }

        public int Complete ()
        {
            return _context.SaveChanges ();
        }

        public void Dispose ()
        {
            _context.Dispose ();
        }
    }
}