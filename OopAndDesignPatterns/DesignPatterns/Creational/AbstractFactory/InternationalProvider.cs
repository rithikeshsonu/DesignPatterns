using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    internal class InternationalProvider
    {
        public static ILanguage CreateLanguage(Country country)
        {
            switch(country)
            {
                case Country.England:
                    return new English();

                case Country.Spain:
                    return new Spanish();

                default:
                    throw new InvalidOperationException($"Country: {country} is invalid");
            }
        }
        public static ICapitalCity CreateCapital(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new London();

                case Country.Spain:
                    return new Madrid();

                default:
                    throw new InvalidOperationException($"Country: {country} is invalid");
            }
        }
    }
}
