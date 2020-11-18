using System;

namespace Correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            
            do {
                Console.Write("Digite uma nota entre 0 e 10: ");
                nota = int.Parse(Console.ReadLine());                

            } while(!(nota >= 0 && nota <= 10));   
            // } while(nota < 0 && nota > 10));   

            Console.WriteLine("Número Aceito");
        }
    }   
}


