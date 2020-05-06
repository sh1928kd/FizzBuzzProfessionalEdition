using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sh1928kd.FizzBuzzProfessionalEdition.Core.Tests
{
    [TestClass]
    public class FizzBuzzDelegateTest
    {
        private static IEnumerable<object[]> TestData4VanillaRule()
        {
            yield return new object[] { 3u, new List<string> { "1", "2", "3" } };
            yield return new object[] { 10u, new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" } };
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData4VanillaRule), DynamicDataSourceType.Method)]
        [TestCategory("GenerateOneFor()")]
        public void GenerateOneFor_VanillaRule(uint input, List<string> except)
        {
            var target = new FizzBuzzDelegate();
            target.GenerateOneFor(input).Is(except);
        }

        private static IEnumerable<object[]> TestData4MultiplesOfThreeRule()
        {
            yield return new object[] { 3u, new List<string> { "1", "2", "Fizz" } };
            yield return new object[] { 10u, new List<string> { "1", "2", "Fizz", "4", "5", "Fizz", "7", "8", "Fizz", "10" } };
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData4MultiplesOfThreeRule), DynamicDataSourceType.Method)]
        [TestCategory("GenerateOneFor()")]
        public void GenerateOneFor_MultiplesOfThreeRule(uint input, List<string> except)
        {
            var target = new FizzBuzzDelegate();
            target.Interactor.Handle(new Model.PriorityFizzBuzzRule(1, new Model.FizzBuzzRule(n => n % 3u == 0 ? "Fizz" : null)));
            target.GenerateOneFor(input).Is(except);
        }
    }
}
