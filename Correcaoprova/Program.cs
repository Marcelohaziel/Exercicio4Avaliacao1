using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcaoprova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String nomeProduto;
                int quantidade;
                double valorProduto, valorTotal;

                Console.WriteLine("***********Exercicio 4 - Avaliação 1 *************");
                Console.WriteLine();

                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade :");
                quantidade = Convert.ToInt32(Console.ReadLine());

                valorTotal = quantidade * valorProduto;

                Console.Clear();
                Console.WriteLine(" ######### Venda de Produtos #########");
                Console.WriteLine("Produto: " + nomeProduto);
                Console.WriteLine("Qtde: " + quantidade + "x Valor Unitário:" + valorProduto);
                //.ToString()- converte o número para texto, o "C" formata para moeda.
                Console.WriteLine("Total de Venda: " + valorTotal.ToString("C"));
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Digite corretamente");
            }
            Console.ReadKey();
            }
        }
    }

