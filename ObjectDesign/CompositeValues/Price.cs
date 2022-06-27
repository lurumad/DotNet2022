namespace ObjectDesign.CompositeValues
{
    public class Price : ValueObject
    {
        private readonly Amount amount;
        private readonly Currency currency;

        public Price(Amount amount, Currency currency)
        {
            Ensure.Argument.NotNull(amount, nameof(amount));
            Ensure.Argument.NotNull(currency, nameof(currency));
            this.amount = amount;
            this.currency = currency;
        }

        public static Price From(decimal amount, string code)
        {
            return new Price(Amount.FromScalar(amount), Currency.FromCode(code));
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return amount;
            yield return currency;
        }
    }
}
