using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSpaceBattles
{
    public class EnemySpaceship
    {
        private Image enemy1;

        public int X { get; set; }
        public int Y { get; set; }

        private List<Weapon1> weapons1;

        public EnemySpaceship(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            enemy1 = DeepSpaceBattles.Properties.Resources.enemy2_1;
            weapons1 = new List<Weapon1>();
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(enemy1, X, Y,enemy1.Width,enemy1.Height);
        }

        public void move1(int width)
        {
            X += 7;
        }

        public bool isDestroyed(Rectangle rec)
        {
            Rectangle newRec = new Rectangle(X, Y, enemy1.Width, enemy1.Height);
            if (newRec.IntersectsWith(rec))
            {
                return true;
            }
            else return false;
        }

        public void AddWeaponToEnemies()
        {
            weapons1.Add(new Weapon1(X + 34, Y + 80, false));
        }
        public void RemoveWeapon1(int i)
        {
            weapons1.Remove(weapons1[i]);
        }
        public void MoveTheWeapon(int i)
        {
            weapons1[i].moveWeapon1ForEnemy();
        }
        public List<Weapon1> getWeapon1()
        {
            return weapons1;
        }
    }
}
