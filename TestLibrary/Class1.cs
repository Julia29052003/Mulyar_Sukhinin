using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class TestClass
    {
        int x = 0;
        int y = 0;

        void OutputInfo()
        {
            Console.WriteLine(Convert.ToString(x) + "" + Convert.ToString(y));
        }

        int XY()
        {
            x = 1;

            for (int i = 0; i < y; i++)
            {
                x = x * x;
            }

            return x;
        }
    }
}
