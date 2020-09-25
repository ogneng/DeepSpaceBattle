using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSpaceBattles
{
    public class BossWeapon
    {
        public Image bossWeapon { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private int speed { get; set; }


        public BossWeapon(int X, int Y)
        {
            bossWeapon = DeepSpaceBattles.Properties.Resources.bossbomb;
            this.X = X;
            this.Y = Y;
            speed = 10;
        }

        public void moveBossWeapon(){
            Y += speed;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(bossWeapon, X, Y,bossWeapon.Width,bossWeapon.Height);            
        }
    }
}
