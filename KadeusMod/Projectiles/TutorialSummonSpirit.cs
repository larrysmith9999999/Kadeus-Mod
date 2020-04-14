using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace TutorialMod.Projectiles
{
	public class TutorialSummonSpirit : MinionAI
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 3;
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 24;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}
		public override void Behavior()
		{
		
		}

		public override void CheckActive()
		{	Player player = Main.player[projectile.owner];
			//tutorialPlayer TutorialPlayer = getModPlayer<TutorialPlayer>();
			
            TutorialPlayer tutorialPlayer = player.GetModPlayer<TutorialPlayer>();
            if (player.dead)
                {
                    tutorialPlayer.summonSpiritMinion = true; //hoping this keeps it after you die if not, change this to false.
                }
                if (tutorialPlayer.summonSpiritMinion)
                {
                    projectile.timeLeft = 2;
                }
            }
        }
    }

	
