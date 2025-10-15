using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria;
using Pizzaria.Enums;

namespace Pizzaria
{
    public interface IBuilder
    {
        void Reset();
        void SetTaste(string taste);
        void SetEdge(SaborBorda edge);
        void SetSize(Tamanho size);
    }
}