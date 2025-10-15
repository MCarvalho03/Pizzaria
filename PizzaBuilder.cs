using Pizzaria.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaBuilder: IBuilder
    {
        /*
            Coisas para melhorar:
                * Métodos devem retornar PizzaBuilder ou seja ( return this) 
                  assim voce pode encadear uma sequencia de chamadas
                * Objeto do tipo pizza so deve ser criado quando for 
                  chamado o método build que ce chamou de getPizza (em teoria)
                  na prática você cria uma pizza quando o PizzaBuilder for criado 
                  e sempre que o método build for chamado voce vai
                        - Salvar _pizza em uma outra variavel auxiliar
                        - criar uma nova pizza dentro de builder, assim quando o builder 
                          for chamado novamente voce não ta alterando os valores da pizza anterior
                        - retorna a pizza que está na variavel auxiliar 
                * Outra coisa que eu faria, usaria uma lista de sabores em vez de ter 3 fixos, 
                  assim voce consegue ter mais flexibilidade no pedido e o setTaste se torna o addTaste
                * O uso seria da seguinte forma 
                    ex: PizzaBuilder builder = new();
                    builder.SetEdge("catupiry")
                           .SetSize("Média")
                           .AddTaste("catupiry")
                           .AddTaste("Milho")
                           .AddTaste("Soja")
                           .Build();
              
               
        */
        Pizza lista = new Pizza();

        private Pizza pizza = new Pizza();
        public PizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public void SetTaste(string taste)
        {
            lista.Sabor.Add(taste);
        }

        public void SetEdge(SaborBorda edge) 
        {
            pizza.SaborBorda = edge;
        }

        public void SetSize(Tamanho size)
        {
            pizza.Tamanho = size;
        }

        public Pizza GetPizza()
        {
            var aux = pizza;
            return aux;
        }
    }
}
