using Exiled.Events.Extensions;
using MoreEvents.EventArgs;

using static Exiled.Events.Events;

namespace MoreEvents.Handlers
{
    public static class Player
    {
        /// <summary>
        /// Invoked before a <see cref="Exiled.API.Features.Player"/> walks on a tantrum.
        /// </summary>
        public static event CustomEventHandler<EnteringTantrumEventArgs> EnteringTantrum;

        /// <summary>
        /// Invoked before a <see cref="Exiled.API.Features.Player"/> exits a tantrum.
        /// </summary>
        public static event CustomEventHandler<ExitingTantrumEventArgs> ExitingTantrum;

        /// <summary>
        /// Called before a <see cref="Exiled.API.Features.Player"/> walks on a tantrum.
        /// </summary>
        /// <param name="ev">The <see cref="EnteringTantrumEventArgs"/> instance. </param>
        public static void OnEnteringTantrum(EnteringTantrumEventArgs ev) => EnteringTantrum.InvokeSafely(ev);

        /// <summary>
        /// Called before a <see cref="Exiled.API.Features.Player"/> exits a tantrum.
        /// </summary>
        /// <param name="ev">The <see cref="ExitingTantrumEventArgs"/> instance. </param>
        public static void OnExitingTantrum(ExitingTantrumEventArgs ev) => ExitingTantrum.InvokeSafely(ev);
    }
}
