using System;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model
{
    public interface IFizzBuzzInteractor
    {
        public void Handle(PriorityFizzBuzzRule rule);
    }
}
