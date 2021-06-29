using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos patinhos foram passear? ");
            int patinho=Convert.ToInt32(Console.ReadLine());

            
            
            for (int i = patinho; i >1 ; i=i-1)
            {
               Console.WriteLine(i + " patinhos foram passear"); 
               Console.WriteLine("além das montanhas");
               Console.WriteLine("para brincar"); 
               Console.WriteLine("a mamãe gritou: Quá, quá, quá, quá");
               Console.WriteLine("mas só " +(i-1)+ " patinhos voltaram de lá.\n");

            }

               Console.WriteLine("A mamãe patinha foi procurar");
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Na beira do mar");
                Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
                Console.WriteLine("E os "+patinho+" patinhos voltaram de lá.");
        }
    }
}
