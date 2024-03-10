namespace DesignPatters.Factories.AbstractFactory;

// ConcreteProductB2
public class Madrid : ICapitalCity
{
    public int GetPopulation()
    {
        return 3_200_000;
    }

    public List<string> ListTopAttractions()
    {
        return new List<string> { "Royal Palace", "Prado Museum", "Retiro Park" };
    }
}
