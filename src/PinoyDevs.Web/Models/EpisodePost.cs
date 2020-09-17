using Piranha.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.AttributeBuilder;
using Piranha.Models;
using Piranha.Extend.Fields;
using Piranha.Extend;

namespace PinoyDevs.Models
{
    [PostType(Title = "Episode", UseExcerpt = false, UseBlocks = false, UsePrimaryImage = false)]
    [PostTypeRoute(Title = "Default", Route = "/episode")]
    public class EpisodePost: Post<EpisodePost>
    {
        public class EpisodeRegion
        {
            [Field(Options = FieldOption.HalfWidth)]
            public NumberField EpisodeNo { get; set; }
            [Field]
            public TextField Summary { get; set; }
            [Field]
            public AudioField Audio { get; set; }
            [Field]
            public MarkdownField ShowNotes { get; set; }
            [Field(Options = FieldOption.HalfWidth)]
            public DateField RecordedOn { get; set; }
        }

        [Region]
        public EpisodeRegion Episode { get; set; }
    }
}
