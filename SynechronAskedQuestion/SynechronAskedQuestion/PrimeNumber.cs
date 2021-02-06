using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class PrimeNumber
    {
        //2,3,5,7,11,13..
        public void PrimeNum() {
            int ctr;
            for (int i=1; i<=50; i++) {
                ctr = 0;
                for (int j = 2; j <= i/2; j++) {
                    if (i % j == 0) {
                        ctr++;
                        break;

                    }
                }
                if (ctr == 0 && i != 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
