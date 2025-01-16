using System.Diagnostics.CodeAnalysis;
using GdUnit4;

namespace Broad;

[TestSuite]
[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public class ExampleTest
{
    [TestCase]
    public static void TestFoo()
    {
        var x = 5;
        Assertions.AssertThat(5).IsEqual(5);
    }
}