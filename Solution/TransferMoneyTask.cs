using System;

namespace TemplateMethodPattern.Solution
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
