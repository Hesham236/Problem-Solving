using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problem_solving
{
    internal class FirstBadVersionClass
    {
        public int FirstBadVersion(int n)
        {
            string[] GB = { "B","B"};
            if (n == 1 && GB[0] == "B") return 1;
            if (n == 1 && GB[0] != "B") return 0;
            //string x = isBadVersion(n/2)
            if (GB[(n / 2)] == "B")
            {
                for(int i = 0 ;i< (n/2);i++) 
                {
                    if (GB[i] == "B") return i + 1;
                }
            }
            else if (GB[(n / 2)] != "B")
            {
                for (int i = n/2; i < n ; i++)
                {
                    if (GB[i] == "B") return i + 1;
                }
            }
            return -1;
        }
    }
}
