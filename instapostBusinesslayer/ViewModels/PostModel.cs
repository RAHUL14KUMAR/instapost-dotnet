using System.ComponentModel.DataAnnotations;

namespace instapostBusinesslayer.ViewModels
{
    public class PostModel
    {
        [Key]
        public long id{ get; set; }

        [Required]
        public string postDesc { get; set; }

        public ICollection<CategoryModel> postCategory { get; set; } = new List<CategoryModel>();

        public ICollection<UserModel> user = new List<UserModel>();
    }
}