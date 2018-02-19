namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;
    using static AssertMessages;

    [TestFixture]
    [Category(Category.Unit)]
    class FileTests
    {
        [Test]
        public void Construction_ValuesSetProperly()
        {
            string name = "House";
            string path = "./Buildings";
            var testType = new FileType(".test", new NullFormatter());
            var file = new File("using System;", name, path, testType);

            Assert.AreEqual(name, file.Name, ShouldBeEquals(nameof(file.Name), nameof(name)));
            Assert.AreEqual(path, file.Path, ShouldBeEquals(nameof(file.Path), nameof(path)));
            Assert.AreEqual(testType, file.Type, ShouldBeEquals(nameof(file.Type), nameof(testType)));
        }
    }
}
