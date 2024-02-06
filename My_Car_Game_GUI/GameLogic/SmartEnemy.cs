using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class SmartEnemy : Enemey
    {
        GameDirection direction;
        PlayerCar player;
        int speed;
        public SmartEnemy(Image image, GameCell cell, int speed, PlayerCar player) : base(image, cell)
        {
            this.CurrentCell = cell;
            this.speed = speed;
            this.player = player;
            
        }

        public override GameCell move()
        {
            if (speed % 1029 == 0)
            {
                manageDirections();
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);
                this.CurrentCell = nextCell;

                if (currentCell != nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());

                }


                return nextCell;
            }
            speed++;
            return this.CurrentCell;
        }

        public void manageDirections()
        {
            double[] distance = new double[4] { 10000, 10000, 10000, 10000 };
            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType != GameObjectType.Wall)
            {
                distance[0] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Left));
            }
            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType != GameObjectType.Wall)
            {
                distance[1] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Right));
            }
            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType != GameObjectType.Wall)
            {
                distance[2] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Up));
            }
            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType != GameObjectType.Wall)
            {
                distance[3] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Down));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                this.direction = GameDirection.Left;

            }
            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                this.direction = GameDirection.Right;

            }
            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                this.direction = GameDirection.Up;

            }
            if (distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                this.direction = GameDirection.Down;

            }
        }
        public double calculateDistance(GameCell nextcell)
            {
                return Math.Sqrt(Math.Pow((player.CurrentCell.X - nextcell.X), 2) + Math.Pow((player.CurrentCell.Y - nextcell.Y), 2));
            }


        //public override GameCell move()
        //{
        //    GameCell currentCell = this.CurrentCell;
        //    GameCell nextCell = currentCell.nextCell(direction);
        //    this.CurrentCell = nextCell;
        //    if (speed % 2 == 0)
        //    {
        //        if (currentCell == nextCell)
        //        {
        //            Set();
        //        }
        //        else if (currentCell != nextCell)
        //        {
        //            currentCell.setGameObject(Game.getBlankGameObject());
        //        }
        //        return nextCell;
        //    }
        //    speed++;
        //    return this.CurrentCell;
        //}
        //public void Set()
        //{
        //    if (player.CurrentCell.X > this.CurrentCell.X)
        //    {
        //        direction = GameDirection.Down;
        //    }
        //    if (player.CurrentCell.X < this.CurrentCell.X)
        //    {
        //        direction = GameDirection.Up;
        //    }
        //    if (player.CurrentCell.Y > this.CurrentCell.Y)
        //    {
        //        direction = GameDirection.Right;
        //    }
        //    if (player.CurrentCell.X < this.CurrentCell.X)
        //    {
        //        direction = GameDirection.Left;
        //    }
        //}
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
