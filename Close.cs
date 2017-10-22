using System;

namespace execution_order
{
    public class Close
    {
        public static void Execute(Work work)
        {
            if (work == null)
                throw new ArgumentNullException(nameof(work));

            // implementation of the Close
        }
    }
}