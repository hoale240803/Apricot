using System;
using System.Collections.Generic;

namespace Apricot.Domain.Aggregate.Blog
{
    public class Blog : BlogBase
    {
        public string Title { get; set; }

        public bool IsDraft { get; set; }

        public string Content { get; set; }

        public string ClapCount { get; set; }   


        private List<Image<string, string>> _images { get; set; }
        public List<Image<string, string>> Images { get; set; }


        public void AddImage(Image<string,string> image)
        {
            //validate image


            _images.Add(image);

        }

        public void SaveAsDraft()
        {
            IsDraft = true;

        }


        //TODO clap to blog


        //TODO follow
        //

        //validate 

        //1. validate title
        //2. validate content
    }




}