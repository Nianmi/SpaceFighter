﻿//---------------------------------------------------------------------------------
// Written by Michael Hoffman
// Find the full tutorial at: http://gamedev.tutsplus.com/series/vector-shooter-xna/
//----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceFighter
{
	class Bullet : Entity
	{
        public int damage { get; private set;}

		public Bullet(Vector2 position, Vector2 velocity)
		{
			image = Art.Bullet;
			Position = position;
			Velocity = velocity;
			Orientation = Velocity.ToAngle();
			Radius = 8;

            damage = 10;
		}

		public override void Update()
		{
			if (Velocity.LengthSquared() > 0)
				Orientation = Velocity.ToAngle();

			Position += Velocity;

			// delete bullets that go off-screen
			if (!GameRoot.Viewport.Bounds.Contains(Position.ToPoint()))
				IsExpired = true;
		}
	}
}
