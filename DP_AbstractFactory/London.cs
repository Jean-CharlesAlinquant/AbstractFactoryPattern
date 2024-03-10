namespace DesignPatters.Factories.AbstractFactory;

// ConcreteProductB1
public class London : ICapitalCity
{
    public int GetPopulation()
    {
        return 8_900_000;
    }

    public List<string> ListTopAttractions()
    {
        return new List<string> { "Tower Bridge", "Buckingham Palace", "Big Ben" };
    }
}
