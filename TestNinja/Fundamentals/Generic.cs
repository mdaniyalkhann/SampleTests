using System;

namespace TestNinja.Fundamentals
{
    public class Generic : DataTypeC<int>
    {
        private int _gT;

        public Generic(int gt)
        {
            _gT = gt;
        }
    }

    public class DataTypeC<T> where T : new()

    {
        public T Name { get; set; }
        public DataTypeC()
        {
            Console.WriteLine(Name.GetType().Name);
        }
    }
}
