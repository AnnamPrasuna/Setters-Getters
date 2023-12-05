
using PropertiCitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyCitie
{
    internal class Program
    {
        string _name;
        double _salary;
        cities _city;
        public string country                 //auto implemented property
        {
            get; set;
        }
        public Program(string name, double salary,cities city,string country)
        {
            _name = name;
           _salary = salary;
            _city = city;
            this.country = country;
        }
        public cities city
        {
            get { return _city; }
            set { _city = value; }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("prasu", 30000.0, cities.hyderabad,"india");
             cities c=p1.city;
            Console.WriteLine("city name is :"+c);
            p1.city = cities.bangalore;
            Console.WriteLine("city name is :" + p1.city);
          string cntry=  p1.country;
            Console.WriteLine( "the old country is :"+cntry);
            p1.country = "england";
            Console.WriteLine("the new country name is :"+p1.country);
            Console.ReadLine();
        }
    }
}
