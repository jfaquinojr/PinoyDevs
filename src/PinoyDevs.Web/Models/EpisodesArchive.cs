using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PinoyDevs.Models
{
    [PageType(Title = "Episodes", IsArchive = true, UsePrimaryImage = true, UseExcerpt = false)]
    [PageTypeRoute(Title = "Default", Route = "/episodes")]
    [PageTypeArchiveItem(typeof(EpisodePost))]
    public class EpisodesArchive : Page<EpisodesArchive>
    {
    }
}