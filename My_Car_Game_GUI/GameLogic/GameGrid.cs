using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Drawing;
namespace My_Car_Game_GUI.GameLogic
{
    public class GameGrid
    {
        public int Rows;
        public int Columns;
        public GameCell[,] cells;
        public GameGrid(string filename,int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            cells = new GameCell[Rows, Columns];
            loadGrid(filename);
        }
        private void loadGrid(string filename)
        {
            StreamReader fp = new StreamReader(filename);
            string record;
            for (int row = 0; row < this.Rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < this.Columns; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    Char displayCharacter = record[col];
                    GameObjectType t = GameObject.getGameObjectType(displayCharacter);
                    Image displayIamge = Game.getGameObjectImage(displayCharacter);
                    GameObject gameObject = new GameObject(t, displayIamge);
                    cell.setGameObject(gameObject);
                    cells[row, col] = cell;
                }
            }
            fp.Close();
        }
        public GameCell getCell(int x, int y)
        {
            return cells[x, y];
        }
    }
}
