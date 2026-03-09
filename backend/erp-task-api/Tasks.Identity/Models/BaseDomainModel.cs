using Microsoft.AspNetCore.Identity;

namespace Employees.Identity.Models
{
    public class BaseDomainModel //: IdentityUser
    {
        public int Id { get; set; }
        public DateTime? CreatedDate {get;set;}
        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate {get;set;}
        public string? LastModifiedBy { get; set; } 
    }
}

