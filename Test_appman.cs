using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_appman
{
    class Test_appman
    {
        static void Main(string[] args)
        {
            string input = "abc573";

            string replacedqm = Regex.Replace(input, "[a-z]", " ");

            Console.WriteLine(replacedqm.Replace(" ", String.Empty));

            string input2 = "a5b7c3";

            string replacedqm2 = Regex.Replace(input, "[a-z]", " ");

            Console.WriteLine(replacedqm2.Replace(" ", String.Empty));

        }
    }
}
