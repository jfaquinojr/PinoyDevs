using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PinoyDevs.Models
{
    [PageType(Title = "Episodes", IsArchive = true, UsePrimaryImage = false, UseExcerpt = false)]
    [PageTypeRoute(Title = "Default", Route = "/episodes")]
    public class EpisodesArchive : Page<EpisodesArchive>
    {
    }
}