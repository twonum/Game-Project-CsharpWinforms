using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    internal class PlayerCar : GameObject
    {
        bool flag = true;
        public PlayerCar(GameCell startCell, Image image) : base(GameObjectType.Player, image)
        {
            this.CurrentCell = startCell;
            flag = true;
        }
        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.Reward)
            {
                Game.AddScore();

            }

            if (CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.EnemyFire || CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.EnemyFire
                || CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.EnemyFire || CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.EnemyFire)
            {
                setPlayerFlag(false);

            }

            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }


            return nextCell;
        }
        public void setPlayerFlag(bool flag)
        {
            this.flag = flag;
        }
        public bool getFlag()
        {
            return this.flag;
        }
    }
}
