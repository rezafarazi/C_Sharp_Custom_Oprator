using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Country
{
    class Program
    {
        static void Main(string[] args)
        {

            Country a_Country = new Country() {Country_Name="Iran",Country_Money_Name="Rial",Armey_Rank=22,Country_Area=1648195,GDP=191 };
            Country b_Country = new Country() { Country_Name = "China", Country_Money_Name = "Renminbi", Armey_Rank = 3, Country_Area = 9615969, GDP = 14000 };
            if (a_Country > b_Country)
            {
                Console.WriteLine("A Country Is Grate of B Country");
            }
            else
            {
                Console.WriteLine("B Country Is Grate of A Country");
            }
            Console.ReadKey();

        }
    }

    class Country
    {
        public string Country_Name { get; set; }
        public string Country_Money_Name { get; set; }
        public int Country_Area { get; set; }
        public int GDP { get; set; }
        public int Armey_Rank { get; set; }

        public static bool operator > (Country a, Country b)
        {
            if ((a.Armey_Rank + a.GDP + a.Country_Area) > (b.Armey_Rank + b.GDP + b.Country_Area)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Country a, Country b)
        {
            if ((a.Armey_Rank + a.GDP + a.Country_Area) < (b.Armey_Rank + b.GDP + b.Country_Area))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
