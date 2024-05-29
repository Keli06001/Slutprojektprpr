namespace slutprojekt
{
    partial class Form2
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
            PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            scoreShow = new Label();
            checkButton = new Button();
            wordLabel = new Label();
            translationTextBox = new TextBox();
            Back = new Button();
            Fire = new PictureBox();
            Fire2 = new PictureBox();
            hintButton = new Button();
            ledtrådLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fire2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Chinese_Dragon_PNG_Clip_Art_3373;
            pictureBox1.Location = new Point(76, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 413);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // scoreShow
            // 
            scoreShow.BackColor = Color.Transparent;
            scoreShow.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            scoreShow.Location = new Point(527, 239);
            scoreShow.Name = "scoreShow";
            scoreShow.Size = new Size(200, 65);
            scoreShow.TabIndex = 11;
            scoreShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(346, 268);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 10;
            checkButton.Text = "CHECK";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click_1;
            // 
            // wordLabel
            // 
            wordLabel.BackColor = Color.Transparent;
            wordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            wordLabel.Location = new Point(289, 202);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(185, 34);
            wordLabel.TabIndex = 9;
            wordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // translationTextBox
            // 
            translationTextBox.Location = new Point(337, 239);
            translationTextBox.Name = "translationTextBox";
            translationTextBox.Size = new Size(100, 23);
            translationTextBox.TabIndex = 8;
            translationTextBox.KeyDown += translationTextBox_KeyDown_1;
            // 
            // Back
            // 
            Back.Location = new Point(12, 408);
            Back.Name = "Back";
            Back.Size = new Size(100, 30);
            Back.TabIndex = 13;
            Back.Text = "Tillbaka";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Fire
            // 
            Fire.Image = (Image)resources.GetObject("Fire.Image");
            Fire.Location = new Point(404, 244);
            Fire.Name = "Fire";
            Fire.Size = new Size(70, 50);
            Fire.SizeMode = PictureBoxSizeMode.Zoom;
            Fire.TabIndex = 14;
            Fire.TabStop = false;
            Fire.Visible = false;
            // 
            // Fire2
            // 
            Fire2.BackColor = Color.Transparent;
            Fire2.Image = (Image)resources.GetObject("Fire2.Image");
            Fire2.Location = new Point(404, 244);
            Fire2.Name = "Fire2";
            Fire2.Size = new Size(70, 50);
            Fire2.SizeMode = PictureBoxSizeMode.Zoom;
            Fire2.TabIndex = 15;
            Fire2.TabStop = false;
            Fire2.Visible = false;
            Fire2.Click += Fire2_Click;
            // 
            // hintButton
            // 
            hintButton.Location = new Point(346, 380);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(75, 23);
            hintButton.TabIndex = 16;
            hintButton.Text = "Ledtråd";
            hintButton.UseVisualStyleBackColor = true;
            hintButton.Click += hintButton_Click;
            // 
            // ledtrådLabel
            // 
            ledtrådLabel.AutoSize = true;
            ledtrådLabel.Location = new Point(374, 362);
            ledtrådLabel.Name = "ledtrådLabel";
            ledtrådLabel.Size = new Size(0, 15);
            ledtrådLabel.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(605, 239);
            label1.Name = "label1";
            label1.Size = new Size(46, 14);
            label1.TabIndex = 18;
            label1.Text = "Poäng";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ledtrådLabel);
            Controls.Add(hintButton);
            Controls.Add(scoreShow);
            Controls.Add(Back);
            Controls.Add(checkButton);
            Controls.Add(translationTextBox);
            Controls.Add(Fire2);
            Controls.Add(Fire);
            Controls.Add(wordLabel);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form2";
            Text = "Spel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fire).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fire2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreShow;
        private Button checkButton;
        private Label wordLabel;
        private TextBox translationTextBox;
        private PictureBox pictureBox1;
        private Button Back;
        private PictureBox Fire;
        private PictureBox Fire2;
        private Button hintButton;
        private Label ledtrådLabel;
        private Label label1;
    }
}