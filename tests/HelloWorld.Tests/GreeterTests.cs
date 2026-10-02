namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_WithName_ReturnsPersonalizedGreeting()
    {
        var greeter = new Greeter();

        var greeting = greeter.Greet("Alice");

        Assert.Equal("Hello, Alice!", greeting);
    }
}
