using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CheckPrime
    {
        public bool SayPrime(int n)
        {
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cnt = cnt + 1;
                    //cnt++;
                }
            }

            if (cnt == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
