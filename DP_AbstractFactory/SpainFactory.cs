namespace DesignPatters.Factories.AbstractFactory;

// ConcreteFactory2
public class SpainFactory : IInternationalFactory
{
    public ICapitalCity CreateCapital()
    {
        return new Madrid();
    }

    public ILanguage CreateLanguage()
    {
        return new Spanish();
    }
}
