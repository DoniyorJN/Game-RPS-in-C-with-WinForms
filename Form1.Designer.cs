namespace RockPaperScissoesGame
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.gameImageList = new System.Windows.Forms.ImageList(this.components);
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.scissoesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameImageList
            // 
            this.gameImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gameImageList.ImageStream")));
            this.gameImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.gameImageList.Images.SetKeyName(0, "Paper.bmp");
            this.gameImageList.Images.SetKeyName(1, "Rock.bmp");
            this.gameImageList.Images.SetKeyName(2, "Scissoes.bmp");
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(12, 25);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(160, 220);
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(299, 25);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(160, 220);
            this.computerPictureBox.TabIndex = 1;
            this.computerPictureBox.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(178, 80);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(115, 58);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Enabled = false;
            this.paperButton.Location = new System.Drawing.Point(12, 251);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(115, 58);
            this.paperButton.TabIndex = 3;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Enabled = false;
            this.rockButton.Location = new System.Drawing.Point(178, 251);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(115, 58);
            this.rockButton.TabIndex = 4;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // scissoesButton
            // 
            this.scissoesButton.Enabled = false;
            this.scissoesButton.Location = new System.Drawing.Point(344, 251);
            this.scissoesButton.Name = "scissoesButton";
            this.scissoesButton.Size = new System.Drawing.Size(115, 58);
            this.scissoesButton.TabIndex = 5;
            this.scissoesButton.Text = "Scissores";
            this.scissoesButton.UseVisualStyleBackColor = true;
            this.scissoesButton.Click += new System.EventHandler(this.ScissoesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer";
            // 
            // resultsLabel
            // 
            this.resultsLabel.ForeColor = System.Drawing.Color.Red;
            this.resultsLabel.Location = new System.Drawing.Point(189, 171);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(89, 23);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.scoreLabel.Location = new System.Drawing.Point(189, 45);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(89, 23);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 339);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scissoesButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Name = "Form";
            this.Text = "GAME";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList gameImageList;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button scissoesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}

