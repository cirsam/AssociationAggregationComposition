using System;

namespace AggregationCompositionIneritance
{
    public class CompManager
    {
        public string name;

        public string login(CompoSwipeCard swipe){

            swipe.Swiped(this);

            return "manager name "+name+" has wiped card "+ swipe.card_number;

        }
    }

}