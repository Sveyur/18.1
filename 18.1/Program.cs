using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var sk = new Dictionary<char, char>
           {
              {')','('},
               {'}','{'},
               {']','['},
           };
            var brackets = new Stack<char>();
            foreach (var sko in str)
            {
                if (sko == '[' || sko == '(' || sko == '{')
                    brackets.Push(sko);


                if (sko == ']' || sko == ')' || sko == '}')
                {

                    if (brackets.Count == 0)
                    {
                        brackets.Push(sko);
                        break;
                    }
                    if (brackets.Pop() != sk[sko])
                    {
                        break;
                    }
                }

            }

            if (brackets.Count == 0)
            {
                Console.WriteLine("Скобки расставлены правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не правильно");
            }
            Console.ReadKey();



        }

    }
}