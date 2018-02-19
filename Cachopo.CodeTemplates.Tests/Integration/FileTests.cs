namespace Cachopo.CodeTemplates.Tests.Integration
{
    using NUnit.Framework;
    using System.IO;

    [TestFixture]
    [Category(Category.Integration)]
    class FileTests
    {
        private readonly string _directory = @"Tests\";
        private readonly string _properlyFormmatedCodeFilePath = @"Tests\ProperlyFormatted.txt";
        private readonly string _wrongFormmatedCodeFilePath = @"Tests\WrongFormatted.txt";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            if(!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            if (Directory.Exists(_directory))
            {
                DirectoryInfo directory = new DirectoryInfo(_directory);

                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                }

                Directory.Delete(_directory);
            }
        }

        [Test]
        public void Construction_CodeProperlyFormatted()
        {
            string name = "House";
            string path = "./Buildings";
            string code = WrongFormattedCode();
            var file = new CodeTemplates.File(code, name, path, FileTypes.Cs);

            File.WriteAllText(_directory + "Result.cs", file.Code);
            Assert.AreEqual(file.Code, ProperlyFormmattedCode());
        }

        private string WrongFormattedCode()
        {
            return File.ReadAllText(_wrongFormmatedCodeFilePath);
        }

        private string ProperlyFormmattedCode()
        {
            return File.ReadAllText(_properlyFormmatedCodeFilePath);
        }
    }
}