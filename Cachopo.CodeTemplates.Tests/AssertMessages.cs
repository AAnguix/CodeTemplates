namespace Cachopo.CodeTemplates.Tests
{
    internal class AssertMessages
    {
        public static string ShouldBeEquals(string property, string argument)
            => $"'{property}' property should be equals '{argument}' argument value.";
    }
}
