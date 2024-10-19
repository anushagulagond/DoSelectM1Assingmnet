using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoSelectM1Assingmnet
{
    class Source
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    internal class Program2
    {
        public static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            double da=double.Parse(Console.ReadLine());
            double db=double.Parse(Console.ReadLine());
            double dc=double.Parse(Console.ReadLine());
            Source source = new Source();
            Console.WriteLine(source.Add(a, b, c));
            Console.WriteLine(source.Add(da, db, dc));
        }
    }
}
