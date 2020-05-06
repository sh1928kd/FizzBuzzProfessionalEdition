using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model.Tests
{
    [TestClass]
    public class FizzBuzzConverterTest
    {
        private static IEnumerable<object[]> TestData4SinglesRule()
        {
            var rules = new List<PriorityFizzBuzzRule>
            {
                new PriorityFizzBuzzRule(1, new FizzBuzzRule(n => n % 3u == 0u ? "Fizz" : null)),
            };

            yield return new object[] { rules, 1u, "1" };
            yield return new object[] { rules, 2u, "2" };
            yield return new object[] { rules, 3u, "Fizz" };
            yield return new object[] { rules, 4u, "4" };
            yield return new object[] { rules, 5u, "5" };
            yield return new object[] { rules, 6u, "Fizz" };
            yield return new object[] { rules, 7u, "7" };
            yield return new object[] { rules, 10u, "10" };
            yield return new object[] { rules, 11u, "11" };
            yield return new object[] { rules, 15u, "Fizz" };
            yield return new object[] { rules, 16u, "16" };
            yield return new object[] { rules, 30u, "Fizz" };
            yield return new object[] { rules, 31u, "31" };
        }

        [DataTestMethod()]
        [DynamicData(nameof(TestData4SinglesRule), DynamicDataSourceType.Method)]
        [TestCategory("Convert()")]
        public void Convert_SinglesRule(List<PriorityFizzBuzzRule> rules, uint input, string expect)
        {
            var target = new FizzBuzzConverter();
            foreach (var rule in rules)
            {
                target.Handle(rule);
            }

            target.Convert(input).Is(expect);
        }

        private static IEnumerable<object[]> TestData4DoublesRule()
        {
            var rules = new List<PriorityFizzBuzzRule>
            {
                new PriorityFizzBuzzRule(1, new FizzBuzzRule(n => n % 3u == 0u ? "Fizz" : null)),
                new PriorityFizzBuzzRule(2, new FizzBuzzRule(n => n % 5u == 0u ? "Buzz" : null)),
            };

            yield return new object[] { rules, 1u, "1" };
            yield return new object[] { rules, 2u, "2" };
            yield return new object[] { rules, 3u, "Fizz" };
            yield return new object[] { rules, 4u, "4" };
            yield return new object[] { rules, 5u, "Buzz" };
            yield return new object[] { rules, 6u, "Fizz" };
            yield return new object[] { rules, 7u, "7" };
            yield return new object[] { rules, 10u, "Buzz" };
            yield return new object[] { rules, 11u, "11" };
            yield return new object[] { rules, 15u, "Fizz" };
            yield return new object[] { rules, 16u, "16" };
            yield return new object[] { rules, 30u, "Fizz" };
            yield return new object[] { rules, 31u, "31" };
        }

        [DataTestMethod()]
        [DynamicData(nameof(TestData4DoublesRule), DynamicDataSourceType.Method)]
        [TestCategory("Convert()")]
        public void Convert_DoublesRule(List<PriorityFizzBuzzRule> rules, uint input, string expect)
        {
            var target = new FizzBuzzConverter();
            foreach (var rule in rules)
            {
                target.Handle(rule);
            }

            target.Convert(input).Is(expect);
        }

        private static IEnumerable<object[]> TestData4TriplesRule()
        {
            var rules = new List<PriorityFizzBuzzRule>
            {
                new PriorityFizzBuzzRule(1, new FizzBuzzRule(n => n % 15u == 0u ? "FizzBuzz" : null)),
                new PriorityFizzBuzzRule(2, new FizzBuzzRule(n => n % 3u == 0u ? "Fizz" : null)),
                new PriorityFizzBuzzRule(3, new FizzBuzzRule(n => n % 5u == 0u ? "Buzz" : null)),
            };

            yield return new object[] { rules, 1u, "1" };
            yield return new object[] { rules, 2u, "2" };
            yield return new object[] { rules, 3u, "Fizz" };
            yield return new object[] { rules, 4u, "4" };
            yield return new object[] { rules, 5u, "Buzz" };
            yield return new object[] { rules, 6u, "Fizz" };
            yield return new object[] { rules, 7u, "7" };
            yield return new object[] { rules, 10u, "Buzz" };
            yield return new object[] { rules, 11u, "11" };
            yield return new object[] { rules, 15u, "FizzBuzz" };
            yield return new object[] { rules, 16u, "16" };
            yield return new object[] { rules, 30u, "FizzBuzz" };
            yield return new object[] { rules, 31u, "31" };
        }

        [DataTestMethod()]
        [DynamicData(nameof(TestData4TriplesRule), DynamicDataSourceType.Method)]
        [TestCategory("Convert()")]
        public void Convert_TriplesRule(List<PriorityFizzBuzzRule> rules, uint input, string expect)
        {
            var target = new FizzBuzzConverter();
            foreach (var rule in rules)
            {
                target.Handle(rule);
            }

            target.Convert(input).Is(expect);
        }

        private static IEnumerable<object[]> TestData4EmptyStringRule()
        {
            var rules = new List<PriorityFizzBuzzRule>
            {
                new PriorityFizzBuzzRule(1, new FizzBuzzRule(n => n.ToString().Contains("1") ? "" : null)),
                new PriorityFizzBuzzRule(2, new FizzBuzzRule(n => n % 15u == 0u ? "FizzBuzz" : null)),
                new PriorityFizzBuzzRule(3, new FizzBuzzRule(n => n % 3u == 0u ? "Fizz" : null)),
                new PriorityFizzBuzzRule(4, new FizzBuzzRule(n => n % 5u == 0u ? "Buzz" : null)),
            };

            yield return new object[] { rules, 1u, "" };
            yield return new object[] { rules, 2u, "2" };
            yield return new object[] { rules, 3u, "Fizz" };
            yield return new object[] { rules, 4u, "4" };
            yield return new object[] { rules, 5u, "Buzz" };
            yield return new object[] { rules, 6u, "Fizz" };
            yield return new object[] { rules, 7u, "7" };
            yield return new object[] { rules, 10u, "" };
            yield return new object[] { rules, 11u, "" };
            yield return new object[] { rules, 15u, "" };
            yield return new object[] { rules, 16u, "" };
            yield return new object[] { rules, 30u, "FizzBuzz" };
            yield return new object[] { rules, 31u, "" };
        }

        [DataTestMethod()]
        [DynamicData(nameof(TestData4TriplesRule), DynamicDataSourceType.Method)]
        [TestCategory("Convert()")]
        public void Convert_EmptyStringRule(List<PriorityFizzBuzzRule> rules, uint input, string expect)
        {
            var target = new FizzBuzzConverter();
            foreach (var rule in rules)
            {
                target.Handle(rule);
            }

            target.Convert(input).Is(expect);
        }
    }
}
