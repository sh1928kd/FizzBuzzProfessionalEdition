using System;
using sh1928kd.FizzBuzzProfessionalEdition.Model;

namespace sh1928kd.FizzBuzzProfessionalEdition.Core
{
    public static class FizzBuzzStyle
    {
        public static void BuildSimpleFizzBuzzRule(FizzBuzzDelegate fizzbuzz)
        {
            AddRule(fizzbuzz.Interactor, 1, n => n % 15u == 0 ? "FizzBuzz" : null);
            AddRule(fizzbuzz.Interactor, 2, n => n % 3u == 0 ? "Fizz" : null);
            AddRule(fizzbuzz.Interactor, 3, n => n % 5u == 0 ? "Buzz" : null);
        }

        private static void AddRule(IFizzBuzzInteractor interactor, uint priority, Func<uint, string> rule)
        {
            interactor.Handle(new PriorityFizzBuzzRule(priority, new FizzBuzzRule(rule)));
        }
    }
}
