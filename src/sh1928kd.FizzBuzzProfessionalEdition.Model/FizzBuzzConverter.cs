using System;
using System.Collections.Generic;
using System.Linq;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model
{
    public class FizzBuzzConverter : IFizzBuzzInteractor
    {
        private HashSet<PriorityFizzBuzzRule> PriorityFizzBuzzRules { get; } = new HashSet<PriorityFizzBuzzRule>();

        public void Handle(PriorityFizzBuzzRule rule)
        {
            PriorityFizzBuzzRules.Add(rule);
        }

        public string Convert(uint number)
        {
            foreach (var rule in PriorityFizzBuzzRules.OrderBy(x => x.Priority).Select(x => x.Rule))
            {
                string answer = rule.Answer(number);
                if (answer == null)
                {
                    continue;
                }

                return answer;
            }

            return number.ToString();
        }
    }
}
