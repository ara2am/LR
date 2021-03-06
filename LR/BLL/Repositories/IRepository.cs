﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll ();
        T Get (int Id);
        void Add (T obj);
        void Del (int Id);
        void Update (T obj);
    }
}
