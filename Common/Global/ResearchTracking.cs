﻿using MagicStorage.Modules;
using Terraria;
using Terraria.ModLoader;

namespace MagicStorage.Common.Global {
	internal class ResearchTracking : GlobalItem {
		public override void OnResearched(Item item, bool fullyResearched) {
			if (fullyResearched) {
				JourneyInfiniteItems.inventory.Add(item.type);
				StorageGUI.needRefresh = true;
			}
		}
	}
}
