using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizza
    {
        public string Sabor { get; set; }
        public string Tamanho { get; set; }
        public string SaborBorda {  get; set; }

        public override string ToString()
        {
            return $"Pizza:\nTamanho: {Tamanho}, \nSabores: {Sabor} " +
                $"\nBorda de {SaborBorda}";
        }
    }
}
