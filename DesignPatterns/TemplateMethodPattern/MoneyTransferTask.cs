using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class MoneyTransferTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Transfer Money!");
        }
    }
}
