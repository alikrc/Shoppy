namespace Shoppy.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_Page
    {
        [Key]
        public int PageID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(2000)]
        public string Url { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Content { get; set; }
    }
}
