using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class TestClass
    {
        int x = 1;
        int y = 1;

        void OutputInfo()
        {
            Console.WriteLine(Convert.ToString(x) + "" + Convert.ToString(y));
        }

        int XY()
        {
            for (int i = 0; i < y; i++)
            {
                x = x * x;

                Console.WriteLine(Convert.ToString(x));
            }
        }
    }
}
