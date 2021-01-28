using System;
using System.Collections.Generic;

namespace _7ObterParesVetor
{
   class Program
   {
      static void Main(string[] args)
      {
         List<int> listaNumeros = new List<int>(); //lista que recebe os numeros informados

         int auxiliarNumeroInformado = 1; // Var auxiliar que sera utilizada para fechar o loop quando necessario

         while (auxiliarNumeroInformado != 0)
         {
            Console.WriteLine("Adicione um numero no array (Digite zero caso queira fechar o array): ");
            int numero = Convert.ToInt32(Console.ReadLine());
            auxiliarNumeroInformado = numero;
            listaNumeros.Add(numero);
         }
         int[] arrayDeNumeros = listaNumeros.ToArray();
         Array.Resize(ref arrayDeNumeros, arrayDeNumeros.Length - 1); //Redimensionar o array para remover o Zero que serviu como Break do loop

         ObterPares(arrayDeNumeros);
      }

      public static void ObterPares(int[] numeros)
      {
         Console.Clear();
         List<int> listaApenasPares = new List<int>();
         foreach (var item in numeros)
         {
            if (item % 2 == 0) //Caso o resto da divisao for 2, adicionar na lista de numeros pares
            {
               listaApenasPares.Add(item);
            }
         }
         int[] arrayApenasPares = listaApenasPares.ToArray(); //transformar a lista dos pares em um array
         Console.WriteLine(string.Format("Lista original: ({0}).", string.Join(", ", numeros)));
         Console.WriteLine(string.Format("Lista com apenas os pares: ({0}).", string.Join(", ", arrayApenasPares)));
      }



   }
}
