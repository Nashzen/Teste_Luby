using System;
using System.Collections.Generic;
using System.Linq;

namespace _10ObterElementosFaltantes
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
         int[] vetor2 = new int[] { 12, 2, 53 };
         int[] vetor3 = new int[] { 1, 4, 5 };
         int[] vetor4 = new int[] { 12, 2, 3, 24, 5 };
         int[] vetor5 = new int[] { 11, 2, 31, 46 };
         int[] vetor6 = new int[] { 2, 32, 4, 57 };
         int[] vetor7 = new int[] { 1, 3, 4, 5 };
         int[] vetor8 = new int[] { 11, 3, 44, 5 };


         ObterElementosFaltante(vetor1, vetor2);
      }

      public static void ObterElementosFaltante(int[] vetor1, int[] vetor2)
      {
         IEnumerable<int> numerosFaltantes = vetor1.Except(vetor2); // Except traz a diferenca entre dois vetores

         int[] vetorFaltantes = numerosFaltantes.ToArray(); //Adicionar a diferenca em um array

         Console.WriteLine(string.Format("Faltantes: ({0}).", string.Join(", ", vetorFaltantes))); //Escrever a diferenca na tela
      }
   }
}
