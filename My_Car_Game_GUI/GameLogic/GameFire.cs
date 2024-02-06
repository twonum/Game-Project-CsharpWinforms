using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class GameFire : GameObject
    {
        bool flag1 = true;
        bool flag2 = true;
        
        public GameFire(GameCell startCell, Image image,GameObjectType type) : base(type, image)
        {
            this.CurrentCell = startCell;
            this.Image = image;
            this.Type = type;
        }

        public GameCell moveEnemyFire(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = grid.getCell(CurrentCell.X + 1, CurrentCell.Y);
            if (nextCell.CurrentGameObject.Type != GameObjectType.Wall)
            {
                if (nextCell!=null)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    CurrentCell = nextCell;
                    return nextCell;
                }
            }
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.Wall)
                {
                    SetFlag();

                }

                return null;
        }
        public GameCell MovePlayerFire(GameGrid grid)
        {
            GameCell currentCell = this.CurrentCell;

            GameCell nextCell = grid.getCell(CurrentCell.X - 1, CurrentCell.Y);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.Enemy)
            {

                SetFlag2();

            }
            if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.Wall)
            {
                if (nextCell != null)
                {

                    currentCell.setGameObject(Game.getBlankGameObject());
                    CurrentCell = nextCell;
                    return nextCell;
                }


            }

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.Wall)
            {
                SetFlag();

            }
            return null;
        }

        public void SetFlag2()
        {
            flag2 = false;
        }
        public bool GetFlag2()
        {
            return flag2;
        }

        public void SetFlag()
        {
            flag1 = false;
        }
        public bool GetFlag()
        {
            return flag1;
        }
    }
}
