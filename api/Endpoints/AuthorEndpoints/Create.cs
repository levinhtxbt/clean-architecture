using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace api.AuthorEndpoints;

public class Create : EndpointBaseAsync.WithRequest<CreateAuthorRequest>.WithResult<CreateAuthorResult>
{
    [HttpPost("authors")]
    [SwaggerOperation(
        Summary = "Create a new authors",
        Description = "Create a new authors",
        OperationId = "Author.Create",
        Tags = new[] {"AuthorEndpoint"})
    ]
    public override async Task<CreateAuthorResult> HandleAsync(CreateAuthorRequest request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        return new CreateAuthorResult()
        {
            Id = 1,
            Name = request.Name,
            Email = request.Email,
            Website = request.Website
        };
    }
}