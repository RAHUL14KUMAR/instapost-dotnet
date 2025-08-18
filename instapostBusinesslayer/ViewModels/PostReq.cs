using System.ComponentModel.DataAnnotations;

namespace instapostBusinesslayer.ViewModels
{
    public class PostReq
    {
        public string postDesc { get; set; }

        public ICollection<long> postCategory { get; set; } = new List<long>();
    }
}