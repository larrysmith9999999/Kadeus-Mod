using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using static Terraria.ModLoader.ModContent;

namespace KadeusMod.Items.Weapons
{
	public class TutorialSummonStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Journal");
			Tooltip.SetDefault("You made a deal with the devil.");
		}

		public override void SetDefaults() 
		{
			item.summon = true;
			item.mana = 10;

			item.damage = 100;
			item.width = 48;
			item.height = 48;
			item.maxStack = 1;
			item.value = 50000;
			item.rare = 4;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 4;
			item.useTurn = true;
			item.UseSound = SoundID.Item44;

			//item.shoot = mod.ProjectileType("Eye Ball");
			//item.shootSpeed = 10f;

			//item.buffType("Evil Presence");
			//item.buffTime = 3600;
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}

		public override bool ALtFunctionUse(Player player)
		{
			return true;
		}

		public override bool shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			return player.altFunctionUse != 2;
		}

		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
	}
}
