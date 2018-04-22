using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
         double a;
         double x;
         double b;

        public Program(double a, double b, double x)
        {
            this.a = a;
            this.b = b;
            this.x = x;

        }
        public void InputZnach(double aa, double bb, double xx)
        {
            a = aa;
            b = bb;
            x = xx;
        }
        ~Program()
        {
            Console.WriteLine("Знищення");
            Console.WriteLine("Натиснiть будь-яку клавiшу щоб вийти.");
            Console.ReadKey();
        }
        public double Funk()
        {
            double p = Math.Sin(a*x+b);
            return p;
        }
    }
    class Function
    {
        static void Main(string[] args)
        {
            double a=0, b=0, x=0;
            double aa, bb, xx;
            Random rand = new Random();
            Program[] rezult = new Program[100];
            int count;
            int n = 0;
            Console.WriteLine("Введiть кiлькiсть значень:");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                rezult[i] = new Program(a, b, x);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введiть значення х(" + (i + 1) + "):= ");
                xx= double.Parse(Console.ReadLine());
                aa= rand.Next(-10, 10);
                bb= rand.Next(-10, 10);
                rezult[i].InputZnach(aa, bb, xx);
            }
            
            double max = rezult[0].Funk();
            for (int i = 0; i < count; i++)
            {
                if (max < rezult[i].Funk())
                {
                    max = rezult[i].Funk();
                    n = i;
                }
            }
            Console.WriteLine("Функцiя з найбiльшим значенням: (" + (n + 1)+") Значення: "+max);
            
        }
    }
}
