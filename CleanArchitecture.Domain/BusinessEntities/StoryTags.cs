using CleanArchitecture.Domain.Common;
using System;

namespace CleanArchitecture.Domain.BusinessEntities
{
    public class StoryTags
    {
        public StoryTags()
        {
        }

        public long TagId { get; set; }
        public long StoryId { get; set; }


        public Story Story { get; set; }
        public Tag Tag { get; set; }

    }
}
