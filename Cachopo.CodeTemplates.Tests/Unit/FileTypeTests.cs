namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    [Category(Category.Unit)]
    public class FileTypeTests
    {
        private readonly string _validExtension = ".html";

        [Test]
        public void Construction_NullFormatter_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new FileType(_validExtension, null));
        }

        [Test]
        public void Construction_InvalidExtension_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FileType("_..html", new CsharpDefaultFormatter()));
        }

        [Test]
        public void Construction_Properties_Sets_Properly()
        {
            var formatter = new CsharpDefaultFormatter();
            var file = new FileType(_validExtension, formatter);
            Assert.AreEqual(_validExtension, file.Extension);
            Assert.AreEqual(formatter, file.Formatter);
        }
    }
}
