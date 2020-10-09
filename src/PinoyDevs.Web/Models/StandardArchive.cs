using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.AttributeBuilder;
using Piranha.Models;


namespace PinoyDevs.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    [PageTypeArchiveItem(typeof(StandardPost))]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}


