namespace Shoppy.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class AspNetUserClaims
    {
        public int Id { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
