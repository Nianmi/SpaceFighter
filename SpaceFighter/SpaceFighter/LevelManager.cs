using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceFighter
{
    static class LevelManager
    {
        public static int levelNummer { set; get; }



        public static void loadLevel()
        {
            int tileStartY = 72;
            int tileStartX = 128;

            if (levelNummer % 3 == 1)
            {
                tileStartX = tileStartX * 0;
                tileStartY = tileStartY * (levelNummer / 3);
            }
            else if (levelNummer % 3 == 2)
            {
                tileStartX = tileStartX * 1;
                tileStartY = tileStartY * (levelNummer / 3);
            }
            else if (levelNummer % 3 == 0)
            {
                tileStartX = tileStartX * 2;
                tileStartY = tileStartY * (levelNummer / 3 - 1);
            }

            readLevelData(tileStartX, tileStartY);
        }

        static public void readLevelData(int tileStartX, int tileStartY)
        {
            Texture2D map = Art.MapSet1;
            Color[] colors1D = new Color[128 * 72];
            Rectangle rect = new Rectangle(tileStartX, tileStartY, 128, 72);
            map.GetData<Color>(0, rect, colors1D, 0, colors1D.Length);

            spawnBases(colors1D);
        }

        static private void spawnBases(Color[] map)
        {
            int xPostion = 1;
            int yPostion = 1;
            foreach (Color col in map)
            {
                if (col == Color.Black)
                {
                    EntityManager.Add(EnemyBase.CraateBase(new Vector2(xPostion * 10, yPostion * 10)));
                }
                else if (col == Color.Blue)
                {
                    EntityManager.Add(EnemyBase.CraateBase(new Vector2(xPostion * 10, yPostion * 10)));
                }
                if (xPostion >= 128)
                {
                    xPostion = 0;
                    yPostion++;
                }
                xPostion++;
            }
        }
    }
}
