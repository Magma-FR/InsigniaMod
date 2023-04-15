using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using TheJungleBeckonsF.Effects.Particles;
using TheJungleBeckonsF.Common.Systems;

namespace TheJungleBeckonsF
{
    public class TheJungleBeckonsF : Mod
    {
        public override void Unload()
        {
            ParticleSystem.Unload();
        }
    }
}
