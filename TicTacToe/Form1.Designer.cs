namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelTopRight = new System.Windows.Forms.Label();
            this.labelTopMiddle = new System.Windows.Forms.Label();
            this.labelMiddleRight = new System.Windows.Forms.Label();
            this.labelMiddleMiddle = new System.Windows.Forms.Label();
            this.labelMiddleLeft = new System.Windows.Forms.Label();
            this.labelBottomMiddle = new System.Windows.Forms.Label();
            this.labelBottomRight = new System.Windows.Forms.Label();
            this.labelBottomLeft = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTopLeft.Location = new System.Drawing.Point(26, 40);
            this.labelTopLeft.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(70, 70);
            this.labelTopLeft.TabIndex = 0;
            // 
            // labelTopRight
            // 
            this.labelTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTopRight.Location = new System.Drawing.Point(178, 40);
            this.labelTopRight.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelTopRight.Name = "labelTopRight";
            this.labelTopRight.Size = new System.Drawing.Size(70, 70);
            this.labelTopRight.TabIndex = 1;
            // 
            // labelTopMiddle
            // 
            this.labelTopMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTopMiddle.Location = new System.Drawing.Point(102, 40);
            this.labelTopMiddle.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelTopMiddle.Name = "labelTopMiddle";
            this.labelTopMiddle.Size = new System.Drawing.Size(70, 70);
            this.labelTopMiddle.TabIndex = 2;
            // 
            // labelMiddleRight
            // 
            this.labelMiddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMiddleRight.Location = new System.Drawing.Point(178, 121);
            this.labelMiddleRight.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelMiddleRight.Name = "labelMiddleRight";
            this.labelMiddleRight.Size = new System.Drawing.Size(70, 70);
            this.labelMiddleRight.TabIndex = 3;
            // 
            // labelMiddleMiddle
            // 
            this.labelMiddleMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMiddleMiddle.Location = new System.Drawing.Point(102, 121);
            this.labelMiddleMiddle.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelMiddleMiddle.Name = "labelMiddleMiddle";
            this.labelMiddleMiddle.Size = new System.Drawing.Size(70, 70);
            this.labelMiddleMiddle.TabIndex = 4;
            // 
            // labelMiddleLeft
            // 
            this.labelMiddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMiddleLeft.Location = new System.Drawing.Point(26, 121);
            this.labelMiddleLeft.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelMiddleLeft.Name = "labelMiddleLeft";
            this.labelMiddleLeft.Size = new System.Drawing.Size(70, 70);
            this.labelMiddleLeft.TabIndex = 5;
            // 
            // labelBottomMiddle
            // 
            this.labelBottomMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBottomMiddle.Location = new System.Drawing.Point(102, 202);
            this.labelBottomMiddle.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelBottomMiddle.Name = "labelBottomMiddle";
            this.labelBottomMiddle.Size = new System.Drawing.Size(70, 70);
            this.labelBottomMiddle.TabIndex = 6;
            // 
            // labelBottomRight
            // 
            this.labelBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBottomRight.Location = new System.Drawing.Point(178, 202);
            this.labelBottomRight.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelBottomRight.Name = "labelBottomRight";
            this.labelBottomRight.Size = new System.Drawing.Size(70, 70);
            this.labelBottomRight.TabIndex = 7;
            // 
            // labelBottomLeft
            // 
            this.labelBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBottomLeft.Location = new System.Drawing.Point(26, 202);
            this.labelBottomLeft.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelBottomLeft.Name = "labelBottomLeft";
            this.labelBottomLeft.Size = new System.Drawing.Size(70, 70);
            this.labelBottomLeft.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Location = new System.Drawing.Point(26, 296);
            this.labelResult.MaximumSize = new System.Drawing.Size(250, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(223, 20);
            this.labelResult.TabIndex = 9;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(62, 341);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 10;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(143, 341);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 376);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBottomLeft);
            this.Controls.Add(this.labelBottomRight);
            this.Controls.Add(this.labelBottomMiddle);
            this.Controls.Add(this.labelMiddleLeft);
            this.Controls.Add(this.labelMiddleMiddle);
            this.Controls.Add(this.labelMiddleRight);
            this.Controls.Add(this.labelTopMiddle);
            this.Controls.Add(this.labelTopRight);
            this.Controls.Add(this.labelTopLeft);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Label labelTopRight;
        private System.Windows.Forms.Label labelTopMiddle;
        private System.Windows.Forms.Label labelMiddleRight;
        private System.Windows.Forms.Label labelMiddleMiddle;
        private System.Windows.Forms.Label labelMiddleLeft;
        private System.Windows.Forms.Label labelBottomMiddle;
        private System.Windows.Forms.Label labelBottomRight;
        private System.Windows.Forms.Label labelBottomLeft;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonExit;
    }
}

