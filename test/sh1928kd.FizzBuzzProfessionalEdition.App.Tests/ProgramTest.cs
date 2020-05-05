using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sh1928kd.FizzBuzzProfessionalEdition.App.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [DataTestMethod]
        [DataRow()]
        [TestCategory("Main()")]
        [TestCategory("Positives")]
        public void Main_PositivePattern()
        {
            Assert.Fail();
        }

        [DataTestMethod]
        [DataRow()]
        [TestCategory("Main()")]
        [TestCategory("Alternatives")]
        public void Main_AlternativePattern()
        {
            Assert.Fail();
        }

        [DataTestMethod]
        [DataRow()]
        [TestCategory("Main()")]
        [TestCategory("Negatives")]
        public void Main_NegativesPattern()
        {
            Assert.Fail();
        }
    }
}
