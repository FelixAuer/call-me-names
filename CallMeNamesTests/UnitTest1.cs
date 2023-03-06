using CallMeNamesTool;
using Xunit;

namespace CallMeNamesTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello Peppo!", NameCaller.Call("Peppo"));
    }
}