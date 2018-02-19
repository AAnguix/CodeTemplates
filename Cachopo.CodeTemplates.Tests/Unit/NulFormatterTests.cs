namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;

    [TestFixture]
    [Category(Category.Unit)]
    class NulFormatterTests
    {
        [Test]
        public void Format_ReturnsSameCode()
        {
            string code = "using System; using System.IO; namespaces Test {}";
            var nullFormatter = new NullFormatter();
            var formattedCode = nullFormatter.Format(code);
            Assert.AreEqual(code, formattedCode, "The formatted code should be the same as the code.");
        }
    }
}
