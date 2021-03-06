﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StoneworkRoseCafe.Mugs {
    class Mug : ModItem {
		private string displayName;
		private string texturePath;
		public int tile;
		public override bool CloneNewInstances => true;
		public override string Texture => texturePath;

		public override bool Autoload(ref string name) {
			return false;
		}

		public Mug(string name, string texture) {
			displayName = name;
			texturePath = texture;
		}

		public override void SetStaticDefaults() {
			DisplayName.SetDefault(displayName);
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 20000;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = tile;
			item.placeStyle = 0;
			item.holdStyle = 1;
		}

        public override void HoldStyle(Player player) {
			player.itemLocation += new Vector2(-5*player.direction,7);
        }
    }
}
