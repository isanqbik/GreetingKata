using GreetingKata.Handlers;
using Xunit;

public class TwoNameHandlerTests
{
    [Fact]
    public void Handle_ReturnsGreetingForTwoNames()
    {
        var handler = new TwoNameHandler();
        var result = handler.Handle(new[] { "Jill", "Jane" });
        Assert.Equal("Hello, Jill and Jane.", result);
    }

    [Fact]
    public void Handle_PassesToNextHandler_WhenNotTwoNames()
    {
        var nextHandler = new MockHandler();
        var handler = new TwoNameHandler();
        handler.SetNext(nextHandler);

        handler.Handle(new[] { "Jill" });

        Assert.True(nextHandler.Called);
    }
}
