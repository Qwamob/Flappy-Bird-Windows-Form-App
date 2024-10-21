namespace Flappy_Bird_Windows_Form_App
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeBot = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(214, 51);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeBot
            // 
            this.pipeBot.Image = global::Flappy_Bird_Windows_Form_App.Properties.Resources.pipeBottom;
            this.pipeBot.Location = new System.Drawing.Point(535, 422);
            this.pipeBot.Name = "pipeBot";
            this.pipeBot.Size = new System.Drawing.Size(100, 188);
            this.pipeBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBot.TabIndex = 2;
            this.pipeBot.TabStop = false;
            this.pipeBot.Click += new System.EventHandler(this.pipeBot_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form_App.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-27, 583);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(792, 124);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::Flappy_Bird_Windows_Form_App.Properties.Resources.flappyBird;
            this.Bird.Location = new System.Drawing.Point(95, 194);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(79, 67);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form_App.Properties.Resources.pipeTop;
            this.pipeTop.Location = new System.Drawing.Point(456, -3);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 219);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(757, 701);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pipeBot);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox pipeBot;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground;
    }
}

