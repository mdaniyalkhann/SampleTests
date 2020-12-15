namespace TestNinja.Fundamentals
{
    public class Equality
    {
        public bool LessThan(int a, int b)
        {
            return a < b;
        }

        public bool LessThanEqualTo(int a, int b)
        {
            return a <= b;
        }

        public bool GreaterThan(int a, int b)
        {
            return a > b;
        }

        public bool GreaterThanEqualTo(int a, int b)
        {
            return a >= b;
        }

        public bool NotEqualTo(int a, int b)
        {
            return a != b;
        }

        public bool EqualTo(int a, int b)
        {
            return a == b;
        }
    }
}
