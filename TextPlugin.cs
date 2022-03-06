using BepInEx;
using UnboundLib;
using UnityEngine;
using UnboundLib.Cards;
using TextPlugin.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using UnboundLib.Cards;

namespace TextPlugin
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin("org.bepinex.plugins.plusingpoggers", "Random Game Cards", "1.0.0")]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class TextPlugin : BaseUnityPlugin
    {
        private const string ModId = "org.bepinex.plugins.plusingpoggers";
        private const string ModName = "TextPlugin";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "RGC";
        public static TextPlugin instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<Bounce>();
        }
    }
}
