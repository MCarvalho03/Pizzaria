using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public interface IBuilder
    {
        //void Reset();
        void SetTaste(string taste, string tast2, string tast3);
        void SetEdge(string edge);
        void SetSize(string size);
    }
}