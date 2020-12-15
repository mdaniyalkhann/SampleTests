namespace TestNinja.Fundamentals
{
    public class Boolean
    {
        public bool True()
        {
            return true;
        }

        public bool False()
        {
            return true;
        }

        public bool IsTrue()
        {
            return True();
        }

        public bool IsFalse()
        {
            return !True();
        }

        public bool CheckOpposite()
        {
            if (Check(0))
            {
                return False();
            }

            return True();
        }

        public bool Check(int a)
        {
            if (a == 0)
            {
                return True();
            }

            return False();
        }
    }
}
