namespace FlappyBirdStarter
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.upperPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.lowerPipe = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdStarter.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(103, 212);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(99, 53);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // upperPipe
            // 
            this.upperPipe.Image = global::FlappyBirdStarter.Properties.Resources.pipedown;
            this.upperPipe.Location = new System.Drawing.Point(543, -30);
            this.upperPipe.Name = "upperPipe";
            this.upperPipe.Size = new System.Drawing.Size(122, 234);
            this.upperPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperPipe.TabIndex = 1;
            this.upperPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdStarter.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-13, 585);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(835, 177);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // lowerPipe
            // 
            this.lowerPipe.Image = global::FlappyBirdStarter.Properties.Resources.pipe;
            this.lowerPipe.Location = new System.Drawing.Point(592, 414);
            this.lowerPipe.Name = "lowerPipe";
            this.lowerPipe.Size = new System.Drawing.Size(115, 262);
            this.lowerPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerPipe.TabIndex = 3;
            this.lowerPipe.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(51, 25);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(123, 31);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(804, 670);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lowerPipe);
            this.Controls.Add(this.upperPipe);
            this.Controls.Add(this.flappyBird);
            this.Name = "Form1";
            this.Text = "Flappy Bird - AG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox upperPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox lowerPipe;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
    }
}

