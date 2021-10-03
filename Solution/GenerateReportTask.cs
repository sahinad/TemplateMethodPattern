using System;

namespace TemplateMethodPattern.Solution
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate report");
        }
    }
}
