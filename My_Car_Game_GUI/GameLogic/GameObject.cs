using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace My_Car_Game_GUI.GameLogic
{
    public class GameObject
    {
        private char displayCharacter;
        private GameObjectType type;
        private GameCell currentCell;
        private Image image;

        public GameObject(GameObjectType type, Image image)
        {
            this.Type = type;
            this.Image = image;
            
        }
        
        public GameObject(char displayCharacter, GameObjectType gameObjectType)
        {
            this.displayCharacter = displayCharacter;
            this.Type = gameObjectType;
        }
        public static GameObjectType getGameObjectType(char displayCharacter)
        {
            if (displayCharacter == '|' || displayCharacter == '-' || displayCharacter == '#')
            {
                return GameObjectType.Wall;
            }

            if (displayCharacter == '.')
            {
                return GameObjectType.Reward;
            }

            return GameObjectType.None;

        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => Type; set => Type = value; }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }

        public Image Image { get => image; set => image = value; }
        public GameObjectType Type { get => type; set => type = value; }
    }
}
