namespace ObjectDesign.NamedConstructors
{
    public class Reservation
    {
        private Reservation()
        {

        }

        public static Reservation Make()
        {
            return new Reservation();
        }
    }
}
