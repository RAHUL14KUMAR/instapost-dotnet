using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace instapostEntitylayer;

public class UserEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id{ get; set; }

    [Required]
    public string username { get; set; }

    [Required]
    [EmailAddress]
    public string email { get; set; }

    [Required]
    public string password { get; set; }

    public ICollection<CategoryEntity> userInterestInCategory { get; set; } = new List<CategoryEntity>();

    public ICollection<PostEntity> posts { get; set; } = new List<PostEntity>();
}
