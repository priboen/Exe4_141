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
                Console.Write("Element yang di Popped : " + adri[top] );
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
                Console.WriteLine("Element yang tersedia : ");
                for (int i = 0; i < adri.Length; i++)
                {
                    Console.Write("\n" + adri[i]);
                }
                Console.WriteLine("\nTekan 'Enter' untuk melanjutkan Program");
                Console.ReadKey();
                
            }
        }
        static void Main(string[] args)
        {
            Stack st = new Stack(39);
            while (true)
            {
                
                Console.WriteLine();
                Console.WriteLine("***Stack Menu***");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\n Enter your choice : ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "o" : input);

                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        st.Push();
                        break;
                    case '2':
                        Console.Clear();
                        st.Pop();
                        break;
                    case '3':
                        Console.Clear();
                        st.Display();
                        break;
                    case '4':
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Masukan Angka yang terdapat pada menu!");
                        break;
                }
            }
        }
    }
}
