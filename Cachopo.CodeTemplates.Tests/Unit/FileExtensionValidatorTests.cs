namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;

    [TestFixture]
    [Category(Category.Unit)]
    class FileExtensionValidatorTests
    {
        [Test]
        [TestCase(".html")]
        [TestCase(".cs")]
        [TestCase(".test.file.extension")]
        public void IsValid_ReturnsTrue(string fileExtension)
        {
            Assert.IsTrue(FileExtensionValidator.IsValid(fileExtension));
        }

        [Test]
        [TestCase("fileExtension")]
        [TestCase("")]
        [TestCase(null)]
        public void IsValid_ReturnsFalse(string fileExtension)
        {
            Assert.IsFalse(FileExtensionValidator.IsValid(fileExtension));
        }
    }
}
