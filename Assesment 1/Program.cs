using System;

namespace Assesment_1
{
    class Program
    {

        public static bool IsTheSame(int num1, int num2)
        {
            if ( num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static double Subtract(double num1, double num2)
        {

            double answer = num2 - num1;
            return answer;

        }


        public static string FindBuildingType(int num1)
        {

            if (num1 >= 4 && num1 <= 10)
            {

                return "This is an office building!";


            }
            else if (num1 >= 50)
            {

                return "This a SUUPER skyscraper!";
            }
            else if (num1 >= 11 && num1 >= 49)
            {

                return "This is a skyscraper!";
            }
            else if (num1 >= 3)
            {

                return "This is a house!";
            }
            return "";
        }





        static void Main(string[] args)
        {


            bool same = IsTheSame(2, 2);
            Console.WriteLine(same);

            double sub = Subtract(25, 20);
            Console.WriteLine(sub);

            string answer = FindBuildingType(5);
            Console.WriteLine(answer);
        }




    }
}
