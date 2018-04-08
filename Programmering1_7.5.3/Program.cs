using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._5._3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Hur många gånger vill du singla slant? ");
            int singlaSlant = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();  // Must be outside the loop to work.
            
            while(singlaSlant>0) {
                int kronaKlave = rnd.Next(2);
                singlaSlant--;  // Correct number of repeats since it counts down. 

                if (kronaKlave==0) {
                    Console.WriteLine("Det blev krona!");
                }
                else {
                    Console.WriteLine("Det blev klave!");
                }
            }
            Console.ReadLine();
        }
    }
}
