using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for GreetDeveloperResponse, responsible for converting between
/// entity to response.
/// </summary>
public static class GreetDeveloperAssembler
{
    /// <summary>
    /// Converts a <see cref="Developer"/> entity to a <see cref="GreetDeveloperResponse"/> response.
    /// </summary>
    /// <param name="entity">The <see cref="Developer"/> entity to convert.</param>
    /// <returns>A <see cref="GreetDeveloperResponse"/> response containing the developer's information (if available) and a corresponding greeting message.</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity is null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer!");
    }
}