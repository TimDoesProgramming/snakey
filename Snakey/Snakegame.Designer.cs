namespace Snakey
{
    partial class SnakeGame
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Gray;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(541, 560);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(587, 38);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(89, 29);
            this.score.TabIndex = 1;
            this.score.Text = "Score:";
            // 
            // numScore
            // 
            this.numScore.AutoSize = true;
            this.numScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScore.Location = new System.Drawing.Point(675, 38);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(41, 29);
            this.numScore.TabIndex = 2;
            this.numScore.Text = "00";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.Black;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.Color.Yellow;
            this.end.Location = new System.Drawing.Point(215, 226);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(117, 29);
            this.end.TabIndex = 3;
            this.end.Text = "End Text";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pbCanvas);
            this.Name = "SnakeGame";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label numScore;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Timer gameTimer;
    }
}

