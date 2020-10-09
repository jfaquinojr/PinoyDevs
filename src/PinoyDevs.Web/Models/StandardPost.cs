using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PinoyDevs.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost : Post<StandardPost>
    {
    }
}