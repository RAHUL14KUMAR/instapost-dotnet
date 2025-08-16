using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace instapostEntitylayer
{
    public class PostEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id{ get; set; }

        [Required]
        public string postDesc { get; set; }

        public ICollection<CategoryEntity> postCategory { get; set; } = new List<CategoryEntity>();

        public ICollection<UserEntity> user = new List<UserEntity>();
    }
}