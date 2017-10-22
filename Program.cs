using System;

namespace execution_order
{
    class Program
    {
        static void Main(string[] args)
        {
            var initResult = Init.Execute();
            var workResult = Work.Execute(initResult);
            Close.Execute(workResult);
        }
    }
}
