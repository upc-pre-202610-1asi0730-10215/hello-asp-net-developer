using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for Developer entity, responsible for converting between
/// request to entity.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a <see cref="GreetDeveloperRequest"/> request to an <see cref="Developer"/> entity.
    /// </summary>
    /// <param name="request">The <see cref="GreetDeveloperRequest"/> request containing the developer's first and last name.</param>
    /// <returns>An instance of <see cref="Developer"/> if the request is valid; otherwise, null.</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request is null 
            || string.IsNullOrWhiteSpace(request.FirstName) 
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;

        return new Developer(request.FirstName, request.LastName);
    } 
}