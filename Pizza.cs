using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizza
    {
        public string Sabor { get; set; }         //Altere para uma lista que contem os sabores
        /* considere também a possibilidade de sabor ser uma struct ou classe que contem uma string com o nome do Sabor e preço
           -mesmo se não fosse usar o preço e Sabor tivesse somente a string como parametro, seria valido encapsular essa string dentro de uma classe porque:
               -voce criar uma abstração para representar o sabor e isso permite que voce crie metodos e validações especificas para aquele tipo
               -ter seu código baseado numa classe que modela o seu problema em vez de uma string que representa somente texto permite que você adicione mais metodos e propriedades depois               
               -em maui ter uma classe especifica para aquilo significa que voce pode criar uma visualização especifica para aquilo (dataTemplate)
        */ 
        public string Tamanho { get; set; }       //Crie opcoes predefinidas de tamanho, sugestão transforme tamanho em um enum
        public string SaborBorda {  get; set; }   //Crie opcoes de sabor, transforme SaborBorda em um enum se for ter sabores fixos ou em uma classe caso deseje ter a possibilidade de criar mais sabores

        public override string ToString()
        {
            return $"Pizza:\nTamanho: {Tamanho}, \nSabores: {Sabor} " +
                $"\nBorda sabor {SaborBorda}";
        }
    }
}
