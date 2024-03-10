namespace DesignPatters.Factories.AbstractFactory;
public interface IInternationalFactory
{
    ILanguage CreateLanguage();
    ICapitalCity CreateCapital();
}
