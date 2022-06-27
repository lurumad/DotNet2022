namespace ObjectDesign
{
    public class Longitude : ValueObject
    {
        private readonly float value;

        private Longitude(float value)
        {
            if (value < -180 || value > 180)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Longitude must be in range [-180; 180]");
            }

            this.value = value;
        }

        public static Longitude FromScalar(float value)
        {
            return new Longitude(value);
        }

        public static implicit operator float(Longitude longitude)
        {
            return longitude.value;
        }

        public static explicit operator Longitude(float value)
        {
            return new Longitude(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
