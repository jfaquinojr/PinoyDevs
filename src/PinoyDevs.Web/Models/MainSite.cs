using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinoyDevs.Models
{
    [SiteType(Title = "Main Site")]
    public class MainSite: SiteContent<MainSite>
    {
        [Region]
        public ImageField Logo { get; set; }

        [Region]
        public StringField Theme { get; set; }

    }
}
