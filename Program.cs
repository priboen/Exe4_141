using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_141
{
    class Stack
    {
        private string[] adri;
        private int top;
        private int max;

        public Stack(int size)
        {
            adri = new string[size];
            top = -1;
            max = size;
        }

        public void Push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Kosong");
                return;
            }
            else
            {
                Console.WriteLine("Masukan element : ");
                adri[++top] = Console.ReadLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
