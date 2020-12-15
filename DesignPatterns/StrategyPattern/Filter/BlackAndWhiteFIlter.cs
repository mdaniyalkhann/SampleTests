using System;

namespace DesignPatterns.StrategyPattern.Filter
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Apply black and white filter...");
        }
    }
}
