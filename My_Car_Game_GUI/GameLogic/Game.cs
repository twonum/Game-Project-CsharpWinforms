using My_Car_Game_GUI.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace My_Car_Game_GUI
{
    public class Game
    {
        static int score = 0;
        static bool flag = true;
        public static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.Y, gameObject.CurrentCell.X);
            Console.Write(gameObject.DisplayCharacter);
        }

        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.None, My_Car_Game_GUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = My_Car_Game_GUI.Properties.Resources.simplebox;

            if (displayCharacter == '#' || displayCharacter == '|' || displayCharacter == '-')
            {
                img = My_Car_Game_GUI.Properties.Resources._1;
            }

            if (displayCharacter == 'l')
            {
                img = My_Car_Game_GUI.Properties.Resources.arrowLeft;
            }
            if (displayCharacter == 'u')
            {
                img = My_Car_Game_GUI.Properties.Resources.arrowUp;
            }
            if (displayCharacter == 'd')
            {
                img = My_Car_Game_GUI.Properties.Resources.arrowDown;
            }
            if (displayCharacter == 'C' || displayCharacter == 'c')
            {
                img = My_Car_Game_GUI.Properties.Resources.car;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = My_Car_Game_GUI.Properties.Resources.police;
            }
            if (displayCharacter == 'H' || displayCharacter == 'h')
            {
                img = My_Car_Game_GUI.Properties.Resources.horCar2;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = My_Car_Game_GUI.Properties.Resources.vertical1;
            }
            if (displayCharacter == 'R' || displayCharacter == 'r')
            {
                img = My_Car_Game_GUI.Properties.Resources.rand;
            }

            return img;
            //return null;
        }
        public static void SetFlag()
        {
            flag = false;
        }
        public static void AddScore()
        {
            score++;

        }


        //public static void clearGameCellContent(GameCell cell,GameObject newGameObject)
        //{
        //    cell.CurrentGameObject = newGameObject;
        //    Console.SetCursorPosition(cell.Y, cell.X);
        //    Console.Write(newGameObject.displayCharacter); 
        //}

        /*public static void moveObject(GameObject gameObject,GameDirection direction)
        {

            GameCell currentCell = gameObject.currentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            gameObject.currentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }


            GameCell next = gameObject.currentCell.nextCell(direction);
            if (next != null)
            {
                GameObject newGo = new GameObject(' ', GameObjectType.None);
                GameCell currentcell = gameObject.currentCell;
                clearGameCellContent(currentcell, newGo);
                currentcell.setGameObject(newGo);
                gameObject.currentCell = next;
                printGameObject(gameObject);
            }
            else
            {
                getBlankGameObject();
            }
        }*/

    }
    
}
