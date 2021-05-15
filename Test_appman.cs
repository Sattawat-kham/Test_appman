using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
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

            string str3 = Output1.ToString();
            string str4 = Output2.ToString();
            int j = 0;
            int myNumber1 = 0;
            int myNumber2 = 0;
            string strReverse = String.Empty;


            foreach (char temp in str3)
            {
                strReverse = temp + strReverse;
            }

            foreach (char temp in strReverse)
            {
                int i = temp - 48;
                myNumber1 = myNumber1 + i * myPower(10, j);
                j++;
            }

            j = 0;
            strReverse = String.Empty;

            foreach (char temp in str4)
            {
                strReverse = temp + strReverse;
            }

            foreach (char temp in strReverse)
            {
                int i = temp - 48;
                myNumber2 = myNumber2 + i * myPower(10, j);
                j++;
            }


            Console.WriteLine(myNumber1);
            Console.WriteLine(myNumber2);
            Console.ReadLine();


        }

        private static int myPower(int i, int j)
        {
            int final = 1;
            for (int loop = 0; loop < j; loop++)
                final = final * i;
            return final;
        }
    }

}
