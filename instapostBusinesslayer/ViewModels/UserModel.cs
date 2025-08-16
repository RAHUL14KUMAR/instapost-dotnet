using System.ComponentModel.DataAnnotations;

namespace instapostBusinesslayer.ViewModels
{
    public class UserModel
    {
        [Key]
        public long id{ get; set; }
        [Required]
        public string username { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public ICollection<CategoryModel> userInterestInCategory { get; set; } = new List<CategoryModel>();

        public ICollection<PostModel> posts { get; set; } = new List<PostModel>();
    }
}