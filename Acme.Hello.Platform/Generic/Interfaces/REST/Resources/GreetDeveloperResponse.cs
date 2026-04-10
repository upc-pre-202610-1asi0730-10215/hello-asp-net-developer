namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Represents a response resource for greeting a developer.
/// </summary>
/// <param name="Id">The unique identifier of the developer. It is optional.</param>
/// <param name="FullName">The full name of the developer. It is optional.</param>
/// <param name="Message">The greeting message for the developer.</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Constructor for creating a response resource with a message.
    /// </summary>
    /// <param name="message">The greeting message for the developer.</param>
    public GreetDeveloperResponse(string message) : this(null, null, message)
    {
    }
}
