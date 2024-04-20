using System.Threading;

namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Month Number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Day Number (1-30): ");
            int day = Convert.ToInt32(Console.ReadLine());

            string[] months = { "January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December"};
            string[] days = { "One", "Two", "Three", "Four", "Five", "Six",
            "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",  "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen", "twenty", "twenty-one", "twenty-two", "twenty-three", "twenty-four",
            "twenty-five", "twenty-six", "twenty-seven", "twenty-eight", "twenty-nine", "thirty"};

            if((month >= 1 && month <= 12) && (day >= 1 && day <= 30))
            {
                Console.Write( "The Date is");

                if (month == 1)
                {
                    Console.Write(" " + months[0] + " ");
                }
                else if (month == 2) 
                {
                    Console.Write(" " + months[1] + " ");
                }
                else if (month == 3)
                {
                    Console.Write(" " + months[2] + " ");
                }
                else if (month == 4)
                {
                    Console.Write(" " + months[3] + " ");
                }
                if (month == 5)
                {
                    Console.Write(" " + months[4] + " ");
                }
                else if (month == 6)
                {
                    Console.Write(" " + months[5] + " ");
                }
                else if (month == 7)
                {
                    Console.Write(" " + months[6] + " ");
                }
                else if (month == 8)
                {
                    Console.Write(" " + months[7] + " ");
                }
                if (month == 9)
                {
                    Console.Write(" " + months[8] + " " );
                }
                else if (month == 10)
                {
                    Console.Write(" " + months[9] + " ");
                }
                else if (month == 11)
                {
                    Console.Write(" " + months[10] + " ");
                }
                else if (month == 12)
                {
                    Console.Write(" " + months[11] + " ");
                }

                if (day == 1)
                {
                    Console.Write(days[0]);
                }
                else if (day == 2)
                {
                    Console.Write(days[1]);
                }
                else if (day == 3)
                {
                    Console.Write(days[2]);
                }
                else if (day == 4)
                {
                    Console.Write(days[3]);
                }
                else if (day == 5)
                {
                    Console.Write(days[4]);
                }
                else if (day == 6)
                {
                    Console.Write(days[5]);
                }
                else if (day == 7)
                {
                    Console.Write(days[6]);
                }
                else if (day == 8)
                {
                    Console.Write(days[7]);
                }
                else if (day == 9)
                {
                    Console.Write(days[8]);
                }
                else if (day == 10)
                {
                    Console.Write(days[9]);
                }
                else if (day == 11)
                {
                    Console.Write(days[10]);
                }
                else if (day == 12)
                {
                    Console.Write(days[11]);
                }
                else if (day == 13)
                {
                    Console.    Write(days[12]);
                }
                else if (day == 14)
                {
                    Console.Write(days[13]);
                }
                else if (day == 15)
                {
                    Console.Write(days[14]);
                }
                else if (day == 16)
                {
                    Console.Write(days[15]);
                }
                else if (day == 17)
                {
                    Console.WriteLine(days[16]);
                }
                else if (day == 18)
                {
                    Console.WriteLine(days[17]);
                }
                else if (day == 19)
                {
                    Console.WriteLine(days[18]);
                }
                else if (day == 20)
                {
                    Console.WriteLine(days[19]);
                }
                else if (day == 21)
                {
                    Console.WriteLine(days[20]);
                }
                else if (day == 22)
                {
                    Console.WriteLine(days[21]);
                }
                else if (day == 23)
                {
                    Console.WriteLine(days[22]);
                }
                else if (day == 24)
                {
                    Console.WriteLine(days[23]);
                }
                else if (day == 25)
                {
                    Console.WriteLine(days[24]);
                }
                else if (day == 26)
                {
                    Console.WriteLine(days[25]);
                }
                else if (day == 27)
                {
                    Console.WriteLine(days[26]);
                }
                else if (day == 28)
                {
                    Console.WriteLine(days[27]);
                }
                else if (day == 29)
                {
                    Console.WriteLine(days[28]);
                }
                else if (day == 30)
                {
                    Console.WriteLine(days[29]);
                }

            }
            else
            {
                Console.WriteLine("invalid Input, please make sure the value inputed are within 1-12 on month and 1-20 on days");
            }
            { }
        }
    }
}
