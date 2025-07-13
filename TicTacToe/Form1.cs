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

        // Counter to keep track of the number of games played
        private int gameCount = 0;

        public Form1()
        {
            InitializeComponent();
            StartNewGame(); // Call the function to start a new game
        }

        // Create a function to start a new game
        private void StartNewGame()
        {
            ResetLabelColors(); // Reset all label colors to default

            int winner = -1; // Initialize winner variable
            gameCount++; // Increment the game count


            while (winner == -1) // Loop until a winner is found
            {
                RandomizeBoard(); // Call the function to randomize the board
                winner = CheckWinner(); // Check for a winner
            }

            UpdateLabels(); // Update the labels to reflect the initial board 
            List<(int, int)> winningCells = GetWinningCells(); // Get the winning cells

            // Highlight the winning cells
            HighlightWinningCells(winningCells);

            // Display the result based on the winner
            if (winner == 1)
            {
                labelResult.Text = "X is the winner!";
            }
            else
            {
                labelResult.Text = "O is the winner!";
            }

            // Call the function to display the game count
            DisplayGameCount();
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

        // GetWinningCells function to return the winning 
        private List<(int, int)> GetWinningCells()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return new List<(int, int)> { (i, 0), (i, 1), (i, 2) };
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return new List<(int, int)> { (0, j), (1, j), (2, j) };
                }
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return new List<(int, int)> { (0, 0), (1, 1), (2, 2) };
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return new List<(int, int)> { (0, 2), (1, 1), (2, 0) };
            }

            // No winner
            return new List<(int, int)>();
        }

        // Create highlightWinningCells function to highlight the winning cells
        private void HighlightWinningCells(List<(int, int)> winningCells)
        {
            foreach (var cell in winningCells)
            {
                string labelName = $"label{cell.Item1}{cell.Item2}"; // Construct the label name based on the cell coordinates
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label; // Find the label control by name
                if (label != null)
                {
                    label.BackColor = Color.Green; // Highlight the winning cell with yellow color
                }
            }
        }

        // A function to reset all labels colors to default
        private void ResetLabelColors()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string labelName = $"label{i}{j}"; // Construct the label name based on the indices
                    var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label; // Find the label control by name
                    if (label != null)
                    {
                        label.BackColor = SystemColors.Control; // Reset the label background color to default
                    }
                }
            }
        }

        // Function to display the game count
        private void DisplayGameCount()
        {
            labelGameCounter.Text = $"Games Played: {gameCount}"; // Update the label with the game count
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame(); // Start a new game when the button is clicked
        }

        private void labelGameCounter_Click(object sender, EventArgs e)
        {

        }
    }
}