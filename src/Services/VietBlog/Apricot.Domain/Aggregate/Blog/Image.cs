using System;
using System.Collections.Generic;
using System.Text;

namespace Apricot.Domain.Aggregate.Blog
{
    public class Image<IKey, IValue>
    {
        public IKey Key { get; set; }
        public IValue Value { get; set; }
    }
}
