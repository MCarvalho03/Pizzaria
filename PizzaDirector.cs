using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaDirector
    {
        private IBuilder _builder;

        public PizzaDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void buildingPizza(string taste, string tast2, string tast3, string edge, string size)
        {
            //_builder.Reset();
            _builder.SetTaste(taste, tast2, tast3);
            _builder.SetEdge(edge);
            _builder.SetSize(size);
        }
        /*public void Pizza3Taste(IBuilder builder)
        {
            builder.Reset();
            builder.SetTaste("Queijo", "Manjericão", "Calabresa");
            builder.SetEdge("Cheddar");
            builder.SetSize("Pequena");
        }*/
    }
}
