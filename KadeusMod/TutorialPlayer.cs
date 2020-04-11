using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.IO;
using Microsoft.Xna.Framework;


namespace KadeusMod
{
    public class TutorialPlayer : ModPlayer
    {
        public bool tutorialPet = false;
        public bool summonSpiritMinion = false;

        public bool zoneBiome = false;
        public override void ResetEffects()
        {
            tutorialPet = false;
            summonSpiritMinion = false;
		}
    }   
}
