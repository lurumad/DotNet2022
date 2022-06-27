namespace ObjectDesign
{
    public class Latitude : ValueObject
    {
        private readonly float value;

        private Latitude(float value)
        {
            if (value < -90 || value > 90)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Latitude must be in range [-90; 90]");
            }

            this.value = value;
        }

        public static Latitude FromScalar(float value)
        {
            return new Latitude(value);
        }

        public static implicit operator float(Latitude latitude)
        {
            return latitude.value;
        }

        public static explicit operator Latitude(float value)
        {
            return new Latitude(value);
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
