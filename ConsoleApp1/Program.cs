Exercicio 3 
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o lado a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado b  ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado c ");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && b < a + c) ;
            {
                Console.WriteLine("" + (a == b && c == b));
            }

        }

    }

}
