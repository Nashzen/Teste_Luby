using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.model
{
    public class BebidaModel
    {
        public BebidaModel() { }
        
        public BebidaModel(int id, string nome, double valor, int qtdEstoque, int qtdVendido)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            QtdEstoque = qtdEstoque;
            QtdVendido = qtdVendido; 
        }   

        public int Id { get; set; }
        public string Nome { get; set; }

        public double Valor { get; set; }

        public int QtdEstoque { get; set; }

        public int QtdVendido { get; set; }

        public static List<BebidaModel> listaBebidas = new List<BebidaModel>
        {
            new BebidaModel(1, "Coca-Cola", 3.00, 10, 0),
            new BebidaModel(2, "Pepsi", 2.50, 2, 0),
            new BebidaModel(3, "Guarana Antartica", 2.50, 5, 0),
            new BebidaModel(4, "Fanta Uva", 2.25, 15, 0),
            new BebidaModel(5, "Fanta Laranja", 2.25, 0, 0),
        }; //Lista global utilizada   

    }

}
