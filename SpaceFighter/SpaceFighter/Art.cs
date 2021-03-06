﻿//---------------------------------------------------------------------------------
// Written by Michael Hoffman
// Find the full tutorial at: http://gamedev.tutsplus.com/series/vector-shooter-xna/
//----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpaceFighter
{
	static class Art
	{
		public static Texture2D Player { get; private set; }
		public static Texture2D Seeker { get; private set; }
		public static Texture2D Wanderer { get; private set; }
		public static Texture2D Bullet { get; private set; }
		public static Texture2D Pointer { get; private set; }
        public static Texture2D Base { get; private set; }

        public static SpriteFont Font { get; private set; }

        public static Texture2D MapSet1 { get; private set; }





        public static void Load(ContentManager content)
		{
			Player = content.Load<Texture2D>("Art/Player");
			Seeker = content.Load<Texture2D>("Art/Seeker");
			Wanderer = content.Load<Texture2D>("Art/Wanderer");
			Bullet = content.Load<Texture2D>("Art/Bullet");
			Pointer = content.Load<Texture2D>("Art/Pointer");
            Base = content.Load<Texture2D>("Art/Base");

            Font = content.Load<SpriteFont>("Fonts/Font");

            MapSet1 = content.Load<Texture2D>("Art/MapSheet");
        }
	}
}
