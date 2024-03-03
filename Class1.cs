using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB
{
    internal class FizzBuzz
    {
        int upper_num = 0;
        public FizzBuzz(int max)
        {
            this.upper_num = max;
        }
        public void display()
        {
            int i=1;
            while(i <= upper_num){
                if (i % 3 == 0)
                {
                    if(i%5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;

            }
        }
    }
}
