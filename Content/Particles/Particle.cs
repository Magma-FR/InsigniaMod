using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;
using TheJungleBeckonsF.Effects.Particles;
using ReLogic.Content;

namespace TheJungleBeckonsF.Effects.Particles
{
    public abstract class Particle
    {
        public Texture2D Texture;
        public string TextureName;
        public Vector2 Position;
        public Vector2 Velocity;
        public float Angle;
        public float AngularVelocity;
        public Color Color;
        public float Size;
        public int TimeLeft;
        public Rectangle? Frame;
        
        public virtual void Update() { }
        public virtual bool Kill => false;
    }
}
