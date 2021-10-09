
namespace Flappy_Bird_Game
{
    partial class FlappyBirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdForm));
            this.BottomPipe = new System.Windows.Forms.PictureBox();
            this.TheFlappyBird = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPipe
            // 
            this.BottomPipe.Image = ((System.Drawing.Image)(resources.GetObject("BottomPipe.Image")));
            this.BottomPipe.Location = new System.Drawing.Point(506, 380);
            this.BottomPipe.Name = "BottomPipe";
            this.BottomPipe.Size = new System.Drawing.Size(108, 209);
            this.BottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPipe.TabIndex = 0;
            this.BottomPipe.TabStop = false;
            // 
            // TheFlappyBird
            // 
            this.TheFlappyBird.Image = ((System.Drawing.Image)(resources.GetObject("TheFlappyBird.Image")));
            this.TheFlappyBird.Location = new System.Drawing.Point(53, 240);
            this.TheFlappyBird.Name = "TheFlappyBird";
            this.TheFlappyBird.Size = new System.Drawing.Size(57, 40);
            this.TheFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TheFlappyBird.TabIndex = 4;
            this.TheFlappyBird.TabStop = false;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Score.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 614);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(344, 34);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score: 0";
            // 
            // TopPipe
            // 
            this.TopPipe.Image = ((System.Drawing.Image)(resources.GetObject("TopPipe.Image")));
            this.TopPipe.Location = new System.Drawing.Point(579, 1);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(108, 209);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 6;
            this.TopPipe.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(0, 586);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(843, 71);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 7;
            this.Ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // FlappyBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(843, 657);
            this.Controls.Add(this.TheFlappyBird);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.TopPipe);
            this.Controls.Add(this.BottomPipe);
            this.Name = "FlappyBirdForm";
            this.Text = "Flappy Bird ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisdownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisupEvent);
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BottomPipe;
        private System.Windows.Forms.PictureBox TheFlappyBird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer gameTimer;
    }
}

