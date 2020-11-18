using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja ver a tabua de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;
            
            
            
            for (int contador = -1; contador >= 0; contador--)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
                Console.WriteLine(resposta + " * " + contador + " = " + resultado);

            }
            
            // do
            // {
            //     // Executado pelo menos uma vez
            //     Console.WriteLine("Bom dia");

            //     Console.WriteLine("Ainda deseja receber bom dia? ");

            //     numeroDeVezes++;

            //     resposta = Console.ReadLine();

            // } while(resposta == "Sim");            
            
            
            
            // while(resposta == "Sim") {
            //     // Executado quando condição é verdadeira
            //     Console.WriteLine("Bom dia!!");

            //     // numeroDeVezes = numeroDeVezes + 1;                
            //     numeroDeVezes++;                

            //     Console.WriteLine("Ainda deseja receber um bom dia? ");
            //     resposta = Console.ReadLine();
            // }

            // Console.WriteLine($"Numero de vezes: {numeroDeVezes}");
            // Console.WriteLine("Fim do programa");

        }
    }
}
