using FluentAssertions;

namespace ObjectDesign.Tests
{
    public class coordinates_should
    {
        [Fact]
        public void be_equal_to_another_coordinates_with_the_same_latitude_and_longitude()
        {
            var positionOne = new Coordinates((Latitude)37.1773f, (Longitude)(-3.5985f));
            var positionTwo = new Coordinates((Latitude)37.1773f, (Longitude)(-3.5985f));
            positionOne.Should().Be(positionTwo);
        }

        [Fact]
        public void calculate_the_straight_distance_in_kilometers_between_granada_and_madrid()
        {
            var granadaCoordinates = new Coordinates(
                (Latitude)37.1773f,
                (Longitude)(-3.5985f)
            );
            var madridCoordinates = new Coordinates(
                (Latitude)40.4168f,
                (Longitude)(-3.70379f)
            );
            var distance = granadaCoordinates.StraightDistanceInKilometersTo(madridCoordinates);
            distance.Should().Be(360.75702f);
        }
    }
}