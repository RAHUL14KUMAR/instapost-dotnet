using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace instapostEntitylayer
{
    public class PostEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id;

        [Required]
        public string postDesc { get; set; }

        public ICollection<CategoryEntity> postCategory { get; set; }

        public ICollection<UserEntity> user;
    }
}