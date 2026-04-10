namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a developer entity with a first name, last name, and a unique identifier (ID).
/// </summary>
/// <param name="firstName">The first name of the developer. If null or empty, it will be treated as an empty string.</param>
/// <param name="lastName">The last name of the developer. If null or empty, it will be treated as an empty string.</param>
public class Developer(string firstName, string lastName)
{
    /// <summary>
    /// Gets the full name of the developer.
    /// </summary>
    /// <returns>A string that combines the first name and last name, separated by a space. If either name is empty, it will be omitted from the result.</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Checks if either the first name or last name is empty.
    /// </summary>
    /// <returns>true if either the first name or last name is null, empty, or consists only of whitespace; otherwise, false.</returns>
    public bool IsAnyNameEmpty() => string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
    
    public Guid Id { get;  } = Guid.NewGuid();
    public string FirstName { get; } = string.IsNullOrWhiteSpace(firstName) ? string.Empty : firstName.Trim();
    public string LastName { get; } = string.IsNullOrWhiteSpace(lastName) ? string.Empty : lastName.Trim();
}