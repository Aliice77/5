using System;

namespace search2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char b;
            int c=0;
            Console.Write("enter a number: ");
            a=Console.ReadLine();
            Console.Write("enter a number that you want to search: ");
            b=Convert.ToChar(Console.ReadLine());
            foreach (var item in a)
            {
                if (item==b)
                {
                    c++;
                }
            }
            Console.WriteLine("adad {0}: {1} bar tekrar shode ast",b,c);
        }
    }
}
