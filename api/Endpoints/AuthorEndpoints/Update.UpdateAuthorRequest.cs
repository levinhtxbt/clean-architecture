using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace api.AuthorEndpoints;

public class UpdateAuthorRequest
{
    [FromRoute(Name = "id")]
    [Required]
    public int Id { get; set; }

    [FromBody]
    public UpdateAuthorDetail Detail { get; set; }
    
    public class UpdateAuthorDetail
    {
        [Required]
        public string? Name { get; set; }
        
        [Required]
        public string? Website { get; set; }
    }
}