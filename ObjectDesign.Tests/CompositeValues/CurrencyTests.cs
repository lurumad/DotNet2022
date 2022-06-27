using FluentAssertions;
using ObjectDesign.CompositeValues;

namespace ObjectDesign.Tests
{
    public class currency_should
    {
        [Fact]
        public void not_be_constructed_when_currency_symbol_is_empty()
        {
            Action currency = () => Currency.FromCode(string.Empty);
            currency.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void not_be_constructed_when_currency_symbol_is_not_valid()
        {
            Action currency = () => Currency.FromCode("AAA");
            currency.Should().Throw<ArgumentException>();
        }
    }
}
