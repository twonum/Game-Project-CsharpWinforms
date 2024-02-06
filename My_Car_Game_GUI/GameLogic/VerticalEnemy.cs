using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class VerticalEnemy : Enemey
    {
        GameDirection Direction;
        public VerticalEnemy(Image image, GameCell cell, GameDirection d) : base(image, cell)
        {
            this.Direction = d;
            this.CurrentCell = cell;
            this.CurrentCell.PictureBox.Height = 20;
            this.CurrentCell.PictureBox.Width = 20;
        }
        public override GameCell move()
        {
            GameCell current = this.CurrentCell;
            GameCell next = CurrentCell.nextCell(Direction);
            this.CurrentCell = next;
            if (current == next)
            {
                if (this.Direction == GameDirection.Up)
                {
                    this.Direction = GameDirection.Down;
                }
                else if (this.Direction == GameDirection.Down)
                {
                    this.Direction = GameDirection.Up;
                }
            }
            if (current != next)
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
            return false;
        }
    }
}
