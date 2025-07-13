using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // 2D array to represent the Tic Tac Toe board
        private int[,] board = new int[3, 3];

        public Form1()
        {
            InitializeComponent();
            RandomizeBoard(); // Call the function to randomize the board
            UpdateLabels(); // Update the labels to reflect the initial board state
        }

        // Create function to randomize cell numbers
        private void RandomizeBoard()
        {
            // Initialize random object
            Random random = new Random();

            // Randomly generate 0 or 1 for each cell in the board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = random.Next(2); // 0 or 1
                }
            }
        }

        // Create a function to update the labels based on the board state
        private void UpdateLabels()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string labelName = $"label{i}{j}"; // Construct the label name based on the indices
                    var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label; // Find the label control by name
                    if (label != null)
                    {
                        label.Text = board[i, j].ToString(); // Update the label text with the board value
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            RandomizeBoard(); // Randomize the board when a new game starts
            UpdateLabels(); // Update the labels to reflect the new board state
        }
    }
}
