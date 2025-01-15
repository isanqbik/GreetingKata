using GreetingKata.Handlers;
using Xunit;

public class NullNameHandlerTests
{
    [Fact]
    public void Handle_ReturnsFriendMessage_WhenNamesAreNull()
    {
        var handler = new NullNameHandler();
        var result = handler.Handle(null);
        Assert.Equal("Hello, my friend.", result);
    }

    [Fact]
    public void Handle_ReturnsFriendMessage_WhenNamesAreEmpty()
    {
        var handler = new NullNameHandler();
        var result = handler.Handle(new string[0]);
        Assert.Equal("Hello, my friend.", result);
    }
}
