// See https://aka.ms/new-console-template for more information

using GreetingKata.Handlers;
using GreetingKata.services;

// Crear manejadores
var nullHandler = new NullNameHandler();
var shoutingHandler = new ShoutingNameHandler();
var twoNameHandler = new TwoNameHandler();
var multipleNameHandler = new MultipleNameHandler();
var escapedCommaHandler = new EscapedCommaHandler();
var simpleNameHandler = new SimpleNameHandler(); // Agregar manejador para nombres simples

nullHandler.SetNext(shoutingHandler);
shoutingHandler.SetNext(twoNameHandler);
twoNameHandler.SetNext(multipleNameHandler);
multipleNameHandler.SetNext(escapedCommaHandler);
escapedCommaHandler.SetNext(simpleNameHandler); // Conectar manejador de nombres simples

var greetingService = new GreetingService(nullHandler);

// Ejemplo de uso
Console.WriteLine(greetingService.Greet("Bob")); // "Hello, Bob."
Console.WriteLine(greetingService.Greet(null)); // "Hello, my friend."
Console.WriteLine(greetingService.Greet("JERRY")); // "HELLO JERRY!"
Console.WriteLine(greetingService.Greet("Jill", "Jane")); // "Hello, Jill and Jane."
Console.WriteLine(greetingService.Greet("Amy", "Brian", "Charlotte")); // "Hello, Amy, Brian, and Charlotte."
Console.WriteLine(greetingService.Greet("Bob", "\"Charlie, Dianne\"")); // "Hello, Bob and Charlie, Dianne."