using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Repositories
{
    public class CafeRepository : Repository<Cafe>
    {
        public CafeRepository (DbContext context) : base (context)
        {
        }

        public void UpdateQuest (int id, Cafe req)
        {
            Cafe tmp = Get (id);
            //tmp.Name = req.Name;
            //tmp.Location = req.Location;
            tmp.Info = req.Info;
            tmp.Places = req.Places;
            tmp.Workers = req.Workers;
        }
    }
}
