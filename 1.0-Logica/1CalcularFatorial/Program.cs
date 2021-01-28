using System;

namespace _1CalcularFatorial
{
   class Program
   {
      static void Main(string[] args)
      {
         CalculaFatorial();
      }

      static void CalculaFatorial()
      {
         int i, numeroSelecionado, fatorial;

         Console.WriteLine("Digite o numero que deseja descobrir o fatorial: ");
         numeroSelecionado = int.Parse(Console.ReadLine());

         fatorial = numeroSelecionado;
         for (i = numeroSelecionado - 1; i >= 1; i--)
         {
            fatorial = fatorial * i;
         }
         Console.WriteLine($"\nFatorial de {numeroSelecionado}: " + fatorial);
      }
   }
}
