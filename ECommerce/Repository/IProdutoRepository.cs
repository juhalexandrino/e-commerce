using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository
{
    public interface IProdutoRepository
    {
        public void Cadastrar(Produto produto);
        public void ListarTodos();
        public void ProcurarPorId(int id);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
