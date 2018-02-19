namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;
    using System;
    using static AssertMessages;

    [TestFixture]
    [Category(Category.Unit)]
    class TemplateTests
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Construction_ThrowsArgumentException(string destinationFolder)
        {
            Assert.Throws<ArgumentException>(() => new Template(destinationFolder));
        }

        [Test]
        public void Construction_ValuesSetProperly()
        {
            string destinationFolder = "testDestinationFolder";
            var component = new Template(destinationFolder);

            Assert.AreEqual(destinationFolder, component.DestinationFolder,
                ShouldBeEquals(nameof(component.DestinationFolder), nameof(destinationFolder)));
            Assert.IsNotNull(component.Files, "Files property should be initialized.");
            Assert.AreEqual(0, component.Files.Count, "Component should have any files.");
        }

        [Test]
        public void Add_FileAdded()
        {
            var formatter = new NullFormatter();
            var testType = new FileType(".test", formatter);
            var component = new Template("folder");
            string code = "using System;";

            component.AddFile(code, "ClassExample", testType);
            Assert.AreEqual(1, component.Files.Count, "Component should have one file.");
        }
    }
}
