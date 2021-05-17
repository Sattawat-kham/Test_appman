using System;
using System.Text;


namespace ConsoleApplication1
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.Write("input String:");
            string input = Console.ReadLine();
            Console.WriteLine("input is: " + input);

            var output = subString(input);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(output + "  Type ->  " + output.GetType());
        }
        public static int subString(string str)
        {

            StringBuilder reSult = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i]))
                {
                    reSult.Append(str[i]);
                }

            }

            string outPut = reSult.ToString();
            int j = 0;
            int myNumber1 = 0;
            string strReverse = String.Empty;


            foreach (char temp in outPut)
            {
                strReverse = temp + strReverse;
            }
            foreach (char temp in strReverse)
            {
                int i = temp - 48;
                myNumber1 = myNumber1 + i * myPower(10, j);
                j++;
            }

            return myNumber1;

        }

        public static int myPower(int i, int j)
        {
            int final = 1;
            for (int loop = 0; loop < j; loop++)
            {
                final = final * i;
            }
            return final;
        }

    }

}
