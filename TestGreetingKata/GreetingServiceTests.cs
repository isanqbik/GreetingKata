using GreetingKata.services;
using Xunit;

public class GreetingServiceTests
{
    [Fact]
    public void Greet_UsesHandlerChainToProcessNames()
    {
        var handler = new MockHandler();
        var service = new GreetingService(handler);

        service.Greet("Bob");

        Assert.True(handler.Called);
    }
}
