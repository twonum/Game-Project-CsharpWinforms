using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    public class GameCell
    {
        private int row;
        private int col;
        private GameObject currentGameObject;
        PictureBox pictureBox;
        public GameGrid grid;
        const int width =  30;
        const int height = 30;

        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        public GameCell(int x, int y,  GameGrid grid)
        {
            this.X = x;
            this.Y = y;
            PictureBox = new PictureBox();
            PictureBox.Left = width*y;
            PictureBox.Top = height*x;
            PictureBox.Size= new Size(width, height);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }
        public void setGameObject(GameObject gameObject)
        {
            CurrentGameObject = gameObject;
            PictureBox.Image = gameObject.Image;
        }
        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.Left)
            {
                if (this.Y > 0)
                {
                    GameCell ncell = grid.getCell(X, Y - 1);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == GameDirection.Right)
            {
                if (this.Y < grid.Columns - 1)
                {
                    GameCell ncell = grid.getCell(this.X, this.Y + 1);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == GameDirection.Up)
            {
                if (this.X > 0)
                {
                    GameCell ncell = grid.getCell(this.X - 1, this.Y);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == GameDirection.Down)
            {
                if (this.X < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.X + 1, this.Y);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }

        public GameCell nextCellForWallBreaker(GameDirection direction)
        {
            if (direction == GameDirection.Left)
            {
                    GameCell ncell = grid.getCell(X, Y - 1);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                
            }
            
                if (this.Y < grid.Columns - 1)
                {
                    GameCell ncell = grid.getCell(this.X, this.Y + 1);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            
            if (direction == GameDirection.Up)
            {
                if (this.X > 0)
                {
                    GameCell ncell = grid.getCell(this.X - 1, this.Y);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            }
            
                if (this.X < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.X + 1, this.Y);
                    if (ncell.CurrentGameObject.Type != GameObjectType.Wall)
                    {
                        return ncell;
                    }
                }
            
            return this; // if can not return next cell return its own reference
        }
    }
}
