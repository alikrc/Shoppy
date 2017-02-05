namespace Shoppy.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_Gallery
    {
        [Key]
        public int GalleryID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }
    }
}
