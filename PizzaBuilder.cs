using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaBuilder: IBuilder
    {
        private Pizza _pizza = new Pizza();

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void SetTaste(string taste, string tast2, string tast3)
        {
            _pizza.Sabor = $"{taste}, {tast2}, {tast3}";
        }

        public void SetEdge(string edge) 
        {
            _pizza.SaborBorda = edge;
        }

        public void SetSize(string size)
        {
            _pizza.Tamanho = size;
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
