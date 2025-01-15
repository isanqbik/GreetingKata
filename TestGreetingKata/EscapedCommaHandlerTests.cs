using GreetingKata.Handlers;
using Xunit;

public class EscapedCommaHandlerTests
{
    [Fact]
    public void Handle_SplitsNamesWithCommas()
    {
        // Arrange
        var handler = new EscapedCommaHandler();
        var simpleNameHandler = new SimpleNameHandler(); // Último manejador de la cadena
        handler.SetNext(simpleNameHandler);

        // Act
        var result = handler.Handle(new[] { "Bob", "Charlie, Dianne" });

        // Assert
        Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
    }

    [Fact]
    public void Handle_RespectsEscapedCommas()
    {
        // Arrange
        var handler = new EscapedCommaHandler();
        var simpleNameHandler = new SimpleNameHandler(); // Último manejador de la cadena
        handler.SetNext(simpleNameHandler);

        // Act
        var result = handler.Handle(new[] { "Bob", "\"Charlie, Dianne\"" });

        // Assert
        Assert.Equal("Hello, Bob and \"Charlie, Dianne\".", result);
    }
}
