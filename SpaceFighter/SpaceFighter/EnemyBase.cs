using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceFighter
{
    class EnemyBase : Entity
    {

        public int PointValue { get; private set;}
        public int Healt { get; private set;}

        static Random rand = new Random();
        static float inverseSpawnChance = 60;

        public EnemyBase(Texture2D image, Vector2 position)
        {
            this.image = image;
            this.Position = position;
            this.Radius = image.Width / 2f;
            //this.color = Color.Transparent;

            Healt = 100;
            PointValue = 5;
        }

        public override void Update()
        {
            if (!PlayerShip.Instance.IsDead && EntityManager.Count < 200)
            {
                if (rand.Next((int)inverseSpawnChance) == 0)
                    EntityManager.Add(Enemy.CreateSeeker(this.Position));

                if (rand.Next((int)inverseSpawnChance) == 0)
                    EntityManager.Add(Enemy.CreateWanderer(this.Position));
            }

        }

        public void WasShot(int damage)
        {
            Healt -= damage;
            if (Healt <= 0)
            {
                wasKilled();
            }
        }
        public void wasKilled()
        {
            IsExpired = true;

            PlayerStatus.AddPoints(PointValue);
            //incress multiplier
        }

        public static EnemyBase CraateBase(Vector2 position)
        {
            var Base = new EnemyBase(Art.Wanderer, position);

            return Base;
        }
    }
}
