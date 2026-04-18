using MathCalcs.Inventory.InventoryManager;
using System;
using System.Globalization;

namespace MathCalcs.Inventory.InventoryManager
{
    public static class InventoryManager
    {
        public static void VerificaEstoque()
        {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
