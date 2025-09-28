using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaDirector
    {
        public void Pizza3Taste(IBuilder builder)
        {
            builder.Reset();
            builder.SetTaste("Queijo", "Manjericão", "Calabresa");
            builder.SetEdge("Cheddar");
            builder.SetSize("Pequena");
        }
    }
}
