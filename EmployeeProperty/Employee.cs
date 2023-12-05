using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProperty
{
    internal class Employee
    {
        int _Id;
        string _name;
        double _salary;
        string _dname;
        public Employee(int Id,string name,double salary,string dname)
        {
            this._Id = Id;
            this._name = name;
            this._salary = salary;
            this._dname = dname;
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string dname
        {
            get { return _dname; }
            set { _dname = value; }
        }
    }
}
