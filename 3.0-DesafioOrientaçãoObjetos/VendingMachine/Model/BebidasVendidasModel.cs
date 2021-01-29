using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.model
{
    public class BebidasVendidasModel
    {
        public BebidasVendidasModel() { }

        public BebidasVendidasModel(int qtdVendido, string nome)
        {
            QtdVendido = qtdVendido;
            Nome = nome;
        }

        public int QtdVendido { get; set; }
        public string Nome { get; set; }
 
        public static List<BebidasVendidasModel> listaBebidasVendidas = new List<BebidasVendidasModel>(); //Lista global utilizada para display de bebidas vendidas
    }

}
