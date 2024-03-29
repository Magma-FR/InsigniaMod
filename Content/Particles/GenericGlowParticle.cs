using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace InsigniaMod.Content.Particles
{
    public class GenericGlowParticle : Particle
    {
		public GenericGlowParticle(Vector2 position, Vector2 velocity, Color color, float scale, int maxTime)
		{
			Position = position;
			Velocity = velocity;
			Color = color;
			Size = scale;
			TimeLeft = maxTime;
		}
		public override void Update()
		{
			TextureName = "GenericGlowParticle";
			Lighting.AddLight(Position, Color.R / 255, Color.G / 255, Color.B / 255);
			Velocity = Velocity.RotatedByRandom(MathHelper.ToRadians(5)) * 0.99f;
			Size *= 0.97f;
		}
	}
}
