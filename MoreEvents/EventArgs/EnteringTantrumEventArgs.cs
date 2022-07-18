using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEvents.EventArgs
{
    /// <summary>
    /// Contains all information before a player enters a tantruem.
    /// </summary>
    public class EnteringTantrumEventArgs : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnteringEnvironmentalHazardEventArgs"/> class.
        /// </summary>
        /// <param name="player"><inheritdoc cref="Player"/></param>
        /// <param name="tantrum"><inheritdoc cref="TantrumEnvironmentalHazard"/></param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed"/></param>
        public EnteringTantrumEventArgs(Player player, TantrumEnvironmentalHazard tantrum, bool isAllowed = true)
        {
            Player = player;
            Tantrum = tantrum;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the player who's entering the tantrum.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets the tantrum that the player is entering.
        /// </summary>
        public TantrumEnvironmentalHazard Tantrum { get; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the player should be affected by the tantrum.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}
