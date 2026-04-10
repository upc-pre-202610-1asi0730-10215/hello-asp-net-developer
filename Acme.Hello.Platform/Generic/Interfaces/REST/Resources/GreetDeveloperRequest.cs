namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Represents a request resource to greet a developer.
/// </summary>
/// <param name="FirstName">The first name of the developer. It is optional.</param>
/// <param name="LastName">The last name of the developer. It is optional.</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);