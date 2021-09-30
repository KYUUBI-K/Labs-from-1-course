using System;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

   [Serializable]
    public class Person
    {
        public string FullName;
        public int YearBirth;
        public string Gender;
        public string Education;
        public string Job;
    }
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person
                {
                    FullName = "Marco Alex Avgistin",
                    YearBirth = 1999,
                    Gender = "male",
                    Education = "High",
                    Job = "Є робота"

                },
                new Person
                {
                    FullName = "Malo Oleg Aimes",
                    YearBirth = 1992,
                    Gender = "male",
                    Education = "medium",
                    Job = "Безробітний"

                },
                new Person
                {
                    FullName = "Bovgosh Olena Volodimirivna ",
                    YearBirth = 2001,
                    Gender = "female",
                    Education = "High",
                    Job = "Є робота"

                },
                new Person
                {
                    FullName = "Lix Robert Engo",
                    YearBirth = 1995,
                    Gender = "male",
                    Education = "High",
                    Job = "Безробітний"

                },
                new Person
                {
                    FullName = "Covach Marusia Olegivna",
                    YearBirth = 1999,
                    Gender = "female",
                    Education = "medium",
                    Job = "Безробітний"

                },
                new Person
                {
                    FullName = "Evil Arthas",
                    YearBirth = 1991,
                    Gender = "male",
                    Education = "NO",
                    Job = "Безробітний"
                }
            };
            //XML
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.xml", FileMode.Create, FileAccess.Write))
                formatter.Serialize(fs, persons);

            List<Person> personList = new List<Person>();
            XmlSerializer formatter1 = new XmlSerializer(typeof(List<Person>));

            using (FileStream fs = new FileStream(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.xml", FileMode.Open, FileAccess.Read))
            {
                personList = (List<Person>)formatter.Deserialize(fs);
            }

            var filterPersonListXML = personList.Where((person) => person.Job == "Є робота");

            using (FileStream fs = new FileStream(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.xml", FileMode.Create, FileAccess.Write))
            {
                formatter1.Serialize(fs, filterPersonListXML.ToList<Person>());
            }


            //JSON
            using (StreamWriter fs = new StreamWriter(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.json"))
            {
                string jsonText = JsonConvert.SerializeObject(personList, Formatting.Indented);
                fs.Write(jsonText);
            }
            using (StreamReader fs = new StreamReader(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.json"))
            {
                personList = JsonConvert.DeserializeObject<List<Person>>(fs.ReadToEnd());
            }
            var filterPersonListJSON = personList.Where((person) => person.Job == "Є робота");
            using (StreamWriter fs = new StreamWriter(@"E:\For c# and web prog\C#\2Cource\Lab1\Persons.json"))
            {
                string jsonText = JsonConvert.SerializeObject(filterPersonListJSON.ToList<Person>(), Formatting.Indented);
                fs.Write(jsonText);


            }
        }
    }
}


