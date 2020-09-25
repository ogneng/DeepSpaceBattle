using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSpaceBattles
{
    public class PlayerSpaceship
    {
        private Image PlayerPlaneNormal;
        private Image PlayerPlaneLeft;
        private Image PlayerPlaneRight;
        private List<Weapon1> weapons1;

        public int life {get;set;}
        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        public enum Pictures
        {
            normal,
            left,
            right
        }
        public Pictures pics;

        public int X { get; set; }
        public int Y { get; set; }

        public PlayerSpaceship(Pictures p) {
            PlayerPlaneNormal = DeepSpaceBattles.Properties.Resources.PlayerPlaneNormal;
            PlayerPlaneLeft = DeepSpaceBattles.Properties.Resources.PlayerPlaneLeft1;
            PlayerPlaneRight = DeepSpaceBattles.Properties.Resources.PlayerPlaneRight1;
            weapons1 = new List<Weapon1>();
            life = 3;
            pics = p;
            X = 500;
            Y = 520;
        }

        public void LoseLife()
        {
            life--;
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void ChangePicture(Pictures p)
        {
            pics = p;
        }

        public void Draw(Graphics g)
        {
            if(pics.Equals(Pictures.normal)){
                g.DrawImage(PlayerPlaneNormal, X, Y, PlayerPlaneNormal.Width, PlayerPlaneNormal.Height);
            }
            else if (pics.Equals(Pictures.left))
            {
                g.DrawImage(PlayerPlaneLeft, X, Y, PlayerPlaneLeft.Width, PlayerPlaneLeft.Height);
            }
            else if (pics.Equals(Pictures.right))
            {
                g.DrawImage(PlayerPlaneRight, X, Y, PlayerPlaneRight.Width, PlayerPlaneRight.Height);
            } 
        }

        public void AddWeapon1()
        {
            weapons1.Add(new Weapon1(X + 19, Y, true));
        }
        public void RemoveWeapon1(int i)
        {
            weapons1.Remove(weapons1[i]);
        }
        public void MoveTheWeapon(int i)
        {
            weapons1[i].moveWeapon1ForPlayer();
        }
        public List<Weapon1> getWeapon1()
        {
            return weapons1;
        }


        public bool GetHit(Rectangle rec)
        {
            Rectangle newRec = new Rectangle(X, Y, PlayerPlaneNormal.Width, PlayerPlaneNormal.Height);
            if (newRec.IntersectsWith(rec))
            {
                return true;
            }
            else return false;
        }
    }
}
