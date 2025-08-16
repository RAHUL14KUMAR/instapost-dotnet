using System.ComponentModel.DataAnnotations;

namespace instapostBusinesslayer.ViewModels
{
    public class CategoryModel
    {
        [Key]
        public long id;

        public string categoryName;

        public ICollection<PostModel> posts { get; set; } = new List<PostModel>();

        public ICollection<UserModel> users { get; set; } = new List<UserModel>();
    }
}