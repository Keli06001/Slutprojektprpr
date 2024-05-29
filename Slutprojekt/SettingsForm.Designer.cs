namespace slutprojekt
{
    partial class SettingsForm
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
            radioButtonEnglishToSwedish = new RadioButton();
            radioButtonSwedishToEnglish = new RadioButton();
            Save = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            EnglistToSwedishLabel = new Label();
            SwedishToEnglishLabel = new Label();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // radioButtonEnglishToSwedish
            // 
            radioButtonEnglishToSwedish.AutoSize = true;
            radioButtonEnglishToSwedish.Location = new Point(386, 138);
            radioButtonEnglishToSwedish.Name = "radioButtonEnglishToSwedish";
            radioButtonEnglishToSwedish.Size = new Size(14, 13);
            radioButtonEnglishToSwedish.TabIndex = 0;
            radioButtonEnglishToSwedish.TabStop = true;
            radioButtonEnglishToSwedish.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwedishToEnglish
            // 
            radioButtonSwedishToEnglish.AutoSize = true;
            radioButtonSwedishToEnglish.Location = new Point(386, 203);
            radioButtonSwedishToEnglish.Name = "radioButtonSwedishToEnglish";
            radioButtonSwedishToEnglish.Size = new Size(14, 13);
            radioButtonSwedishToEnglish.TabIndex = 1;
            radioButtonSwedishToEnglish.TabStop = true;
            radioButtonSwedishToEnglish.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Location = new Point(339, 271);
            Save.Name = "Save";
            Save.Size = new Size(114, 40);
            Save.TabIndex = 2;
            Save.Text = "Spara";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._171_03;
            pictureBox1.Location = new Point(-6, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 462);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._171_03;
            pictureBox2.Location = new Point(600, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 462);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // EnglistToSwedishLabel
            // 
            EnglistToSwedishLabel.AutoSize = true;
            EnglistToSwedishLabel.Location = new Point(339, 110);
            EnglistToSwedishLabel.Name = "EnglistToSwedishLabel";
            EnglistToSwedishLabel.Size = new Size(114, 15);
            EnglistToSwedishLabel.TabIndex = 5;
            EnglistToSwedishLabel.Text = "Engelska till Svenska";
            // 
            // SwedishToEnglishLabel
            // 
            SwedishToEnglishLabel.AutoSize = true;
            SwedishToEnglishLabel.Location = new Point(339, 171);
            SwedishToEnglishLabel.Name = "SwedishToEnglishLabel";
            SwedishToEnglishLabel.Size = new Size(114, 15);
            SwedishToEnglishLabel.TabIndex = 6;
            SwedishToEnglishLabel.Text = "Svenska till Engelska";
            // 
            // Back
            // 
            Back.Location = new Point(12, 408);
            Back.Name = "Back";
            Back.Size = new Size(100, 30);
            Back.TabIndex = 14;
            Back.Text = "Tillbaka";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(SwedishToEnglishLabel);
            Controls.Add(EnglistToSwedishLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Save);
            Controls.Add(radioButtonSwedishToEnglish);
            Controls.Add(radioButtonEnglishToSwedish);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "SettingsForm";
            Text = "Inställningar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonEnglishToSwedish;
        private RadioButton radioButtonSwedishToEnglish;
        private Button Save;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label EnglistToSwedishLabel;
        private Label SwedishToEnglishLabel;
        private Button Back;
    }
}