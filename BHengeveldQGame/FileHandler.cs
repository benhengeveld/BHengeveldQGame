/*  Program: FileHandler.cs
 *  
 *  Assignment: 3
 *  
 *  Description: Handles loading and saving a file
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.10.09: Created
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHengeveldQGame
{
    class FileHandler
    {
        /// <summary>
        /// Counts the number of times a word comes up in a string
        /// </summary>
        /// <param name="stringToCount">String to check</param>
        /// <param name="word">Word to count</param>
        /// <returns>The number of times the word shows up in the string</returns>
        public static int NumOfWordsInString(string stringToCount, string word)
        {
            int count = 0;

            int pos = 0;
            //Loop through string until it cant find any more instances of the word
            while (stringToCount.IndexOf(word, pos) != -1)
            {
                //Change the position after the word just found
                pos = stringToCount.IndexOf(word, pos) + word.Length;
                //Add one to the count
                count++;
            }

            return count;
        }

        /// <summary>
        /// Saves text to a new file
        /// </summary>
        /// <param name="fileName">File name and path of the file to save</param>
        /// <param name="textToSave">The text to save to the file</param>
        public static void SaveFile(string fileName, string textToSave)
        {
            //Check if the file already exist
            if (!File.Exists(fileName))
            {
                //If the file does not exist then make the file
                using (File.CreateText(fileName)) { }
            }

            //Write the text to the file
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine(textToSave);
            }

            int wallCount = 0;
            int doorCount = 0;
            int boxCount = 0;

            //Count the number of walls in the text being saved
            wallCount += NumOfWordsInString(textToSave, "Wall");

            //Count the number of doors in the text being saved
            doorCount += NumOfWordsInString(textToSave, "RedDoor");
            doorCount += NumOfWordsInString(textToSave, "GreenDoor");

            //Count the number of boxes in the text being saved
            boxCount += NumOfWordsInString(textToSave, "RedBox");
            boxCount += NumOfWordsInString(textToSave, "GreenBox");

            //Tell the user the file has been saved and the number of walls, doors, and boxes
            string message = 
                "File saved successfully\n"+
                $"Wall Count: {wallCount}\n"+
                $"Door Count: {doorCount}\n"+
                $"Box Count: {boxCount}";
            MessageBox.Show(message, "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Loads the text from a file
        /// </summary>
        /// <param name="fileName">File name and path of the file to load</param>
        /// <returns>The text from the file</returns>
        public static string LoadFile(string fileName)
        {
            string returnString = "";

            //Read the file
            using (StreamReader reader = new StreamReader(fileName))
            {
                //Read each line and add it to the return string
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    returnString += $"{line}\n";
                }
            }

            return returnString.Trim('\n');
        }
    }
}
