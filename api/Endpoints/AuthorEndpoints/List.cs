using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace api.AuthorEndpoints;

public class List : EndpointBaseAsync.WithRequest<AuthorListRequest>.WithResult<IList<AuthorListResult>>
{
    [HttpGet("authors")]
    [SwaggerOperation(
        Summary = "Get list of authors",
        Description = "Get list of authors",
        OperationId = "Author.List",
        Tags = new[] {"AuthorEndpoint"})
    ]
    public override async Task<IList<AuthorListResult>> HandleAsync(
        [FromQuery] AuthorListRequest request,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await Task.CompletedTask;
        
        return new List<AuthorListResult>()
        {
            new ()
            {
                Id = 1,
                Name = "Levin",
                Email = "vinh@siliconstack.com.au",
                Website = "https://siliconstack.com.au"
            }
        };
    }
}