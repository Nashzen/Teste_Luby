using System;
using System.Collections.Generic;
using System.Linq;

namespace _9TransformarEmMatriz
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Informe uma string de numeros separados por virgula:");
         var numeros = Console.ReadLine();

         TransformarMatriz(numeros);
      }

      public static void TransformarMatriz(string numeros)
      {
         //Separar a string de numeros pelas virgulas em uma lista
         var numerosDivididos = numeros.Split(",");

         //Lista que recebera as strings convertidas em int
         List<int> listaNumerosDivididos = new List<int>();

         foreach (var item in numerosDivididos)
         {
            listaNumerosDivididos.Add(int.Parse(item));
         }

         int[] arrayComInts = listaNumerosDivididos.ToArray();

         //JaggedArray que recebe todos os valores dentro do arrayComInts, e os agrupa a cada dois numeros
         int[][] arrayDeArrays = arrayComInts.Select((valor, index) => new { Value = valor, Index = index })
                    .GroupBy(x => x.Index / 2)
                    .Select(grp => grp.Select(x => x.Value).ToArray())
                    .ToArray();

         for (int i = 0; i < arrayDeArrays.Length; i++)
         {
            foreach (var item in arrayDeArrays[i])
               Console.WriteLine("Array{0}: {1}", i, item);
         }
      }
   }
}
