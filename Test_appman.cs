using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_appman
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc573";
            string str2 = "a5b7c3";

            StringBuilder Output1 = new StringBuilder();
            StringBuilder Output2 = new StringBuilder();
            
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsNumber(str1[i]))
                {
                    Output1.Append(str1[i]);
                }


            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (Char.IsNumber(str2[i]))
                {
                    Output2.Append(str2[i]);
                }


            }

            Console.WriteLine(Output1);
            Console.WriteLine(Output2);

        }
    }
}
