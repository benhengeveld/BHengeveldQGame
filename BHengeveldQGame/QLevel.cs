/*  Program: QLevel.cs
 *  
 *  Assignment: 3
 *  
 *  Description: Handles the Level for Q Game
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.10.09: Created
 *      Ben Hengeveld, 2021.11.27: Added a method to count the number of boxes and moves and to move a box in a direction
 *      Ben Hengeveld, 2021.11.28: Added a new parsing method
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHengeveldQGame
{
    /// <summary>
    /// A class that handles the layout and logic of a q level in design or playing
    /// </summary>
    public class QLevel
    {
        //Items that can be in a level
        public enum Items
        {
            None,
            Wall,
            RedDoor,
            GreenDoor,
            RedBox,
            GreenBox
        }
        public enum Directions
        {
            None,
            Up,
            Down,
            Left,
            Right
        }

        //An array the holds the layout of items in a level
        private Items[,] levelLayout;

        private Vector2 selectedBox;
        private int numberOfMoves = 0;
        public Vector2 SelectedBox { get => selectedBox; set => selectedBox = value; }
        public int NumberOfMoves { get => numberOfMoves; set => numberOfMoves = value; }

        /// <summary>
        /// Sets up a new blank level with a given number of rows and columns
        /// </summary>
        /// <param name="numOfRows">Number of rows for the level</param>
        /// <param name="numOfColumns">Number of columns for the level</param>
        public QLevel(int numOfRows, int numOfColumns)
        {
            //Make sure the amount of rows and columns are greater then 0
            if (numOfRows <= 0 || numOfColumns <= 0)
            {
                throw new Exception("The number of rows and columns must be greater then 0!");
            }

            //Set up a new blank level layout
            this.levelLayout = new Items[numOfRows, numOfColumns];
        }

        /// <summary>
        /// Sets up a level based on a given layout of items, like what you get from the parser
        /// </summary>
        /// <param name="levelLayout">The layout of items</param>
        public QLevel(Items[,] levelLayout)
        {
            //Sets the levels layout to the one given
            this.levelLayout = levelLayout;
        }

        /// <summary>
        /// Gets the item of a position in the level
        /// </summary>
        /// <param name="x">The x position of the box to check</param>
        /// <param name="y">The y position of the box to check</param>
        /// <returns>The item in the given position</returns>
        public Items GetPositionsItem(int x, int y)
        {
            //Check if the position given is a position in the level
            if (x < 0 || x > levelLayout.GetLength(1) || y < 0 || y > levelLayout.GetLength(0))
            {
                throw new Exception("Position out of bounds");
            }

            //Gets the item in the given position and returns the item found
            Items item = levelLayout[y, x];
            return item;
        }

        /// <summary>
        /// Gets the width of the q level
        /// </summary>
        /// <returns>Returns the width</returns>
        public int GetWidth()
        {
            //gets the width of the level and return the width
            int levelWidth = levelLayout.GetLength(1);
            return levelWidth;
        }
        /// <summary>
        /// Gets the height of the q level
        /// </summary>
        /// <returns>Returns the height</returns>
        public int GetHeight()
        {
            //gets the height of the level and return the height
            int levelHeight = levelLayout.GetLength(0); ;
            return levelHeight;
        }

        /// <summary>
        /// Updates a box to a new item
        /// </summary>
        /// <param name="x">The x position of the box to update</param>
        /// <param name="y">The y position of the box to update</param>
        /// <param name="item">The item to update the box to</param>
        public void UpdateBox(int x, int y, Items item)
        {
            //Check if the position given is a position in the level
            if (x < 0 || x > levelLayout.GetLength(1) || y < 0 || y > levelLayout.GetLength(0))
            {
                throw new Exception("Position out of bounds");
            }

            //Update the item in the given position to the given item
            levelLayout[y, x] = item;
        }

        /// <summary>
        /// Moves a box in a direction until it hits something else or goes in a door
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Vector2 MoveBox(int x, int y, Directions direction)
        {
            //If no direction return
            if (direction == Directions.None)
                return new Vector2(-1, -1);

            //Get the box in the given position
            Items boxesItem = GetPositionsItem(x, y);

            //Gets the x and y direction of the box
            Vector2 change = new Vector2(0 ,0);
            if (direction == Directions.Up)
            {
                change.Y = -1;
            }
            else if (direction == Directions.Down)
            {
                change.Y = 1;
            }
            else if (direction == Directions.Left)
            {
                change.X = -1;
            }
            else if (direction == Directions.Right)
            {
                change.X = 1;
            }

            Vector2 newPosition = new Vector2(x, y);
            Items newPositionsItem = boxesItem;

            Items nextPosItem = Items.None;
            //Check if the next spot is still in the level
            if (newPosition.X + change.X >= 0 && newPosition.Y + change.Y >= 0
                && newPosition.X + change.X < levelLayout.GetLength(1) && newPosition.Y + change.Y < levelLayout.GetLength(0))
            {
                //Get the item in the next spot
                nextPosItem = GetPositionsItem(newPosition.X + change.X, newPosition.Y + change.Y);
            }
            //Loop until the spot is out of the level or the next item is not empty
            while (newPosition.X + change.X >= 0 && newPosition.Y + change.Y >= 0 
                && newPosition.X + change.X < levelLayout.GetLength(1) && newPosition.Y + change.Y < levelLayout.GetLength(0)
                && nextPosItem == Items.None)
            {
                //Go to the next spot
                newPosition.X += change.X;
                newPosition.Y += change.Y;
                newPositionsItem = nextPosItem;

                //Check if the next spot is still in the level
                if (newPosition.X + change.X >= 0 && newPosition.Y + change.Y >= 0
                    && newPosition.X + change.X < levelLayout.GetLength(1) && newPosition.Y + change.Y < levelLayout.GetLength(0))
                {
                    //Get the item in the next spot
                    nextPosItem = GetPositionsItem(newPosition.X + change.X, newPosition.Y + change.Y);
                }
            }

            //The the item one spot over in the given direction matches the color of box
            if (nextPosItem == Items.RedDoor && boxesItem == Items.RedBox)
            {
                //Remove the box
                UpdateBox(x, y, Items.None);

                //Add one to the number of moves
                numberOfMoves++;

                //Return
                return new Vector2(-1, -1);
            }
            else if (nextPosItem == Items.GreenDoor && boxesItem == Items.GreenBox)
            {
                //Remove the box
                UpdateBox(x, y, Items.None);

                //Add one to the number of moves
                numberOfMoves++;

                //Return
                return new Vector2(-1, -1);
            }
            //If the box did not go through a door
            else if (newPositionsItem == Items.None && (newPosition.X != x || newPosition.Y != y))
            {
                //Remove the old box
                UpdateBox(x, y, Items.None);
                //Move the box to the new position
                UpdateBox(newPosition.X, newPosition.Y, boxesItem);

                //The selected position is no where the moved box is
                selectedBox = newPosition;

                //Add one to the number of moves
                numberOfMoves++;
            }

            //Return the position the box moved to
            return newPosition;
        }

        /// <summary>
        /// Gets the number of boxes left in the level layout
        /// </summary>
        /// <returns>The number of boxes in the level layout</returns>
        public int GetBoxCount()
        {
            int boxCount = 0;

            //Loop through the level layout
            for (int y = 0; y < levelLayout.GetLength(0); y++)
            {
                for (int x = 0; x < levelLayout.GetLength(1); x++)
                {
                    //Get the item in the position
                    Items posItems = GetPositionsItem(x, y);
                    //If the item is a red or green box add 1 to the box count
                    if (posItems == Items.RedBox || posItems == Items.GreenBox)
                        boxCount++;
                }
            }

            return boxCount;
        }

        /// <summary>
        /// Turns the layout of the level to a string
        /// </summary>
        /// <returns>Returns a string of the layout of the level</returns>
        public override string ToString()
        {
            string returnString = "";

            //Goes through every item in the level
            for (int y = 0; y < levelLayout.GetLength(0); y++)
            {
                for (int x = 0; x < levelLayout.GetLength(1); x++)
                {
                    //Adds a item to the return string with a comma
                    returnString += $"{levelLayout[y, x].ToString()},";
                }
                //Removes the comma at the end of a line and then adds a new line
                returnString = returnString.Trim(',');
                returnString += "\n";
            }

            return returnString.Trim('\n');
        }

        /// <summary>
        /// Takes a string (string from the tostring in this class) and turns it into a QLevel
        /// </summary>
        /// <param name="parseString">The string to turn into a q level</param>
        /// <returns>Returns the new q level</returns>
        public static QLevel Parse(string parseString)
        {
            //Split the string by new lines
            string[] splitString = parseString.Split('\n');

            //Gets the number of rows and columns from the string
            int numOfRows = splitString.GetLength(0);
            int numOfColumns = splitString[0].Split(',').GetLength(0);
            //Make an 2d array of items with the number of rows and columns
            Items[,] itemArray = new Items[numOfRows, numOfColumns];

            //Go through every line from the split string
            for (int y = 0; y < splitString.GetLength(0); y++)
            {
                //Split the line by commas
                string[] splitLine = splitString[y].Split(',');
                //Go through every item in the split line
                for (int x = 0; x < splitLine.GetLength(0); x++)
                {
                    //Add the item to the item array based on the string in the split line
                    switch (splitLine[x])
                    {
                        case "None":
                            itemArray[y, x] = Items.None;
                            break;

                        case "Wall":
                            itemArray[y, x] = Items.Wall;
                            break;

                        case "RedDoor":
                            itemArray[y, x] = Items.RedDoor;
                            break;

                        case "GreenDoor":
                            itemArray[y, x] = Items.GreenDoor;
                            break;

                        case "RedBox":
                            itemArray[y, x] = Items.RedBox;
                            break;

                        case "GreenBox":
                            itemArray[y, x] = Items.GreenBox;
                            break;

                        default:
                            //Try diffrent parsing method
                            try
                            {
                                return ParseTwo(parseString);
                            }
                            catch (Exception)
                            {
                                throw new Exception("Failed parse! Invlid QLevel data!");
                            }
                    }
                }
            }

            //Make and return the new parsed q level
            QLevel newQLevel = new QLevel(itemArray);
            return newQLevel;
        }

        /// <summary>
        /// Trys to parse based on the layout given on econestoga
        /// </summary>
        /// <param name="parseString">The string to parse</param>
        /// <returns>The new parse q level</returns>
        public static QLevel ParseTwo(string parseString)
        {
            //Split the string by new lines
            string[] splitString = parseString.Split('\n');

            try
            {
                //Gets the number of rows and columns from the string
                int numOfRows = int.Parse(splitString[0]);
                int numOfColumns = int.Parse(splitString[1]);
                //Make an 2d array of items with the number of rows and columns
                Items[,] itemArray = new Items[numOfRows, numOfColumns];

                //Go through every item in the split string
                for (int i = 2; i < splitString.Length; i += 3)
                {
                    //Get the tiles row, column and item id
                    int tileRow = int.Parse(splitString[i]);
                    int tileColumn = int.Parse(splitString[i + 1]);
                    int tileType = int.Parse(splitString[i + 2]);

                    //Set item to array using the item id
                    switch (tileType)
                    {
                        case 0:
                            itemArray[tileRow, tileColumn] = Items.None;
                            break;

                        case 1:
                            itemArray[tileRow, tileColumn] = Items.Wall;
                            break;

                        case 2:
                            itemArray[tileRow, tileColumn] = Items.RedDoor;
                            break;

                        case 3:
                            itemArray[tileRow, tileColumn] = Items.GreenDoor;
                            break;

                        case 6:
                            itemArray[tileRow, tileColumn] = Items.RedBox;
                            break;

                        case 7:
                            itemArray[tileRow, tileColumn] = Items.GreenBox;
                            break;

                        default:
                            throw new Exception("Failed parse! Invlid QLevel data!");
                    }
                }

                //Make and return the new parsed q level
                QLevel newQLevel = new QLevel(itemArray);
                return newQLevel;
            }
            catch (Exception)
            {
                throw new Exception("Failed parse! Invlid QLevel data!");
            }
        }
    }
}
