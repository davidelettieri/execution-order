using System;

namespace execution_order
{
    public class Work
    {
        private Work()
        {

        }

        public static Work Execute(Init init)
        {
            if (init == null)
                throw new ArgumentNullException(nameof(init));

            return new Work();
        }
    }

}