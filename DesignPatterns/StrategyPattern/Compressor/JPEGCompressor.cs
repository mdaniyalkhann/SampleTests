using System;

namespace DesignPatterns.StrategyPattern
{
    public class JPEGCompressor : ICompressor
    {
        public void Compress(string filename)
        {
            Console.WriteLine("Compressing JPEG Image...");
        }
    }
}
