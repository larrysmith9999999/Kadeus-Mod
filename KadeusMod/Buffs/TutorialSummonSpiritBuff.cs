using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace KadeusMod.Buffs
{
    public class TutorialSummonSpiritBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bill Cypher");
            Description.SetDefault("You made a deal with a devil.");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            TutorialPlayer tutorialPlayer = player.GetModPlayer<TutorialPlayer>(mod);
            if (player.ownedProjectileCounts[mod.ProjectileType("Bill Cypher")] > 0)
            {
                tutorialPlayer.summonSpiritMinion = true;
            }
            if (!tutorialPlayer.summonSpiritMinion)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}