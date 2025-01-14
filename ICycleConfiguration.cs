using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    public interface ICycleConfiguration
    {
        int ReadDefaultCycle();
        void SaveDefaultCycle(int cycle);
    }
}
