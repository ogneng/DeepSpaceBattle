using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSpaceBattles
{
    public class Weapon1
    {
        public Image weapon { get; set; }
        public Image weapon2 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private int speed { get; set; }
        private bool b { get; set; }

        public Weapon1(int X, int Y,bool b)
        {
            this.b = b;
            if (b) weapon = DeepSpaceBattles.Properties.Resources.Bullet;
            else weapon2 = DeepSpaceBattles.Properties.Resources.Bullet2;


            this.X = X;
            this.Y = Y;
            speed = 30;
        }

        public void moveWeapon1ForPlayer(){
            Y -= speed;
        }
        public void moveWeapon1ForEnemy()
        {
            Y += speed - 20;
        }

        public void Draw(Graphics g)
        {
            if(b)
            g.DrawImage(weapon, X, Y,weapon.Width,weapon.Height);
            else g.DrawImage(weapon2, X, Y, weapon2.Width, weapon2.Height);
        }
        
    }
}
