using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregationCompositionIneritance
{
    public class Employee
    {
        public int id;
        public string name;
        private IList<Address> _address;

        public Employee(int id, string name, IList<Address> address)
        {
            this.id = id;
            this.name = name;
            this._address = address;
        }

        internal void Display()
        {
            Console.WriteLine("Name = " + name + " Addess = " + _address.Where(m => m.address_id == 2).FirstOrDefault().addressline);
        }
    }
}
