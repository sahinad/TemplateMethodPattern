using TemplateMethodPattern.Solution;

namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.Execute();
        }
    }
}
