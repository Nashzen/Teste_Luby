using System;
using System.Collections.Generic;
using System.Threading;
using VendingMachine.model;
using System.Linq;

namespace VendingMachine
{
    public class Menu
    {        
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("------Menu-------");
            Console.WriteLine("1- Mostrar itens disponíveis para compra");
            Console.WriteLine("2- Comprar");
            Console.WriteLine("3- Visualizar vendas da máquina");
            Console.WriteLine("0- Desligar máquina");
            Console.WriteLine("------Selecione uma das opções abaixo-------");

            int opcaoSelecionada = int.Parse(Console.ReadLine());

            switch (opcaoSelecionada)
            {
                case 1: ListarBebidas(); break;
                case 2: SelecionarBebida(); break;
                case 3: DisplayListaVendidos(); break;
                case 0: System.Environment.Exit(0); break;
                default: MenuPrincipal(); break;
            }
        }

        public static void ListarBebidas()
        {
            Console.Clear();             

            Console.WriteLine("------Bebidas disponiveis-------");
            Console.WriteLine("");
            foreach (var item in BebidaModel.listaBebidas)
            {
                Console.WriteLine($"{item.Nome} / R${item.Valor} / {item.QtdEstoque} em estoque.");
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para retornar ao menu principal");

            var opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)
            {
                default: MenuPrincipal(); break;
            }
        }

        public static void SelecionarBebida() 
        {
            Console.Clear();
            var _listaBebidas = BebidaModel.listaBebidas;

            Console.WriteLine("------Selecione uma bebida-------");
            Console.WriteLine("");
            foreach (var item in BebidaModel.listaBebidas)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} / R${item.Valor}");
            }

            Console.WriteLine("Selecione uma bebida para comprar: ");
            int idBebidaSelecionada = int.Parse(Console.ReadLine());

            BebidaModel bebida = new BebidaModel();

            for (int i = 0; i < _listaBebidas.Count; i++)
            {
                if(idBebidaSelecionada == _listaBebidas[i].Id) 
                {
                    if (_listaBebidas[i].QtdEstoque <= 0) 
                    {
                        Console.WriteLine("Produto indisponivel, retornando a selecao de bebidas, aguarde.");
                        Thread.Sleep(2800);
                        SelecionarBebida();
                    } 
                    else
                    {
                        bebida = _listaBebidas[i];
                    }
                    
                }
            }

            
            VenderBebida(bebida);
            
        }
        public static void VenderBebida(BebidaModel bebida) 
        {
            Console.Clear();
            var _listaBebidas = BebidaModel.listaBebidas;
           
            double troco = 0;

            Console.WriteLine("Adicione o dinheiro na maquina:");
            double dinheiroInserido = double.Parse(Console.ReadLine());

            var auxiliarDinheiroInserido = dinheiroInserido;
                       
            if (auxiliarDinheiroInserido > bebida.Valor) 
            {
                troco = auxiliarDinheiroInserido - bebida.Valor;
                bebida.QtdEstoque--;
                Console.WriteLine($"Obrigado por comprar! Seu troco é R${troco}");
                ListarProdutosVendidos(bebida);
            }
            else
            {
                while (auxiliarDinheiroInserido < bebida.Valor)
                {
                    Console.WriteLine($"Dinheiro insulficiente, adicione mais R${bebida.Valor - auxiliarDinheiroInserido}:");
                    double dinheiroInseridoMaisUmaVez = double.Parse(Console.ReadLine());
                    auxiliarDinheiroInserido += dinheiroInseridoMaisUmaVez;
                    if (auxiliarDinheiroInserido > bebida.Valor)
                    {
                        troco = auxiliarDinheiroInserido - bebida.Valor;
                        bebida.QtdEstoque--;
                        Console.WriteLine($"Obrigado por comprar! Seu troco é R${troco}");                                                
                    }
                }
                bebida.QtdEstoque--;
                ListarProdutosVendidos(bebida);
            }
            Console.WriteLine($"Retornando ao menu principal, aguarde.");
            Thread.Sleep(2800);
            MenuPrincipal();
        }
       
        public static void ListarProdutosVendidos(BebidaModel bebida) 
        {
            var _listaBebidasVendidas = BebidasVendidasModel.listaBebidasVendidas;

            if (_listaBebidasVendidas.Any(i => i.Nome == bebida.Nome)) 
            {
                _listaBebidasVendidas.RemoveAll(x => x.Nome == bebida.Nome);
                _listaBebidasVendidas.Add(new BebidasVendidasModel { Nome = bebida.Nome, QtdVendido = bebida.QtdVendido++});
            }
            else
            {
                _listaBebidasVendidas.Add(new BebidasVendidasModel { Nome = bebida.Nome, QtdVendido = bebida.QtdVendido + 1});
            }          
        }        

        public static void DisplayListaVendidos() 
        {
            Console.Clear();
            var _listaBebidasVendidas = BebidasVendidasModel.listaBebidasVendidas;

            foreach (var item in _listaBebidasVendidas)
            {
                Console.WriteLine($"{item.Nome} Vendidos: {item.QtdVendido}");
            }
            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para retornar ao menu principal");

            var opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)
            {
                default: MenuPrincipal(); break;
            }
        }
    }
}
