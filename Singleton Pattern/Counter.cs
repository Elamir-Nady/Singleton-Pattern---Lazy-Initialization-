using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class Counter
    {
        public int count = 0;
        private static Counter instace = null;

        private Counter()
        {
        }
        public static Counter GetInstance()
        {
            if(instace == null)
            {
                new Counter();
            }
            return instace;
        }
        public void Addone()
        {
            count++;
        }
    }
}
