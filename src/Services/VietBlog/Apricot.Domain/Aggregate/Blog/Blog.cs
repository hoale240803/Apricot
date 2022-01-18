using System.Collections.Generic;

namespace Apricot.Domain.Aggregate.Blog
{
    public class Blog : BlogBase
    {
        public string Title { get; set; }

        public bool IsDraft { get; set; }

        public string Content { get; set; }

        public string ClapCount { get; set; }

        private readonly List<Image<string, string>> _images = new List<Image<string, string>>();

        public IEnumerable<Image<string, string>> Images => _images.AsReadOnly();

        public List<Image<string, string>> AddImages(List<Image<string, string>> images)
        {
            //validate image

            _images.AddRange(images);

            return _images;
        }

        public void SaveAsDraft()
        {
            IsDraft = true;
        }

        public void ClapToBlog()
        {
        }

        //TODO clap to blog

        //TODO follow
        //

        //validate

        //1. validate title
        //2. validate content
    }
}