using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    abstract class Enemey :GameObject
    {
        bool flag2;
        public Enemey(Image image, GameCell Cell) : base(GameObjectType.Enemy, image)
        {
            
        }
        public abstract GameCell move();
        public abstract bool collisionDetection(PlayerCar player);
        public abstract bool bulletDetection(PlayerCar player);

        public void SetFlag2()
        {
            flag2 = false;
        }
        public bool GetFlag2()
        {
            return flag2;
        }
    }
}
