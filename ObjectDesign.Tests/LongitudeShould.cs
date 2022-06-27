using FluentAssertions;

namespace ObjectDesign.Tests
{
    public class longitude_should
    {
        [Fact]
        public void be_in_a_valid_range()
        {
            Action longitude = () => Longitude.FromScalar(-190);
            longitude.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Longitude must be in range [-180; 180] (Parameter 'value')\r\nActual value was -190.");
        }
    }
}
