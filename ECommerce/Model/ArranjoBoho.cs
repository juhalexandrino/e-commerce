using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    public class ArranjoBoho : Produto
    {
        private string tipoVaso;
        public ArranjoBoho(int id, int tipoDeArranjo, string flor, decimal valor, string tipoVaso) : base(id, tipoDeArranjo, flor, valor)
        {
            this.tipoVaso = tipoVaso;
        }

        public string GetTipoVaso()
        {
            return tipoVaso;
        }

        public void SetTipoVaso(string tipoVaso)
        {
            this.tipoVaso = tipoVaso;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Tipo de vaso: {this.tipoVaso}");
        }
    }
    }
