using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        //int i;
        //public int I1 { get => i; set => i = value; }
        int I{get;set;}
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.GetType());

            Console.ReadKey();
        }
    }
}
