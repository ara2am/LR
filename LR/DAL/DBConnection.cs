using LR.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace LR
{
    class DBConnection
    {
        void SendToDb (Cafe cafe)
        {
            using (CafeContext db = new CafeContext ())
            {
                db.ListOfCafe.Add (cafe);
                db.SaveChanges ();
            }
        }
    }
}
