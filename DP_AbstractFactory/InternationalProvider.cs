namespace DesignPatters.Factories.AbstractFactory;

public class InternationalProvider
{
    public static ILanguage CreateLanguage(Country country)
    {
        switch (country)
        {
            case Country.ENGLAND:
                return new English();

            case Country.SPAIN:
                return new Spanish();

            default:
                throw new InvalidOperationException($"Country invalid {country}!");
        }
    }

    public static ICapitalCity CreateCapital(Country country)
    {
        switch (country)
        {
            case Country.ENGLAND:
                return new London();

            case Country.SPAIN:
                return new Madrid();

            default:
                throw new InvalidOperationException($"Country invalid {country}!");
        }
    }
}
