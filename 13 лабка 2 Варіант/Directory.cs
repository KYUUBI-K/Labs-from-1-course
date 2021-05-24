using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_лабка_2_Варіант
{
    class Directory
    {
        public string name;
        public string adress;
        public string phone;
        public string specialization;
        public int working_hours;
        public Directory(string name, string adress, string phone, string specialization, int working_hours)
        {
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.specialization = specialization;
            this.working_hours = working_hours;

        }
    }
}
