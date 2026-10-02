using HelloWorld;

var greeter = new Greeter();
var name = args.Length > 0 ? args[0] : string.Empty;
Console.WriteLine(greeter.Greet(name));
