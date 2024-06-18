namespace SnakeGame_FinalProject_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.greenButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 150;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(166, 443);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(269, 34);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.White;
            this.subtitleLabel.Location = new System.Drawing.Point(101, 477);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(399, 25);
            this.subtitleLabel.TabIndex = 5;
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(101, 546);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(399, 25);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageLabel
            // 
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.ForeColor = System.Drawing.Color.Transparent;
            this.imageLabel.Image = global::SnakeGame_FinalProject_.Properties.Resources.snakeImage;
            this.imageLabel.Location = new System.Drawing.Point(110, 30);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(367, 413);
            this.imageLabel.TabIndex = 8;
            // 
            // greenButton
            // 
            this.greenButton.Enabled = false;
            this.greenButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.greenButton.FlatAppearance.BorderSize = 3;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenButton.ForeColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(78, 480);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(118, 36);
            this.greenButton.TabIndex = 9;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Visible = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.Enabled = false;
            this.orangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.orangeButton.FlatAppearance.BorderSize = 3;
            this.orangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeButton.ForeColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(246, 438);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(118, 36);
            this.orangeButton.TabIndex = 10;
            this.orangeButton.Text = "ORANGE";
            this.orangeButton.UseVisualStyleBackColor = true;
            this.orangeButton.Visible = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // redButton
            // 
            this.redButton.Enabled = false;
            this.redButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.redButton.FlatAppearance.BorderSize = 3;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.ForeColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(78, 438);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(118, 36);
            this.redButton.TabIndex = 11;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Visible = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Enabled = false;
            this.blueButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.blueButton.FlatAppearance.BorderSize = 3;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.ForeColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(246, 480);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(118, 36);
            this.blueButton.TabIndex = 12;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Visible = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.Enabled = false;
            this.purpleButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.purpleButton.FlatAppearance.BorderSize = 3;
            this.purpleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpleButton.ForeColor = System.Drawing.Color.Purple;
            this.purpleButton.Location = new System.Drawing.Point(404, 480);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(118, 36);
            this.purpleButton.TabIndex = 13;
            this.purpleButton.Text = "PURPLE";
            this.purpleButton.UseVisualStyleBackColor = true;
            this.purpleButton.Visible = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Enabled = false;
            this.yellowButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatAppearance.BorderSize = 3;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton.ForeColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(404, 438);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(118, 36);
            this.yellowButton.TabIndex = 14;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Visible = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.Enabled = false;
            this.pinkButton.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.pinkButton.FlatAppearance.BorderSize = 3;
            this.pinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinkButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinkButton.ForeColor = System.Drawing.Color.HotPink;
            this.pinkButton.Location = new System.Drawing.Point(246, 522);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(118, 36);
            this.pinkButton.TabIndex = 15;
            this.pinkButton.Text = "PINK";
            this.pinkButton.UseVisualStyleBackColor = true;
            this.pinkButton.Visible = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.subtitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button pinkButton;
    }
}

