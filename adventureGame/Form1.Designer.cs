
namespace adventureGame
{
    partial class gameBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameBackground));
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.wizardImageBox = new System.Windows.Forms.PictureBox();
            this.nextFormButton = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.gameText = new System.Windows.Forms.Label();
            this.slimeImage = new System.Windows.Forms.PictureBox();
            this.fightImage = new System.Windows.Forms.PictureBox();
            this.damselImage = new System.Windows.Forms.PictureBox();
            this.angryElfImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slimeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damselImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angryElfImage)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(264, 60);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(239, 168);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(230, 251);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(46, 21);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "...";
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.beginButton.FlatAppearance.BorderSize = 0;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.White;
            this.beginButton.Location = new System.Drawing.Point(326, 317);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(74, 39);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "BEGIN!";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // wizardImageBox
            // 
            this.wizardImageBox.BackColor = System.Drawing.Color.Transparent;
            this.wizardImageBox.Image = ((System.Drawing.Image)(resources.GetObject("wizardImageBox.Image")));
            this.wizardImageBox.Location = new System.Drawing.Point(326, 234);
            this.wizardImageBox.Name = "wizardImageBox";
            this.wizardImageBox.Size = new System.Drawing.Size(137, 256);
            this.wizardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wizardImageBox.TabIndex = 3;
            this.wizardImageBox.TabStop = false;
            // 
            // nextFormButton
            // 
            this.nextFormButton.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextFormButton.ForeColor = System.Drawing.Color.White;
            this.nextFormButton.Location = new System.Drawing.Point(693, 394);
            this.nextFormButton.Name = "nextFormButton";
            this.nextFormButton.Size = new System.Drawing.Size(95, 47);
            this.nextFormButton.TabIndex = 6;
            this.nextFormButton.Text = "CLICK TO CONTINUE ";
            this.nextFormButton.Click += new System.EventHandler(this.nextFormButton_Click);
            // 
            // option1
            // 
            this.option1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(117, 172);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(141, 56);
            this.option1.TabIndex = 7;
            this.option1.Text = "YES";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(117, 251);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(141, 56);
            this.option2.TabIndex = 8;
            this.option2.Text = "NO";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // gameText
            // 
            this.gameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameText.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameText.ForeColor = System.Drawing.Color.White;
            this.gameText.Location = new System.Drawing.Point(117, 9);
            this.gameText.Name = "gameText";
            this.gameText.Size = new System.Drawing.Size(525, 103);
            this.gameText.TabIndex = 9;
            this.gameText.Text = "A young wizard is off on his journey after his graduation from the magic  academy" +
    ", he is ready to begin his grand journey.";
            // 
            // slimeImage
            // 
            this.slimeImage.BackColor = System.Drawing.Color.Transparent;
            this.slimeImage.Image = ((System.Drawing.Image)(resources.GetObject("slimeImage.Image")));
            this.slimeImage.Location = new System.Drawing.Point(509, 327);
            this.slimeImage.Name = "slimeImage";
            this.slimeImage.Size = new System.Drawing.Size(120, 191);
            this.slimeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slimeImage.TabIndex = 10;
            this.slimeImage.TabStop = false;
            // 
            // fightImage
            // 
            this.fightImage.BackColor = System.Drawing.Color.Transparent;
            this.fightImage.Image = ((System.Drawing.Image)(resources.GetObject("fightImage.Image")));
            this.fightImage.Location = new System.Drawing.Point(12, 115);
            this.fightImage.Name = "fightImage";
            this.fightImage.Size = new System.Drawing.Size(776, 341);
            this.fightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fightImage.TabIndex = 11;
            this.fightImage.TabStop = false;
            // 
            // damselImage
            // 
            this.damselImage.BackColor = System.Drawing.Color.Transparent;
            this.damselImage.Image = ((System.Drawing.Image)(resources.GetObject("damselImage.Image")));
            this.damselImage.Location = new System.Drawing.Point(618, 234);
            this.damselImage.Name = "damselImage";
            this.damselImage.Size = new System.Drawing.Size(170, 296);
            this.damselImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.damselImage.TabIndex = 12;
            this.damselImage.TabStop = false;
            // 
            // angryElfImage
            // 
            this.angryElfImage.BackColor = System.Drawing.Color.Transparent;
            this.angryElfImage.Image = ((System.Drawing.Image)(resources.GetObject("angryElfImage.Image")));
            this.angryElfImage.Location = new System.Drawing.Point(435, 152);
            this.angryElfImage.Name = "angryElfImage";
            this.angryElfImage.Size = new System.Drawing.Size(228, 304);
            this.angryElfImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.angryElfImage.TabIndex = 13;
            this.angryElfImage.TabStop = false;
            // 
            // gameBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.angryElfImage);
            this.Controls.Add(this.damselImage);
            this.Controls.Add(this.fightImage);
            this.Controls.Add(this.slimeImage);
            this.Controls.Add(this.gameText);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.nextFormButton);
            this.Controls.Add(this.wizardImageBox);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.iconBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameBackground";
            this.Text = "A WIZARDS ADVENTURE";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slimeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damselImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angryElfImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.PictureBox wizardImageBox;
        private System.Windows.Forms.Label nextFormButton;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Label gameText;
        private System.Windows.Forms.PictureBox slimeImage;
        private System.Windows.Forms.PictureBox fightImage;
        private System.Windows.Forms.PictureBox damselImage;
        private System.Windows.Forms.PictureBox angryElfImage;
    }
}

