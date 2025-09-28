using Pizzaria;

var makePizza = new PizzaBuilder();
var dir = new PizzaDirector(makePizza);

dir.buildingPizza(taste: "Queijo", tast2: "Napolitana", tast3: "Portuguesa", edge: "Cheddar", size: "Familia");

var p = makePizza.GetPizza();
Console.WriteLine(p);