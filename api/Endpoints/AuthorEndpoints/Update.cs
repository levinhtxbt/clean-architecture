using api.Attributes;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace api.AuthorEndpoints;

public class Update : EndpointBaseAsync.WithRequest<UpdateAuthorRequest>.WithResult<UpdateAuthorResult>
{
    public Update()
    {
    }

    [HttpPut("authors/{id}")]
    [SwaggerOperation(
        Summary = "Update an author",
        Description = "Update an author",
        OperationId = "Author.Update",
        Tags = new[] {"AuthorEndpoint"})
    ]
    public override async Task<UpdateAuthorResult> HandleAsync(
        [FromMultiSource] UpdateAuthorRequest request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}