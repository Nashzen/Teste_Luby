using System;

namespace _2CalculaPremio
{
   class Program
   {
      static void Main(string[] args)
      {
         Menu();
      }


      static void Menu()
      {
         Console.Clear();

         Console.WriteLine("Digite o valor do premio: ");
         var valorPremio = double.Parse(Console.ReadLine());
         if (valorPremio <= 0)
         {
            Menu();
            Console.WriteLine("O valor do premio nao pode ser igual ou menor a zero.");
         }

         Console.WriteLine("Selecione seu multiplicador de premio (Caso nao informe nada, o padrao sera 1x):");
         Console.WriteLine("1 - Basic (1x)");
         Console.WriteLine("2 - Vip (1.2x)");
         Console.WriteLine("3 - Premium (1.5x)");
         Console.WriteLine("4 - Deluxe (1.8x)");
         Console.WriteLine("5 - Special (2x)");
         Console.WriteLine("---------------------");

         double multiplicador = double.Parse(Console.ReadLine());

         switch (multiplicador)
         {
            case 1: multiplicador = 1; break;
            case 2: multiplicador = 1.2; break;
            case 3: multiplicador = 1.5; break;
            case 4: multiplicador = 1.8; break;
            case 5: multiplicador = 2; break;
            default: multiplicador = 1; break;
         }

         Console.WriteLine("Deseja adicionar um multiplicador customizado? Caso sim, informe-o, caso nao, aperte ENTER.");
         var multiplicadorOpcional = Console.ReadLine();
         double? multiplicadorConvertido = null;
         if (!string.IsNullOrEmpty(multiplicadorOpcional))
         {
            multiplicadorOpcional = null;
         }
         else
         {
            multiplicadorConvertido = Convert.ToDouble(multiplicadorOpcional);
         }

         CalculaPremio(valorPremio, multiplicador, multiplicadorConvertido);
      }

      static void CalculaPremio(double? valorPremio, double tipoPremio, double? multiplicadorOpcional)
      {

         if (multiplicadorOpcional.HasValue)
         {
            valorPremio = valorPremio * multiplicadorOpcional;
            Console.WriteLine($"Valor total do premio: {valorPremio}");
         }
         else
         {
            valorPremio = valorPremio * tipoPremio;
            Console.WriteLine($"Valor total do premio: {valorPremio}");
         }


      }

   }
}
