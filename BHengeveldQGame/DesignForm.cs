/*  Program: ControlPanelForm.cs
 *  
 *  Assignment: 3
 *  
 *  Description: Handles the form for a user to design and save a level for Q game
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.10.09: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHengeveldQGame
{
    /// <summary>
    /// A form to design a q game level
    /// </summary>
    public partial class DesignForm : Form
    {
        //Numbers for position and sizing picture boxs
        const int STARTING_X = 230;
        const int STARTING_Y = 115;
        const int BOX_SIZE = 70;
        const int BOX_GAP = 3;

        QLevel newQLevel;
        QLevel.Items selectedItem;
        PictureBox[,] levelsPictures;

        struct Vector2
        {
            public int x;
            public int y;
        }

        /// <summary>
        /// Generates the picture boxes of the level being made
        /// </summary>
        /// <param name="height">The height of the level being generated</param>
        /// <param name="width">The width of the level being generated</param>
        public void GenerateLevel(int height, int width)
        {
            //Sets up array to hold all the picture boxes
            levelsPictures = new PictureBox[width, height];
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //Generate a new picture box
                    PictureBox newPicBox = new PictureBox();
                    newPicBox.Size = new Size(BOX_SIZE, BOX_SIZE);
                    newPicBox.Location = new Point((BOX_SIZE+BOX_GAP) * x + STARTING_X, (BOX_SIZE + BOX_GAP) * y + STARTING_Y);
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
        /// Updates the image of the picture box to match the q level
        /// </summary>
        /// <param name="x">The x position of the picture box</param>
        /// <param name="y">The y position of the picture box</param>
        public void UpdateBoxGui(int x, int y)
        {
            //Gets the item in the position given
            QLevel.Items item = newQLevel.GetPositionsItem(x, y);

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
                    newImage = Properties.Resources.RedBoxImage;
                    break;

                case QLevel.Items.GreenBox:
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
        /// Gets the x and y position of a picture box
        /// </summary>
        /// <param name="picClicked">The picture box that you want the position of</param>
        /// <returns>The x and y position of the picture box in the levelsPictures array</returns>
        private Vector2 GetBoxPos(PictureBox picBox)
        {
            Vector2 pos;
            pos.x = 0;
            pos.y = 0;

            //Go through all the picture boxes in the levelsPictures array
            for (int x = 0; x < levelsPictures.GetLength(0); x++)
            {
                for (int y = 0; y < levelsPictures.GetLength(1); y++)
                {
                    //If the picture box matches the one given then set the x and y to the picture box
                    if (levelsPictures[x,y] == picBox)
                    {
                        pos.x = x;
                        pos.y = y;
                        break;
                    }
                }
            }
            
            return pos;
        }

        /// <summary>
        /// Unloads all the picture boxes from the form
        /// </summary>
        private void UnloadBoxs()
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

        public DesignForm()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if is a q level being designed
            if (newQLevel != null)
            {
                //Ask the user where to save the file and then save the file to that location
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileHandler.SaveFile(saveFileDialog1.FileName, newQLevel.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Can not save an empty level!", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask the user what file to open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Try and load the file the user asked to
                try
                {
                    string fileString = FileHandler.LoadFile(openFileDialog1.FileName);

                    //Unload all the picture boxes
                    UnloadBoxs();

                    //set the new q level to the one from the file
                    newQLevel = QLevel.Parse(fileString);

                    //Get the number of rows and columns and generate the picture boxes
                    int numOfRows = newQLevel.GetHeight();
                    int numOfColumns = newQLevel.GetWidth();
                    GenerateLevel(numOfRows, numOfColumns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid qgame file!\n{ex.Message}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Unload all the picture boxs
            UnloadBoxs();

            //Get the number of rows and columns the user wants
            int numOfRows = 0;
            int numOfColumns = 0;
            try
            {
                numOfRows = int.Parse(txtRows.Text);
                numOfColumns = int.Parse(txtColumns.Text); ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please provide valid data for rows and columns (Both must be integers)", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Make the new level with the number of rows and columns
                newQLevel = new QLevel(numOfRows, numOfColumns);
                //Generate the picture boxes for the level
                GenerateLevel(numOfRows, numOfColumns);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            //Get the button that was clicked
            if (sender is Button)
            {
                Button btnClicked = (Button)sender;

                //Find what item button was clicked and set the selected item to the clicked item
                switch (btnClicked.ImageIndex)
                {
                    case 0: //None
                        selectedItem = QLevel.Items.None;
                        break;

                    case 1: //Wall
                        selectedItem = QLevel.Items.Wall;
                        break;

                    case 2: //Red Door
                        selectedItem = QLevel.Items.RedDoor;
                        break;

                    case 3: //Green Door
                        selectedItem = QLevel.Items.GreenDoor;
                        break;

                    case 4: //Red Box
                        selectedItem = QLevel.Items.RedBox;
                        break;

                    case 5: //Green Box
                        selectedItem = QLevel.Items.GreenBox;
                        break;

                    default:
                        break;
                }
            }
        }

        private void BoxClicked(object sender, EventArgs e)
        {
            //Get the picture box that was clicked
            if (sender is PictureBox)
            {
                PictureBox picClicked = (PictureBox)sender;

                //Get the position of the picture box clicked
                Vector2 pos = GetBoxPos(picClicked);

                //Update the picture box to the selected item
                newQLevel.UpdateBox(pos.x, pos.y, selectedItem);
                UpdateBoxGui(pos.x, pos.y);
            }
        }
    }
}
