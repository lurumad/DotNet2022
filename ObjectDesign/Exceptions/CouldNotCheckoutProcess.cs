namespace ObjectDesign.Exceptions
{
    public class CheckoutService
    {
        public void Checkout()
        {
            /// Checkout process
            throw CouldNotCheckoutProcess.DueToProductIsOnlyAvailableToPreRegisteredUsers("dotnet");
        }
    }

    public class CouldNotCheckoutProcess : Exception
    {
        private CouldNotCheckoutProcess(string message) : base(message)
        {
        }

        public static CouldNotCheckoutProcess DueToProductHasAMinimumQuantityRequiredOrder(string product)
        {
            return new CouldNotCheckoutProcess($"{product} require a minimum order quantity.");
        }

        public static CouldNotCheckoutProcess DueToProductIsOnlyAvailableToPreRegisteredUsers(string product)
        {
            return new CouldNotCheckoutProcess($"{product} require registration.");
        }
    }
}
