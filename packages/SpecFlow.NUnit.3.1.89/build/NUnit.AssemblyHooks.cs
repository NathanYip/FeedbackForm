using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.89")]
[SetUpFixture]
public class PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
