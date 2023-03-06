using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace api.AuthorEndpoints;

public class Delete : EndpointBaseAsync.WithRequest<DeleteAuthorRequest>.WithActionResult
{
    private readonly ILogger<Delete> _logger;

    public Delete(ILogger<Delete> logger)
    {
        _logger = logger;
    }

    [HttpDelete("authors/{id}")]
    [SwaggerOperation(
        Summary = "Delete an author",
        Description = "Delete an author",
        OperationId = "Author.Delete",
        Tags = new[] { "AuthorEndpoint" })
    ]
    public override async Task<ActionResult> HandleAsync(
        [FromRoute] DeleteAuthorRequest request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        _logger.LogInformation("Delete entry: {RequestId}", request.Id);

        return NoContent();
    }
}