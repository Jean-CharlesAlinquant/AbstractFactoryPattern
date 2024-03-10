namespace DesignPatters.Factories.AbstractFactory;

// ConcreteProductA1
public class English : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
}
