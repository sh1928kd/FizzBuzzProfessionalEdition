using System;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model
{
    public class FizzBuzzRule
    {
        private readonly Func<uint, string> Rule;

        public FizzBuzzRule(Func<uint, string> rule)
        {
            Rule = rule;
        }

        public string Answer(uint v)
        {
            return Rule(v);
        }
    }
}
