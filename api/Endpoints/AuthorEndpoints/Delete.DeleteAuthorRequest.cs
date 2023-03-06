using Microsoft.AspNetCore.Mvc;

namespace api.AuthorEndpoints;

public class DeleteAuthorRequest
{
    [FromRoute(Name = "id")]
    public int Id { get; set; }
}