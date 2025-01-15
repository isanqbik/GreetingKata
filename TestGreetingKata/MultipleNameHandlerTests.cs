using GreetingKata.classes;
using GreetingKata.Handlers;
using Xunit;

public class MultipleNameHandlerTests
{
    [Fact]
    public void Handle_ReturnsGreetingForMultipleNames()
    {
        var handler = new MultipleNameHandler();
        var result = handler.Handle(new[] { "Amy", "Brian", "Charlotte" });
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
    }

    [Fact]
    public void Handle_PassesToNextHandler_WhenNotMultipleNames()
    {
        var mockNextHandler = new MockHandler();
        var handler = new MultipleNameHandler();
        handler.SetNext(mockNextHandler);

        handler.Handle(new[] { "Amy", "Brian" });

        Assert.True(mockNextHandler.Called);
    }

    public class MockHandler : BaseHandler
    {
        public bool Called { get; private set; }

        public override string Handle(string[] names)
        {
            Called = true; // Indicar que el manejador fue llamado
            return base.Handle(names);
        }
    }
}