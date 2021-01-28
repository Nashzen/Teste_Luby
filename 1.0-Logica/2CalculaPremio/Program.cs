using System;

namespace _2CalculaPremio
{
   class Program
   {
      static void Main(string[] args)
      {
         Menu();
      }

      public static void Menu()
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

         //condicional para determinar o valor do multiplicador a partir da informacao do usuario
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
         string multiplicadorOpcional = Console.ReadLine();

         //nullable type para cumprir os requisitos do metodo
         double? multiplicadorOpcionalConvertido;

         /*caso o usuario nao informe nada, o metodo segue com o multiplicador do switch, caso ele informe um multiplicador extra, 
         o calculo é feito a partir do multiplicador opcional*/
         if (multiplicadorOpcional == string.Empty)
         {
            CalculaPremio(valorPremio, multiplicador, null);
         }
         else
         {
            multiplicadorOpcionalConvertido = double.Parse(multiplicadorOpcional);
            CalculaPremio(valorPremio, multiplicador, (double)multiplicadorOpcionalConvertido);
         }

      }

      static void CalculaPremio(double valorPremio, double tipoPremio, double? multiplicadorOpcional)
      {

         /*Caso o multiplicador adicional for nulo, o calculo é feito com base no multiplicador do 'tipoPremio'
         senão, é feito à partir do multiplicador do 'multiplicadorOpcional'*/
         if (multiplicadorOpcional == null)
         {
            valorPremio = valorPremio * tipoPremio;
            Console.WriteLine($"Valor total do premio: {valorPremio}");
         }
         else
         {
            valorPremio = valorPremio * (double)multiplicadorOpcional;
            Console.WriteLine($"Valor total do premio: {valorPremio}");
         }
      }

   }
}
