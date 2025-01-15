using GreetingKata.classes;
using GreetingKata.Handlers;
using Xunit;

public class ShoutingNameHandlerTests
{
    [Fact]
    public void Handle_ReturnsShoutedGreeting_WhenNameIsUppercase()
    {
        var handler = new ShoutingNameHandler();
        var result = handler.Handle(new[] { "JERRY" });
        Assert.Equal("HELLO JERRY!", result);
    }

    [Fact]
    public void Handle_PassesToNextHandler_WhenNoUppercaseNames()
    {
        var nextHandler = new MockHandler();
        var handler = new ShoutingNameHandler();
        handler.SetNext(nextHandler);

        handler.Handle(new[] { "Bob" });

        Assert.True(nextHandler.Called);
    }
}

public class MockHandler : BaseHandler
{
    public bool Called { get; private set; }

    public override string Handle(string[] names)
    {
        Called = true;
        return base.Handle(names);
    }
}
