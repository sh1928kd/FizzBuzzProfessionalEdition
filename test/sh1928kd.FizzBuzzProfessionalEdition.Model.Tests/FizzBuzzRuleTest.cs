using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sh1928kd.FizzBuzzProfessionalEdition.Model.Tests
{
    [TestClass]
    public class FizzBuzzRuleTest
    {
        [DataTestMethod]
        [DataRow("case-01", null, 1u, null)]
        [DataRow("case-02", null, 2u, null)]
        [DataRow("case-03", null, 3u, "case-03")]
        [DataRow("case-04", null, 4u, null)]
        [DataRow("case-05", null, 5u, null)]
        [DataRow("case-06", null, 6u, "case-06")]
        [DataRow("case-07", null, 7u, null)]
        [TestCategory("Answer()")]
        public void Answer_MultipulesOfThree(string positive, string negative, uint input, string expect)
        {
            var target = new FizzBuzzRule(n => n % 3u == 0u ? positive : negative);
            target.Answer(input).Is(expect);
        }

        [DataTestMethod]
        [DataRow("case-01", null, 1u, null)]
        [DataRow("case-02", null, 2u, null)]
        [DataRow("case-03", null, 3u, null)]
        [DataRow("case-04", null, 4u, null)]
        [DataRow("case-05", null, 5u, "case-05")]
        [DataRow("case-06", null, 6u, null)]
        [DataRow("case-07", null, 7u, null)]
        [TestCategory("Answer()")]
        public void Answer_MultipulesOfFive(string positive, string negative, uint input, string expect)
        {
            var target = new FizzBuzzRule(n => n % 5u == 0u ? positive : negative);
            target.Answer(input).Is(expect);
        }

        [DataTestMethod]
        [DataRow("case-01", null, 1u, null)]
        [DataRow("case-02", null, 2u, null)]
        [DataRow("case-03", null, 3u, null)]
        [DataRow("case-04", null, 4u, null)]
        [DataRow("case-05", null, 5u, null)]
        [DataRow("case-06", null, 6u, null)]
        [DataRow("case-07", null, 7u, null)]
        [DataRow("case-15", null, 15u, "case-15")]
        [DataRow("case-16", null, 16u, null)]
        [DataRow("case-30", null, 30u, "case-30")]
        [DataRow("case-31", null, 31u, null)]
        [TestCategory("Answer()")]
        public void Answer_MultipulesOfFifteen(string positive, string negative, uint input, string expect)
        {
            var target = new FizzBuzzRule(n => n % 15u == 0u ? positive : negative);
            target.Answer(input).Is(expect);
        }

        [DataTestMethod]
        [DataRow("case-01", null, 1u, null)]
        [DataRow("case-02", null, 2u, null)]
        [DataRow("case-03", null, 3u, "case-03")]
        [DataRow("case-04", null, 4u, null)]
        [DataRow("case-05", null, 5u, null)]
        [DataRow("case-06", null, 6u, null)]
        [DataRow("case-07", null, 7u, null)]
        [DataRow("case-15", null, 15u, null)]
        [DataRow("case-16", null, 16u, null)]
        [DataRow("case-30", null, 30u, "case-30")]
        [DataRow("case-31", null, 31u, "case-31")]
        [TestCategory("Answer()")]
        public void Answer_ContainsOfThree(string positive, string negative, uint input, string expect)
        {
            var target = new FizzBuzzRule(n => n.ToString().Contains("3") ? positive : negative);
            target.Answer(input).Is(expect);
        }
    }
}
