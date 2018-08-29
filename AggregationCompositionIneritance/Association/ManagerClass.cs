using System;

namespace AggregationCompositionIneritance
{
    public class Manager
    {
        public string name;

        public string login(SwipeCard swipe){

            swipe.Swiped(this);

            return "manager name "+name+" has wiped card "+ swipe.card_number;

        }
    }

}