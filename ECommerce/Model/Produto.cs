using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public abstract class Produto
    {
        private int id;
        private int tipoDeArranjo;
        private string flor = string.Empty;
        private decimal valor;

        public Produto(int id, int tipoDeArranjo, string flor, decimal valor)
        {
            this.id = id;
            this.tipoDeArranjo = tipoDeArranjo;
            this.flor = flor;
            this.valor = valor;
        }

        public Produto() { }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetTipoDeArranjo()
        {
            return tipoDeArranjo;
        }

        public void SetTipoDeArranjo(int tipoDeArranjo)
        {
            this.tipoDeArranjo = tipoDeArranjo;
        }


        public string GetFlor()
        {
            return flor;
        }

        public void SetFlor(string flor)
        {
            this.flor = flor;
        }

        public decimal GetValor()
        {
            return valor;
        }

        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }
        
        public virtual void Visualizar()
        {
            string tipoDeArranjo = string.Empty;

            switch (this.tipoDeArranjo)
            {
                case 1:
                    tipoDeArranjo = "Arranjo Boho";
                    break;

                case 2:
                    tipoDeArranjo = "Arranjo Vegetativo";
                    break;
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine("        Detalhes do pedido         ");
            Console.WriteLine("===================================");
            Console.WriteLine($"ID do produto: {this.id}");
            Console.WriteLine($"Nome da flor: {this.flor}");
            Console.WriteLine($"Tipo da de arranjo: {this.tipoDeArranjo}");
            Console.WriteLine($"Valor do produto: " + (this.valor).ToString("C"));
        }
    }
}
