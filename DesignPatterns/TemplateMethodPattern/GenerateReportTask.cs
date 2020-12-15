using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class GenerateReportTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Generate Report...");
        }
    }
}
