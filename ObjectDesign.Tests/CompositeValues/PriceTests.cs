using FluentAssertions;
using ObjectDesign.CompositeValues;

namespace ObjectDesign.Tests
{
    public class price_should
    {
        [Fact]
        public void not_allow_to_be_constructed_when_amount_is_null()
        {
            Action price = () => new Price(null, new Currency("USD"));
            price.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void not_allow_to_be_constructed_when_currency_is_null()
        {
            Action price = () => new Price(Amount.FromScalar(1000), null);
            price.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void be_equal_to_other_price_of_the_same_amount_and_currency()
        {
            var price = Price.From(amount: 1000, code: "USD");
            price.Should().Be(Price.From(amount: 1000, code: "USD"));
        }

        [Fact]
        public void not_be_equal_to_other_price_of_different_currency()
        {
            var price = Price.From(amount: 1000, code: "USD");
            price.Should().NotBe(Price.From(amount: 1000, code: "EUR"));
        }
    }
}

