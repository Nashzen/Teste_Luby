using System;
using System.Collections.Generic;

namespace _3ContarPrimos
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Digite um numero para descobrir a quantidade de primos: ");
         var numero = int.Parse(Console.ReadLine());
         ContarPrimos(numero);
      }

      public static void ContarPrimos(int numero)
      {
         Console.Clear();
         int[] arrayNumeros = new int[numero]; // Array para armazenar todos os numeros ate o selecionado                  
         var quantidadePrimos = 0;

         List<int> listaApenasPrimos = new List<int>();

         for (int i = 0; i < arrayNumeros.Length; i++)
         {
            arrayNumeros[i] = i + 1; // Adiciona todos os numeros dentro do array contendo todos os numeros ate o intervalo selecionado
         }

         for (int i = 0; i < arrayNumeros.Length; i++)
         {
            if (IsPrimo(arrayNumeros[i]))
            {
               quantidadePrimos++;
               listaApenasPrimos.Add(arrayNumeros[i]);
            }
         }
         int[] arrayApenasPrimos = listaApenasPrimos.ToArray();
         Console.WriteLine($"Quantidade de primos ate {numero}: {quantidadePrimos}");
         Console.WriteLine(string.Format("Todos os primos: ({0}).", string.Join(", ", arrayApenasPrimos)));
      }

      public static bool IsPrimo(int numero) // Metodo para verificar se o numero atual eh primo ou nao
      {
         if (numero <= 1) return false;
         if (numero == 2) return true;
         if (numero % 2 == 0) return false;

         var limite = (int)Math.Floor(Math.Sqrt(numero));

         for (int i = 3; i <= limite; i += 2)
            if (numero % i == 0)
               return false;

         return true;
      }
   }
}
