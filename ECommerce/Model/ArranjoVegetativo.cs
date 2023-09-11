using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public class ArranjoVegetativo : Produto
    {
        private string elementoAdicional;
        public ArranjoVegetativo(int id, int tipoDeArranjo, string flor, decimal valor, string elementoAdicional) : base(id, tipoDeArranjo, flor, valor)
        {
            this.elementoAdicional = elementoAdicional;
        }

        public string GetElementoAdicional()
        {
            return elementoAdicional;
        }

        public void SetElementoAdicional(string elementoAdicional)
        {
            this.elementoAdicional= elementoAdicional;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Elemento adicional: {this.elementoAdicional}");
        }
    }
}
