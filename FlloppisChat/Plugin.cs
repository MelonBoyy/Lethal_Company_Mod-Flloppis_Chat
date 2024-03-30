using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

using GameNetcodeStuff;
using QuickChat.RadialMenu;
using LethalConfig;

namespace QuickChat
{
	[BepInPlugin(PluginInfo.ModGUID, PluginInfo.ModName, PluginInfo.ModVersion)]
	[BepInDependency("alfungy.quickchat")]
	public partial class Plugin : BaseUnityPlugin
	{
		private readonly Harmony Harmony = new Harmony(PluginInfo.ModGUID);

		internal static ManualLogSource LogSource = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.ModGUID);
		internal static ConfigFile ConfigF;

		private void Awake()
		{
			ConfigF = Config;
			LogSource.LogInfo($"{PluginInfo.ModName} {PluginInfo.ModVersion} has been loaded!");

			LethalConfigManager.SkipAutoGen();
			RadialMenuSetupDefaults.Init();

			Harmony.PatchAll(typeof(RadialMenuSetupDefaults));
		}

	}

	internal static class PluginInfo
	{
		public const string ModGUID = "alfungy.flloppischat";
		public const string ModName = "Flloppis Chat";
		public const string ModVersion = "1.0";
	}
}