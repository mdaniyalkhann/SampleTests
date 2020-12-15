using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Recording Transaction!");
        }
    }
}