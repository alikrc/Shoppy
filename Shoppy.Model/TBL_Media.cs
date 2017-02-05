namespace Shoppy.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_Media
    {
        [Key]
        public int MediaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(3000)]
        public string Path { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
