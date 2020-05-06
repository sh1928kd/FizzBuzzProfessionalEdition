using System;
using System.Collections.Generic;
using System.Linq;
using sh1928kd.FizzBuzzProfessionalEdition.Model;

namespace sh1928kd.FizzBuzzProfessionalEdition.Core
{
    public class FizzBuzzDelegate
    {
        private FizzBuzzConverter Converter { get; } = new FizzBuzzConverter();
        public IFizzBuzzInteractor Interactor { get { return Converter; } }

        public List<string> GenerateOneFor(uint max)
        {
            return GenerateForEach(new List<uint>(Enumerable.Range(1, (int)max).Select(x => (uint)x)));
        }

        public List<string> GenerateForEach(List<uint> list)
        {
            return list.Select(number => Converter.Convert(number)).ToList();
        }
    }
}
