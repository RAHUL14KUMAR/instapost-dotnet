using System.ComponentModel.DataAnnotations;

namespace instapostBusinesslayer.ViewModels
{
    public class CategoryModel
    {
        [Key]
        public long id{ get; set; }

        public string categoryName{ get; set; }

        public ICollection<PostModel> posts { get; set; } = new List<PostModel>();

        public ICollection<UserModel> users { get; set; } = new List<UserModel>();
    }
}