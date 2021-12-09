using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        delegate double MyDelegate(double R);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate (Сircumference);
            myDelegate?.Invoke(12);
            Console.WriteLine("{0:f2}",myDelegate(12));

            MyDelegate myDelegate1 = Сirclesquare;
            myDelegate1?.Invoke(12);
            Console.WriteLine("{0:f2}",myDelegate1(12));

            MyDelegate myDelegate2 = Ballvolume;
            myDelegate2?.Invoke(12);
            Console.WriteLine("{0:f2}", myDelegate2(12));

            Console.ReadKey();
        }
        
        static double Сircumference(double R1)
        {
            return 2 * Math.PI * R1;

        }
        static double Сirclesquare(double R2)
        {
            return 2 * Math.PI * Math.Pow(R2, 2);

        }
        static double Ballvolume(double R3)
        {
           return 4 / 3 * Math.PI * Math.Pow(R3, 3);
        }
            
                


               
     }     
        

        
} 
