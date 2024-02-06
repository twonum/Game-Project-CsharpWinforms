using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class HorizontalEnemy : Enemey
    {
        GameDirection direction;
        public HorizontalEnemy(Image image, GameCell cell, GameDirection d) : base(image, cell)
        {
            this.direction = d;
            this.CurrentCell = cell;
        }
        public override GameCell move()
        {
            GameCell current = this.CurrentCell;
            GameCell next = CurrentCell.nextCell(direction);
            this.CurrentCell = next;
            if (current == next)
            {
                if (this.direction == GameDirection.Left)
                {
                    this.direction = GameDirection.Right;
                }
                else if (this.direction == GameDirection.Right)
                {
                    this.direction = GameDirection.Left;
                }
            }
            else
            {
                current.setGameObject(Game.getBlankGameObject());
            }
            return next;
        }
        public override bool collisionDetection(PlayerCar player)
        {
            bool flag = false;
            if (player.CurrentCell.X == this.CurrentCell.X && player.CurrentCell.Y == this.CurrentCell.Y)
            {
                flag = true;
            }
            return flag;
        }
        public override bool bulletDetection(PlayerCar player)
        {
            bool flag = false;
            if (CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.Fire || CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.Fire || CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.Fire)
            {
                flag = true;
            }
            return flag;
        }
    }
}
