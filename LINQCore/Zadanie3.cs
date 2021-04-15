using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class GenerateCity
    {
        public string ID="";
        public string City;
        public GenerateCity(string city)
        {
            City = removeEnter(city);
            if (city.Length > 1)
            {
                ID = city.Substring(0, 1);
            }
            
        }
        public Boolean Contains(string ID)
        {
            if (this.ID == ID)
                return true;
            return false;
        }
        public string removeEnter(string city)
        {
            return city.Replace("\n", " ");
        }
        public string removeAllButLetter(string city)
        {
            return city.Replace("\n", "");
        }
        public void display()
        {
            Console.WriteLine("{0}", City);
        }

    }
    class Zadanie3
    {
        public void displayDictionary(Dictionary<string, GenerateCity> productsDictionary)
        {
            Console.WriteLine("Słownik:");
            foreach (KeyValuePair<string, GenerateCity> kvp in productsDictionary)
            {
                Console.WriteLine("{0} \n{1} ", kvp.Key, kvp.Value.City);
            }
        }
        public static int Exist(List<GenerateCity> support,string id)
        {
            for(int i = 0; i < support.Count(); i++)
            {
                if (support[i].ID == id)
                    return i;
            }
            return -1;
        }
        public static void city(List<string> list)
        {
            IEnumerable<string> cities = list.Where((item) => (item.Length>3)&&(item!= "X\n")).Select(item => item);
            IEnumerable<string> commands = list.Where((item) => (item.Length <= 3) && (item != "X\n")).Select(item => item);
            

            GenerateCity someNewCity=new GenerateCity("");
            List<GenerateCity> support = new List<GenerateCity>();
            foreach (string obj in cities)
            {
                int i = Exist(support, obj.Substring(0, 1));
                if (i != -1)//powtórzone ID
                {
                    support[i].City += someNewCity.removeEnter(obj);
                }
                else
                {
                    someNewCity = new GenerateCity(obj);
                    support.Add(someNewCity);
                }

            }
            support.GroupBy(x => x.ID);
            for (int i = 0; i < support.Count(); i++)
            {
                string[] array = support[i].City.Split(new Char[] {' '});
                var sorted = array.OrderBy(item => item).ToArray();
                support[i].City = sorted[0];
                for (int j = 1; j < array.Length; j++)
                {
                    support[i].City += sorted[j];
                    support[i].City += " ";
                }
            }


            Dictionary<string, GenerateCity> productsDictionary = support.ToDictionary(x => x.ID);

            int index = 0;
            foreach (string obj in commands)
            {
                string command = someNewCity.removeAllButLetter(obj);
                if (support[index].ID.Contains(command))
                    support[index].display();
                else
                    Console.WriteLine("PUSTE");
                index++;
            }

        }
        
        static void Main()
        {
            List<string> cityList = new List<string>{ "Paryż\n","Praga\n","Kraków\n","Pcim\n","Płock\n", "X\n", "P\n", "B\n" };
            city(cityList);
        }
        
    }
}
