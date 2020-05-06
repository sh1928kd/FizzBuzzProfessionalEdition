using System;
using sh1928kd.FizzBuzzProfessionalEdition.Model;

namespace sh1928kd.FizzBuzzProfessionalEdition.Core
{
    public static class FizzBuzzStyle
    {
        public static void BuildSimpleFizzBuzzRule(FizzBuzzDelegate fizzbuzz)
        {
            AddRule(fizzbuzz.Interactor, 1u, n => n % 15u == 0 ? "FizzBuzz" : null);
            AddRule(fizzbuzz.Interactor, 2u, n => n % 3u == 0 ? "Fizz" : null);
            AddRule(fizzbuzz.Interactor, 3u, n => n % 5u == 0 ? "Buzz" : null);
        }

        private static void AddRule(IFizzBuzzInteractor interactor, uint priority, Func<uint, string> rule)
        {
            interactor.Handle(new PriorityFizzBuzzRule(priority, new FizzBuzzRule(rule)));
        }
    }
}
