using CleanArchitecture.Domain.Common;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.BusinessEntities
{
    public class Tag : AbstractBusinessEntity<long>
    {
        public Tag()
        {
            this.Stories = new HashSet<StoryTags>();
        }

        public string Name { get; set; }
        public ICollection<StoryTags> Stories { get; set; }

    }
}
