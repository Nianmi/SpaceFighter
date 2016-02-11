using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceFighter
{
    static class LevelReader
    {
        static public void readLevelData()
        {
            Texture2D map = Art.MapSet1;
            Color[] colors1D = new Color[128*72];
            Rectangle rect = new Rectangle(128, 144, 128, 72);
            map.GetData<Color>(0, rect, colors1D, 0, colors1D.Length);

            spawnBases(colors1D);
        }

        static private void spawnBases(Color[] map)
        {
            int x = 1;
            int y = 1;
            foreach (Color col in map)
            {
                if (col == Color.Black)
                {
                    EntityManager.Add(EnemyBase.CraateBase(new Vector2(x * 10, y * 10)));
                }
                else if (col == Color.Blue)
                {
                    EntityManager.Add(EnemyBase.CraateBase(new Vector2(x * 10, y * 10)));
                }
                if (x >= 128)
                {
                    x = 0;
                    y++;
                }
                x++;
            }
        }
    }

    public class level
    {
        public List<Vector2> levelsCoordinates = new List<Vector2>();

        public level()
        {
            
        }
    }

}
