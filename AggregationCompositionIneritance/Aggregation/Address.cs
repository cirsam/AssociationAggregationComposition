using System;

namespace AggregationCompositionIneritance
{
    public class Address
    {
        public int address_id;
        public string addressline, city, state;

        public Address(int user_id,string addressline, string city, string state)
        {
            this.address_id = user_id;
            this.city = city;
            this.addressline = addressline;
            this.state = state;
        }
    }

}
