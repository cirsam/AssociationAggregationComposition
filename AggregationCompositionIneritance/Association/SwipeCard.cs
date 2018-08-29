namespace AggregationCompositionIneritance
{
    public class SwipeCard:ISwipeCard
    {
        public int card_number = 123;

        public string Swiped(Manager manager)
        {

            return "Manager is using the swipe card"+manager.name;

        }
       
    }
}