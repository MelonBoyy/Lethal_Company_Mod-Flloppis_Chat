using System.Collections.Generic;

using UnityEngine;

using QuickChat.RadialMenu;
using QuickChat;
using LethalConfig.ConfigItems;
using LethalConfig;

namespace FlloppisChat
{
	public class FlloppisMenuSetup
	{
		public static RadialMenu flloppisPositionsMenu = new RadialMenu("Positionni");
		public static RadialMenu flloppisMonstersMenu2 = new RadialMenu("Monstersi 2")
		{
			saveToHistory = false,
			radialOffset = RadialMenu.UnitCircleOffset.LEFT
		};
		public static RadialMenu flloppisMonstersMenu = new RadialMenu("Monstersi")
		{
			radialOffset = RadialMenu.UnitCircleOffset.RIGHT,
		};
		public static RadialMenu flloppisCommandsMenu = new RadialMenu("Commandii");
		public static RadialMenu flloppisAnswersMenu = new RadialMenu("Answersi");
		public static RadialMenu flloppisQuestionsMenu = new RadialMenu("Questionni");
		public static RadialMenu flloppisEmotionsMenu = new RadialMenu("Emotionsi");
		public static RadialMenu flloppisObservationsMenu = new RadialMenu("Observationni");
		public static RadialMenu flloppisUrgentMenu = new RadialMenu("URGENTSI");
		public static RadialMenu flloppisMenu = new RadialMenu("Flopsi Quicksi Chat");

		public static List<RadialMenu.RadialButton> flloppisMenuButtons = new List<RadialMenu.RadialButton>();

		internal static void Init()
		{
			flloppisMenuButtons = new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton(flloppisObservationsMenu, Color.cyan),
				new RadialMenu.RadialButton(flloppisQuestionsMenu, Color.yellow),
				new RadialMenu.RadialButton(flloppisCommandsMenu, Color.magenta),
				new RadialMenu.RadialButton(flloppisUrgentMenu, Color.red),
				new RadialMenu.RadialButton(flloppisAnswersMenu, Color.green),
				new RadialMenu.RadialButton(flloppisEmotionsMenu, Color.white)
			};

			flloppisPositionsMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("thaddar way", "\"thaddar way!\" (point)", "!")
				{
					postRadialButtonClicked = (radialMenu, radialButton) => PerformEmoteFix(2)
				},
				new RadialMenu.RadialButton("ta the rightsi"),
				new RadialMenu.RadialButton("uppa \'head"),
				new RadialMenu.RadialButton("atta FireExitsi"),
				new RadialMenu.RadialButton("atta Main"),
				new RadialMenu.RadialButton("!"),
				new RadialMenu.RadialButton("\'ere"),
				new RadialMenu.RadialButton("ta the leftsi")
			});

			flloppisMonstersMenu2.UpdateRadialButtons(new List<RadialMenu.RadialButton>
			{
				new RadialMenu.RadialButton()
				{
					displayText = "<<LASTSI PAGE>>",
					saveToHistory = false,
					connectingRadialMenu = () => flloppisMonstersMenu
				},
				new RadialMenu.RadialButton("Nutcrackersi", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Coilli", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Jestersi", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Maski", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Giantii", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Birdsi", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Dogsi", flloppisPositionsMenu)
				{
					preRadialButtonClicked = (radialMenu, radialButton) => RadialMenuManager.ModifyRadialButtonHistory("Theres 'an", RadialMenuManager.RadialButtonHistory.Count - 1)
				},
				new RadialMenu.RadialButton("Wormmi", flloppisPositionsMenu)
				{
					preRadialButtonClicked = (radialMenu, radialButton) => RadialMenuManager.ModifyRadialButtonHistory("Theres 'an", RadialMenuManager.RadialButtonHistory.Count - 1)
				}
			});

			flloppisMonstersMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>
			{
				new RadialMenu.RadialButton()
				{
					displayText = "<<NEXTTI PAGE>>",
					saveToHistory = false,
					connectingRadialMenu = () => flloppisMonstersMenu2
				},
				new RadialMenu.RadialButton("Snarey Flee", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Spiderri", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Bugsi", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Brackenna", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Thumpersi", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Slimesii", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Ghostii", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Lizardsi", flloppisPositionsMenu)
			});

			flloppisCommandsMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("Followwi me"),
				new RadialMenu.RadialButton("Stopsi"),
				new RadialMenu.RadialButton("Shhhh", '!'),
				new RadialMenu.RadialButton("Amma go \'head"),
				new RadialMenu.RadialButton("Letsi go", "\"Letsi go {direction}\"", flloppisPositionsMenu)
			});

			flloppisAnswersMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("Eh", '?', Color.gray)
				{
					textColor = Color.white,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("Uuhh", '-', Color.gray),
				new RadialMenu.RadialButton("Oi", '!', Color.gray),
				new RadialMenu.RadialButton("Wah", '?', Color.gray),
				new RadialMenu.RadialButton("Dunno", '-', Color.gray),
				new RadialMenu.RadialButton("Kiinda", '-', Color.gray),
				new RadialMenu.RadialButton("Nuh uh", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("Nono", '!', Color.red),
				new RadialMenu.RadialButton("ACK", '!', Color.white)
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("AAA", '?', Color.white)
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("AAAAA", "AAAAA!!!", "!!!")
				{
					buttonColor = Color.white,
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("HEHEHHEEE", Color.green),
				new RadialMenu.RadialButton("Yuh", '?', Color.green),
				new RadialMenu.RadialButton("Yeye", '!', Color.green),
				new RadialMenu.RadialButton("Yuh", '!', Color.green),
				new RadialMenu.RadialButton("Hehe", '!', Color.green),
				new RadialMenu.RadialButton("Ello", '!', Color.green),
				new RadialMenu.RadialButton("Byebye", '!', Color.blue)
			});

			flloppisQuestionsMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("Wha was thaddar", '?'),
				new RadialMenu.RadialButton("Whosi there", '?'),
				new RadialMenu.RadialButton("Are'ya oki", '?'),
				new RadialMenu.RadialButton("Did'ja hearsi that", '?'),
				new RadialMenu.RadialButton("Are'ya real", '?'),
				new RadialMenu.RadialButton("Wha upsi", '?'),
				new RadialMenu.RadialButton("Wha", '?')
			});

			flloppisEmotionsMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>
			{
				new RadialMenu.RadialButton(">:D")
				{
					textColor = Color.red,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("D:<")
				{
					textColor = Color.red,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">:P")
				{
					textColor = Color.green,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">:]")
				{
					textColor = Color.red,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">:[")
				{
					textColor = Color.red,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">-<")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">~<")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("o~o")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(";<")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(":>")
				{
					textColor = Color.green,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("O-O")
				{
					textColor = Color.green,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("O~O")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("@~@")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("T-T")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("ToT")
				{
					textColor = Color.blue,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton("O - O")
				{
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(":o")
				{
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(">:o")
				{
					textColor = Color.red,
					useTextColorOnChat = true,
					punctuation = () => string.Empty
				},
				new RadialMenu.RadialButton(":o", '?')
				{
					textColor = Color.blue,
					useTextColorOnChat = true
				}
			});;

			flloppisObservationsMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("More scrapsi", "\"More scrapsi {direction}\"", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Theres\'a trappi", "\"Theres\'a trappi {direction}\"", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Theresi dead-end", "\"Theresi dead-end {direction}\"", flloppisPositionsMenu),
				new RadialMenu.RadialButton("Theres\'a", "\"Theres'a(n) {monster} {direction}\"", flloppisMonstersMenu),
				new RadialMenu.RadialButton("Thaddar\'n mimic", '!'),
				new RadialMenu.RadialButton("Tha notsi real", '!')
			});

			flloppisUrgentMenu.UpdateRadialButtons(new List<RadialMenu.RadialButton>()
			{
				new RadialMenu.RadialButton("NUTCRACKERSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("COILLSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("JESTERRI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("MASKII", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("GIANTI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("BIRDSII", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("SNAREY FLEE", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("SPIDERSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("BUGS-A", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("BRACKENNA", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("THUMPERSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("SLIMESII", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("GHOSTII HAUNTED", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("LIZARDSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("RUNSI", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("GO GO", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
				new RadialMenu.RadialButton("HELPSII", '!')
				{
					textColor = Color.red,
					useTextColorOnChat = true
				},
			});

			flloppisMenu.UpdateRadialButtons(flloppisMenuButtons);

			// The item containers so we can loop through them later
			List<TextInputFieldConfigItem> displayTextConfigItems = new List<TextInputFieldConfigItem>();
			List<IntSliderConfigItem[]> colorConfigItems = new List<IntSliderConfigItem[]>();

			foreach (RadialMenu.RadialButton button in flloppisMenuButtons)
			{
				displayTextConfigItems.Add(RadialMenuConfig.DisplayTextConfigFromButton(Plugin.ConfigF, button));
				colorConfigItems.Add(RadialMenuConfig.ColorConfigFromButton(Plugin.ConfigF, button));
			}

			// Adding the items to the Config manually
			foreach (TextInputFieldConfigItem item in displayTextConfigItems)
			{
				LethalConfigManager.AddConfigItem(item);
			}

			// Adding the items to the Config manually
			foreach (IntSliderConfigItem[] arr in colorConfigItems)
			{
				foreach (IntSliderConfigItem item in arr)
				{
					LethalConfigManager.AddConfigItem(item);
				}
			}

			RadialMenuManager.MainMenu.AddRadialButton(new RadialMenu.RadialButton(flloppisMenu));
		}

		private static void PerformEmoteFix(int emoteIndex)
		{
			var localPlayer = GameNetworkManager.Instance.localPlayerController;

			localPlayer.timeSinceStartingEmote = 0f;
			localPlayer.performingEmote = true;
			localPlayer.playerBodyAnimator.SetInteger("emoteNumber", emoteIndex);
			localPlayer.StartPerformingEmoteServerRpc();
		}
	}

}