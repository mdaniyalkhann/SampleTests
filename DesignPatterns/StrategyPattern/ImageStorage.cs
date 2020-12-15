using DesignPatterns.StrategyPattern.Filter;

namespace DesignPatterns.StrategyPattern
{
    public class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
