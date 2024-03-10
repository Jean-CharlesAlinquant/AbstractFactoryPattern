// The Abstract Factory pattern provides an interface for creating families
// of related objects without specifying their concrete classes.

using DesignPatters.Factories.AbstractFactory;

Country country = Country.ENGLAND;
ILanguage language = InternationalProvider.CreateLanguage(country);
ICapitalCity capital = InternationalProvider.CreateCapital(country);

Console.WriteLine(country);
Console.WriteLine(capital.GetType().Name);
language.Greet();
Console.WriteLine("Total Population: " + capital.GetPopulation());
Console.WriteLine("Top Attractions: " + string.Join(", ", capital.ListTopAttractions()));
