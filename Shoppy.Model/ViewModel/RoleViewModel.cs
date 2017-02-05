using System.ComponentModel.DataAnnotations;

namespace Shoppy.Model.ViewModel
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name="Role Name")]
        public string Name { get; set; }
    }
}