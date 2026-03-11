using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Methods
    {
        public  int Addition(out int count,params int[] numbers)
        {
             count = 0;
            foreach (int number in numbers)
            {
                count++;
            }
            return count;
        }

        public  string Concatination(params string[] words)
        {
            string sentence = "";
            foreach (string word in words)
            {
                sentence = sentence + word + " ";
            }
            return sentence;
        }

        public  int Ref_addition(int a)
        {
            return a += 1;
        }

        public  int Ref_subtraction(ref int b)
        {
            return b -= 5;
        }


    }
}
