using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktila__02
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            long number;
            string buf;
            do
            {
               buf = Console.ReadLine();
                ok = long.TryParse(buf, out number);
                if (!ok || number < 0) { Console.WriteLine("Нужно вводить натуральные числа"); ok = false; }
            } while (!ok);
            string binaryCode = Convert.ToString(number, 2);
            int Leight = binaryCode.Length;
            long count = 0;
            for (int i=0;i<Leight;i++)
            {
                string u = ""+binaryCode[i];
                int count123 = int.Parse(u);
                count = count + count123;
            }
            
           // long BinaryCodeInt = long.Parse(binaryCode);
             // Число единиц в исходном числе
            long count2 = 0; // Число единиц во втором числе 
           long second=0;
            //for (int i=Leight;i>0;i=i-1)
            //{
            //    long dec = 10;
            //    long one =BinaryCodeInt % dec ;
            //    count = count + one;
            //    double code = BinaryCodeInt / 10;
            //    double New = Math.Truncate(code);
            //    BinaryCodeInt = (long)New;
            //}
            for (long i = number+1;i!=0;i++)
            {
                count2 = 0;
                string binaryCode2 = Convert.ToString(i, 2);
                int Leight2 = binaryCode2.Length;
                for (int i2 = 0; i2 < Leight2; i2++)
                {
                    string u = "" + binaryCode2[i2];
                    int count12 = int.Parse(u);
                    count2 = count2 + count12;
                }

                if (count == count2)
                { second = i; i = -1; break; }
            }
            Console.WriteLine(second);
            Console.Read();
        }
    }
}
