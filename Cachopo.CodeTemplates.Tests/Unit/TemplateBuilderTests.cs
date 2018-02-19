namespace Cachopo.CodeTemplates.Tests.Unit
{
    using NUnit.Framework;
    using Moq;
    using System;

    [TestFixture]
    [Category(Category.Unit)]
    class TemplateBuilderTests
    {
        private readonly Mock<IFileSystem> _fileSystem = new Mock<IFileSystem>();

        public void Construction_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new TemplateBuilder(null));
        }

        [Test]
        public void Build_NullArgument_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new TemplateBuilder().Build(null));
        }

        [Test]
        public void Build_DirectoryAndFilesCreated()
        {
            string folder = "folder";
            FolderDoesNotExists(folder);

            var component = new Template(folder);
            component.AddFile("someCode", "name", FileTypes.Cs);
            component.AddFile("moreCode", "name", FileTypes.Cs);

            var componentBuilder = new TemplateBuilder(_fileSystem.Object);
            componentBuilder.Build(component);

            VerifyDirectoryAndFilesAreCreated(folder, component.Files.Count);
        }

        private void FolderDoesNotExists(string folder)
        {
            _fileSystem.Setup(fs =>
                fs.ExistsDirectory(It.Is<string>(f => f == folder))).Returns(false);
        }

        private void VerifyDirectoryAndFilesAreCreated(string folder, int numberOfFiles)
        {
            _fileSystem.Verify(fs =>
               fs.CreateDirectory(It.Is<string>(f => f == folder)), Times.Once);

            _fileSystem.Verify(fs =>
              fs.CreateFile(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(numberOfFiles));
        }
    }
}
