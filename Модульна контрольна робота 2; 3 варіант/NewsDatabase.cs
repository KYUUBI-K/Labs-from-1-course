using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тест
{
    class NewsDatabase
    {
        private List<News> _Db = new List<News>();
        //додати
        public void Add(News news)
        {
            _Db.Add(news);
        }
        //вилучити
        public void Remove(News news)
        {
            _Db.Remove(news);
        }
        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }
        public List<News> Query(Func<News, bool> condition)
        {
            return _Db.Where(condition).ToList();
        }
        public List<News> GetAll()
        {
            return this._Db;
        }
        public News GetByIndex(int index)
        {
            return this._Db[index];
        }
    }
}
