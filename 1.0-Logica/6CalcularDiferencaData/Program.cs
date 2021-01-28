using System;

namespace _6CalcularDiferencaData
{
   class Program
   {
      static void Main(string[] args)
      {

         Console.WriteLine("Escreva a primeira data, em uma string sem espaços (Ex: '12021999'): ");
         var data1 = Console.ReadLine();
         Console.WriteLine("Escreva a segunda data, em uma string sem espaços (Ex: '12021999'): ");
         var data2 = Console.ReadLine();

         CalcularDiferencaData(data1, data2);
      }

      public static void CalcularDiferencaData(string data1, string data2)
      {
         data1 = data1.Insert(2, "/").Insert(5, "/");
         data2 = data2.Insert(2, "/").Insert(5, "/");

         var data1Convertida = Convert.ToDateTime(data1);
         var data2Convertida = Convert.ToDateTime(data2);

         var diasDeDiferenca = (data2Convertida - data1Convertida).TotalDays;

         Console.WriteLine($"A diferença de dias entre {data1} , {data2} é: {diasDeDiferenca}");
      }
   }
}
