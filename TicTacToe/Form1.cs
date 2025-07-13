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
            int winner = -1; // Initialize winner variable

            while (winner == -1) // Loop until a winner is found
            {
                RandomizeBoard(); // Call the function to randomize the board
                winner = CheckWinner(); // Check for a winner
            }
            
            UpdateLabels(); // Update the labels to reflect the initial board state

            // Display the result based on the winner
            if (winner == 1)
            {
                labelResult.Text = "X is the winner!";
            }
            else
            {
                labelResult.Text = "O is the winner!";
            }
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
                        label.Text = board[i, j] == 1 ? "X" : "O"; // Update the label text with "X" for 1 and "O" for 0
                    }
                }
            }
        }

        // Helper method to ensure there is a winner
        // Returns 1 for "X", 0 for "O", and -1 for no winner
        private int CheckWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return board[i, 0]; // Return the winner (1 or 0)
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return board[0, j]; // Return the winner (1 or 0)
                }
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0]; // Return the winner (1 or 0)
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2]; // Return the winner (1 or 0)
            }

            // No winner found
            return -1;
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
