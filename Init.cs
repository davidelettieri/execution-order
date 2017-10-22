using System;

namespace execution_order
{
    public class Init
    {
        private Init()
        {

        }

        public static Init Execute()
        {
            return new Init();
        }
    }
}