using Exiled.API.Enums;
using Exiled.API.Features;
using HarmonyLib;

namespace MoreEvents
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public static Harmony Harmony { get; private set; }

        private static int patchCount = 0;

        public override PluginPriority Priority { get; } = PluginPriority.First;

        public override void OnEnabled()
        {
            Instance = this;

            Harmony = new Harmony("MoreEvents-" + (patchCount++).ToString());
            Harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Harmony.UnpatchAll(Harmony.Id);
            Harmony = null;
            Instance = null;
            base.OnDisabled();
        }

        /// <summary>
        /// The custom <see cref="EventHandler"/> delegate.
        /// </summary>
        /// <typeparam name="TEventArgs">The <see cref="EventHandler{TEventArgs}"/> type.</typeparam>
        /// <param name="ev">The <see cref="EventHandler{TEventArgs}"/> instance.</param>
        public delegate void CustomEventHandler<TEventArgs>(TEventArgs ev)
            where TEventArgs : System.EventArgs;

        /// <summary>
        /// The custom <see cref="EventHandler"/> delegate, with empty parameters.
        /// </summary>
        public delegate void CustomEventHandler();
    }
}
