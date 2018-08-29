namespace AggregationCompositionIneritance
{
    public class CompoSwipeCard
    {
        public int card_number = 123;

        public string Swiped(CompManager manager)
        {

            return "Manager is using the swipe card"+manager.name;

        }    
    }
}