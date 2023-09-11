using ECommerce.Model;
using ECommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerce.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new();
        int id = 0;
        public void Cadastrar(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine($"O produto de ID {produto.GetId()} foi criado com sucesso!");
        }
        public void ListarTodos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }
        public void ProcurarPorId(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
                produto.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto de ID {id} não foi encontrado!");
                Console.ResetColor();
            }
        }
        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);
            if (produto is not null)
            {
                if (listaProdutos.Remove(produto) == true)
                {
                    Console.WriteLine($"O produto de ID {id} foi apagado com sucesso!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O produto de ID {id} não foi encontrado!");
                    Console.ResetColor();
                }
            }
        }
        public void Atualizar(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.GetId());

            if (buscaProduto is not null)
            {
                var index = listaProdutos.IndexOf(buscaProduto);

                listaProdutos[index] = produto;

                Console.WriteLine($"O produto de ID {produto.GetId()} foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto de ID {produto.GetId()} não foi encontrado!");
                Console.ResetColor();
            }

        } 
        public int GerarId()
        {
            return ++id;
        }
        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        } 
    } 
}
