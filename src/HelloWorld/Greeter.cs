namespace HelloWorld;

public class Greeter
{
    // TODO: Support localized greetings based on the current culture.
    public string Greet(string name)
    {
        var target = string.IsNullOrWhiteSpace(name) ? "World" : name.Trim();
        return $"Hello, {target}!";
    }
}
