using System;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model
{
    public class PriorityFizzBuzzRule
    {
        public uint Priority { get; }
        public FizzBuzzRule Rule { get; }

        public PriorityFizzBuzzRule(uint priority, FizzBuzzRule rule)
        {
            Priority = priority;
            Rule = rule;
        }
    }
}
