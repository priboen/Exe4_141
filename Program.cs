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
                Console.Write("Masukan element : ");
                adri[++top] = Console.ReadLine();
            }
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Kosong");
                return;
            }
            else
            {
                Console.Write("Masukan element : ");
                top--;
                return;
            }
        }

        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Kosong");
                return;
            }
            else
            {
                for (int i = 0; i < adri.Length; i++)
                {
                    Console.WriteLine(adri[i]);
                }
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
