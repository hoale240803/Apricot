using Apricot.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apricot.Domain.Aggregate.Blog
{
    public class SeriesBlog:EntityBase<Guid>
    {
       private List<Blog> _blogs { get; set; }

       public List<Blog> Blogs { get; set; }

        public void Add(Blog blog)
        {

            // validate blog
            if (blog.Title.Length == 0)
            {
                throw new Exception("Title not empty");
            }

            if (blog.Title.Length > 1000)
            {
                throw new Exception("Title not be over 1000 characters");
            }


            _blogs.Add(blog);
        }

    }


}
