using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An Azerite-empowered item.
    /// </summary>
    public class AzeriteEmpoweredItem : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the Azerite powers.
        /// </summary>
        [JsonProperty("azeritePowers")]
        public IEnumerable<AzeritePower>? AzeritePowers { get; set; }
    }
}