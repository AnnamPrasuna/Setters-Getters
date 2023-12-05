using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setters_Getters
{
    internal class Property
    {
        private int _id = 56;
        public int id
        {
            get { return _id; }     //Represent a value returning method without parameter
            set                     //Represent a non value returning method with parameter
            {
                if (value > _id)
                {

                    _id = value;
                    Console.WriteLine("existing");
                }
                else
                {
                    Console.WriteLine("not existing ");
                };
            }
        }
        //public int getId() -----provides only get access to the variable
        //{
        //    return id;
        //}
        //public void setId(int NewId)  ------provides only set access to the variable
        //{
        //    id = NewId;
        //}



    }
}
