/*  Program: ControlPanelForm.cs
 *  
 *  Assignment: 3
 *  
 *  Description: Handles the form to load the q game and the q level designer
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.10.09: Created
 *      Ben Hengeveld, 2021.11.27: Adds a button that brings the user to a spot to play the q game
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
    /// A form to go to the designer or player for q game
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            //Loads the design form to make a q level
            Form designForm = new DesignForm();
            designForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes this form
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form gameForm = new GameForm();
            gameForm.Show();
        }
    }
}
