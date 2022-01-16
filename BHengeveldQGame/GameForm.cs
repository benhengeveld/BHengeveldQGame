/*  Program: ControlPanelForm.cs
 *  
 *  Assignment: 3
 *  
 *  Description: Handles the form for a user to design and save a level for Q game
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.11.27: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHengeveldQGame
{
    /// <summary>
    /// A form that lets the user play a q level
    /// </summary>
    public partial class GameForm : Form
    {
        //Numbers for position and sizing picture boxes
        private const int STARTING_X = 25;
        private const int STARTING_Y = 50;
        private const int BOX_SIZE = 70;
        private const int BOX_GAP = 3;

        //The current q level and the levels picture boxes
        private QLevel currentQLevel;
        private PictureBox[,] levelsPictures;

        /// <summary>
        /// Generates the picture boxes for a q level based on a height and width and then loads the pictures
        /// </summary>
        /// <param name="height">The height of the level</param>
        /// <param name="width">The width of the level</param>
        public void GenerateLevel(int height, int width)
        {
            levelsPictures = new PictureBox[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //Generate a new picture box
                    PictureBox newPicBox = new PictureBox();
                    newPicBox.Size = new Size(BOX_SIZE, BOX_SIZE);
                    newPicBox.Location = new Point((BOX_SIZE + BOX_GAP) * x + STARTING_X, (BOX_SIZE + BOX_GAP) * y + STARTING_Y);
                    //Set the new picture boxes image to a blank image
                    newPicBox.Image = Properties.Resources.BlankImage;
                    newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Adds the event if the picture box is clicked
                    newPicBox.Click += BoxClicked;
                    //Adds the new picture box to the form and array
                    this.Controls.Add(newPicBox);
                    levelsPictures[x, y] = newPicBox;
                    //Updates the picture boxes image so if it was loaded it will have the right image
                    UpdateBoxGui(x, y);
                }
            }
        }

        /// <summary>
        /// Updates the image of a picture box based on the q level
        /// </summary>
        /// <param name="x">The x position of the box to update</param>
        /// <param name="y">The y position of the box to update</param>
        public void UpdateBoxGui(int x, int y)
        {
            //Gets the item in the given position
            QLevel.Items item = currentQLevel.GetPositionsItem(x, y);

            //Gets what the image should be based on the item
            Image newImage = Properties.Resources.BlankImage;
            switch (item)
            {
                case QLevel.Items.None:
                    newImage = Properties.Resources.BlankImage;
                    break;

                case QLevel.Items.Wall:
                    newImage = Properties.Resources.WallImage;
                    break;

                case QLevel.Items.RedDoor:
                    newImage = Properties.Resources.RedDoorImage;
                    break;

                case QLevel.Items.GreenDoor:
                    newImage = Properties.Resources.GreenDoorImage;
                    break;

                case QLevel.Items.RedBox:
                    //Checks if the given spot is selected or not and loads the selected image if so
                    if (currentQLevel.SelectedBox != null && currentQLevel.SelectedBox.X == x && currentQLevel.SelectedBox.Y == y)
                        newImage = Properties.Resources.RedBoxImageSelected;
                    else
                        newImage = Properties.Resources.RedBoxImage;
                    break;

                case QLevel.Items.GreenBox:
                    //Checks if the given spot is selected or not and loads the selected image if so
                    if (currentQLevel.SelectedBox != null && currentQLevel.SelectedBox.X == x && currentQLevel.SelectedBox.Y == y)
                        newImage = Properties.Resources.GreenBoxImageSelected;
                    else
                        newImage = Properties.Resources.GreenBoxImage;
                    break;

                default:
                    break;
            }

            //Get the picture box to update
            PictureBox picBoxToUpdate = levelsPictures[x, y];

            //Change the image to the new one given
            picBoxToUpdate.Image = newImage;
            picBoxToUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Unloads all the picture boxes
        /// </summary>
        public void UnloadBoxs()
        {
            //Check if there is any picture boxs to unload
            if (levelsPictures != null)
            {
                //Go through all the picture boxes
                foreach (PictureBox item in levelsPictures)
                {
                    //If there is a picture box in that spot unload it
                    if (item != null)
                    {
                        item.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Gets the position in the qlevel of a picture box
        /// </summary>
        /// <param name="picBox">The picture box to get the position of</param>
        /// <returns>The array pos of the picture box</returns>
        private Vector2 GetBoxPos(PictureBox picBox)
        {
            Vector2 pos = new Vector2(0, 0);

            //Go through all the picture boxes in the levelsPictures array
            for (int x = 0; x < levelsPictures.GetLength(0); x++)
            {
                for (int y = 0; y < levelsPictures.GetLength(1); y++)
                {
                    //If the picture box matches the one given then set the x and y to the picture box
                    if (levelsPictures[x, y] == picBox)
                    {
                        pos = new Vector2(x, y);
                        break;
                    }
                }
            }

            return pos;
        }

        /// <summary>
        /// Sets the clicked picture box to selected in the q level
        /// </summary>
        /// <param name="newSelectedBox">the picture box to set as selected</param>
        private void SelectBox(PictureBox newSelectedBox)
        {
            //Get the position in the q level of the picture box
            Vector2 newSelectedPos = GetBoxPos(newSelectedBox);

            //Get the item of the picture box
            QLevel.Items item = currentQLevel.GetPositionsItem(newSelectedPos.X, newSelectedPos.Y);

            //If the item is a box
            if (item == QLevel.Items.RedBox || item == QLevel.Items.GreenBox)
            {
                //Save the old selected position
                Vector2 oldSelectedPos = currentQLevel.SelectedBox;

                //Set the new selected position to the gievn one
                currentQLevel.SelectedBox = newSelectedPos;

                //If there was an old selected pos update to image to one that was not selected
                if(oldSelectedPos != null)
                    UpdateBoxGui(oldSelectedPos.X, oldSelectedPos.Y);

                //Update the new selected box
                UpdateBoxGui(newSelectedPos.X, newSelectedPos.Y);
            }
        }

        /// <summary>
        /// Reset the board of number of moves and number of boxes and unloads the picture boxes
        /// </summary>
        private void ResetBoard()
        {
            //Unload the picture boxes
            UnloadBoxs();
            //Reset the text
            txtNumOfMoves.Text = "0";
            txtNumOfBoxes.Text = "0";
            //Remove the current q level
            currentQLevel = null;
        }

        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A button to close the game form
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Loads a q level
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the open file dialog and if the user selects ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Get the text from the selected file
                    string fileString = FileHandler.LoadFile(openFileDialog1.FileName);

                    //Unload the old boxes
                    UnloadBoxs();

                    //Parse the text from the file to the current q level
                    currentQLevel = QLevel.Parse(fileString);

                    //Get the height and width of the q level and generate the picture boxes
                    int numOfRows = currentQLevel.GetHeight();
                    int numOfColumns = currentQLevel.GetWidth();
                    GenerateLevel(numOfRows, numOfColumns);

                    //Set the number of moves and boxes
                    txtNumOfMoves.Text = currentQLevel.NumberOfMoves.ToString();
                    txtNumOfBoxes.Text = currentQLevel.GetBoxCount().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid qgame file!\n{ex.Message}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// When a picture boxes is clicked select that box
        /// </summary>
        private void BoxClicked(object sender, EventArgs e)
        {
            //Check if the sender is a picture box
            if (sender is PictureBox)
            {
                //Get the picture box clicked
                PictureBox picClicked = (PictureBox)sender;

                //Select the picture box clicked
                SelectBox(picClicked);
            }
        }

        /// <summary>
        /// Moves the selected box when a direction button is clicked
        /// </summary>
        private void MoveButtonClicked(object sender, EventArgs e)
        {
            //Check if there is no current q level
            if (currentQLevel == null)
            {
                //Give a message and return
                MessageBox.Show($"No game loaded!", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //If the sender is a button
            if (sender is Button)
            {
                //Get the button clicked
                Button clickedButton = (Button)sender;
                //Get the position of the selected box
                Vector2 selectedBoxPos = currentQLevel.SelectedBox;
                //If there is no selected box
                if (selectedBoxPos == null)
                {
                    //Give a message and return
                    MessageBox.Show($"Click to select!", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Get the direction that was clicked
                QLevel.Directions direction = QLevel.Directions.None;
                if (clickedButton.Text == "Up")
                    direction = QLevel.Directions.Up;
                else if (clickedButton.Text == "Down")
                    direction = QLevel.Directions.Down;
                else if (clickedButton.Text == "Left")
                    direction = QLevel.Directions.Left;
                else if (clickedButton.Text == "Right")
                    direction = QLevel.Directions.Right;

                //If it was a direction clicked
                if(direction != QLevel.Directions.None)
                {
                    //Move the selected box in the direction clicked and save the position that it move to
                    Vector2 boxesNewPos = currentQLevel.MoveBox(selectedBoxPos.X, selectedBoxPos.Y, direction);
                    
                    //If the box did move to a new position update that boxes picture box
                    if (boxesNewPos.X != -1 && boxesNewPos.Y != -1)
                        UpdateBoxGui(boxesNewPos.X, boxesNewPos.Y);

                    //Update the position the box started in
                    UpdateBoxGui(selectedBoxPos.X, selectedBoxPos.Y);

                    //Update the number of moves and boxes
                    txtNumOfMoves.Text = currentQLevel.NumberOfMoves.ToString();
                    int boxCount = currentQLevel.GetBoxCount();
                    txtNumOfBoxes.Text = boxCount.ToString();

                    //If there are no boxes left then the game is over
                    if (boxCount == 0)
                    {
                        MessageBox.Show($"Congratulations!\nGame End", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ResetBoard();
                    }
                }
            }
        }
    }
}
