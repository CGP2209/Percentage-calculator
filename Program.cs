using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procentregning
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Indtast beløb");
            Double beløb = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Indtast moms");
            double moms = Convert.ToDouble(Console.ReadLine()) / 100;
          
            double samletbeløb = beløb + (beløb * moms);
            Console.WriteLine("Samlet beløb inkl moms er : {0}", samletbeløb);
            
            Console.ReadLine();

        }
    }
}
