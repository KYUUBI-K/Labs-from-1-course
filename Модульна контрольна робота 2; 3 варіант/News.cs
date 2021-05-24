using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тест
{
    class News
    {
        public string heading;
        public string content;
        public string text;
        public string date_of_publication;
        private int number_of_views;
        public int Numbers_of_views
        {
            get
            {
                return number_of_views;
            }
            set
            {
                if (value >= 0)
                    number_of_views = value;
                else
                    throw new Exception("Значення не може бути від'ємним");
            }
        }
        public News(string heading, string content, string text,string date_of_publication,int number_of_views)
        {
            this.heading = heading;
            this.content = content;
            this.text = text;
            this.date_of_publication = date_of_publication;
            this.number_of_views = number_of_views;
        }

    }
}
