using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace instapostEntitylayer
{
    public class CategoryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id{ get; set; }

        public string categoryName{ get; set; }

        public ICollection<PostEntity> posts { get; set; } = new List<PostEntity>();

        public ICollection<UserEntity> users { get; set; } = new List<UserEntity>();
    }
}