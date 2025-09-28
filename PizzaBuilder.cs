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
        ///*
            Coisas para melhorar:
                * Métodos devem retornar PizzaBuilder ou seja ( return this) assim voce pode encadear uma sequencia de chamadas
                * Objeto do tipo pizza so deve ser criado quando for chamado o método build que ce chamou de getPizza (em teoria)
                    na prática você cria uma pizza quando o PizzaBuilder for criado e sempre que o método build for chamado voce vai
                        - Salvar _pizza em uma outra variavel auxiliar
                        - criar uma nova pizza dentro de builder, assim quando o builder for chamado novamente voce não ta alterando os valores da pizza anterior
                        - retorna a pizza que está na variavel auxiliar
                * Outra coisa que eu faria usaria uma lista de sabores em vez de ter 3 fixos, assim voce consegue ter mais flexibilidade no pedido e o setTaste se torna o addTaste
                * O uso seria da seguinte forma 
                    ex: PizzaBuilder builder = new();
                    builder.SetEdge("catupiry")
                           .SetSize("Média")
                           .AddTaste("catupiry")
                           .AddTaste("Milho")
                           .AddTaste("Soja")
                           .Build();
              
               
        *///
        
        public void Reset()
        {
            _pizza = new Pizza();
        }*/

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
