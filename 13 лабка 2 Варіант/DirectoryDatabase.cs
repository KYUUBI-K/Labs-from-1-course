using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_лабка_2_Варіант
{
    class DirectoryDatabase
    {
        private List<Directory> _Db = new List<Directory>();

        public void Add(Directory Pc)
        {
            _Db.Add(Pc);
        }

        public void Remove(Directory Pc)
        {
            _Db.Remove(Pc);
        }

        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }

        public List<Directory> Query(Func<Directory, bool> condition)
        {
            return _Db.Where(condition).ToList();
        }

        public List<Directory> GetAll()
        {
            return this._Db;
        }

        public Directory GetByIndex(int index)
        {
            return this._Db[index];
        }
    }
}

