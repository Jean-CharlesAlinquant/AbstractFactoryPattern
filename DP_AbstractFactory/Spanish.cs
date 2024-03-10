namespace DesignPatters.Factories.AbstractFactory;

// ConcreteProductA2
public class Spanish : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hola!");
    }
}
