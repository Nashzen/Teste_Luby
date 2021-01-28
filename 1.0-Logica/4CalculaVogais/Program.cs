using System;

namespace _4CalculaVogais
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Escreva uma frase para contar as vogais: ");
         var frase = Console.ReadLine();
         CalculaVogais(frase);
      }

      public static void CalculaVogais(string frase)
      {
         Console.Clear();
         char[] fraseArray = frase.ToCharArray();
         var contador = 0;
         int quantidadeDeVogais = 0;

         foreach (char letra in fraseArray)
         {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
               quantidadeDeVogais++;
            }
         }

         Console.WriteLine($"Quantidade de vogais: {quantidadeDeVogais}");

      }
   }
}
