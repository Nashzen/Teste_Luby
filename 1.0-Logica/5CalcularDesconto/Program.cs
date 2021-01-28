using System;

namespace _5CalcularDesconto
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Informe um valor");
         var valor = Console.ReadLine();
         Console.WriteLine("Informe uma porcentagem de desconto");
         var porcentagem = Console.ReadLine();

         CalcularDescontoFormatado(valor, porcentagem);
      }

      public static void CalcularDescontoFormatado(string valor, string porcentagem)
      {
         valor = valor.Replace("R$", "").Replace("R$ ", "");
         porcentagem = porcentagem.Replace("%", "");
         decimal valorConvertido = decimal.Parse(valor);
         decimal porcentagemConvertido = decimal.Parse(porcentagem);

         decimal resultado = valorConvertido - ((valorConvertido / 100) * porcentagemConvertido);

         Console.WriteLine($"{valor} com {porcentagem} de desconto: R$ {resultado}");
      }
   }
}
