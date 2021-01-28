using System;
using System.Collections.Generic;

namespace _8BuscarPessoa
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] vetor = new string[] {
            "John Doe",
            "Jane Doe",
            "Alice Jones",
            "Bobby Louis",
            "Lisa Romero"
        };

         Console.WriteLine("Procure algo no vetor: ");
         string filtro = Console.ReadLine();
         filtro = filtro.ToLower(); //filtro convertido para letras minusculas para englobar mais possibilidades de pesquisa

         BuscaPessoa(vetor, filtro);
      }

      public static void BuscaPessoa(string[] vetor, string filtro)
      {
         Console.Clear();
         List<string> listaNomes = new List<string>(); //Lista em que os nomes correspondentes ao filtro serao armazenados

         foreach (var item in vetor) // filtrar os itens que contem o filtro digitado
         {
            if (item.ToLower().Contains(filtro))
            {
               listaNomes.Add(item);
            }
         }
         string[] arrayFiltrado = listaNomes.ToArray();
         Console.WriteLine(string.Format("Lista com apenas os pares: [{0}].", string.Join(", ", arrayFiltrado)));
      }
   }
}
