using System;

[assembly: CLSCompliant(true)]
namespace Cachopo.CodeTemplates
{
    public interface ITemplateBuilder
    {
        void Build(ITemplate codeTemplate);
    }
}