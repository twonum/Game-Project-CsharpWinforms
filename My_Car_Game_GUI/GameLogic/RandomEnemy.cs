using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class RandomEnemy : Enemey
    {
        int random;
        public RandomEnemy(Image image, GameCell cell) : base(image, cell)
        {
            this.CurrentCell = cell;
            this.CurrentCell.PictureBox.Height = 20;
            this.CurrentCell.PictureBox.Width = 20;
        }

        public override GameCell move()
        {
            Random rand = new Random();
            random = rand.Next(4);
            if (random == 0)
            {
                GameCell current = this.CurrentCell;
                GameCell next = current.nextCell(GameDirection.Left);
                if (next.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                {
                    this.CurrentCell = next;
                    if (next != current)
                    {
                        current.setGameObject(Game.getBlankGameObject());
                    }
                }
            }
            else if (random == 1)
            {
                GameCell current = this.CurrentCell;
                GameCell next = current.nextCell(GameDirection.Right);
                if (next.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                {
                    this.CurrentCell = next;
                    if (next != current)
                    {
                        current.setGameObject(Game.getBlankGameObject());
                    }
                }
            }
            else if (random == 2)
            {
                GameCell current = this.CurrentCell;
                GameCell next = current.nextCell(GameDirection.Up);
                if (next.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                {
                    this.CurrentCell = next;
                    if (next != current)
                    {
                        current.setGameObject(Game.getBlankGameObject());
                    }
                }
            }
            else if (random == 3)
            {
                GameCell current = this.CurrentCell;
                GameCell next = current.nextCell(GameDirection.Down);
                if (next.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                {
                    this.CurrentCell = next;
                    if (next != current)
                    {
                        current.setGameObject(Game.getBlankGameObject());
                    }
                }
            }
            return null;

        }
        public override bool collisionDetection(PlayerCar player)
        {
            bool flag = false;
            if (GameObjectType.Player == this.CurrentCell.CurrentGameObject.Type)
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
