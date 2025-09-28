using Pizzaria;

var director = new PizzaDirector();

var makePizza = new PizzaBuilder();

director.Pizza3Taste(makePizza);
Pizza pizza = makePizza.GetPizza();
Console.WriteLine(pizza);