using System;

namespace DesignPatterns.StrategyPattern
{
    public class PNGCompressor : ICompressor
    {
        public void Compress(string filename)
        {
            Console.WriteLine("Compressing PNG Image...");
        }
    }
}
