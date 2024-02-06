namespace PokeDex
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
            this.NewButton = new System.Windows.Forms.Button();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DebugTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirectorTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SalesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActorsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PopularityTextbox = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.RatedTextbox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(184, 431);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(179, 73);
            this.NewButton.TabIndex = 55;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click_1);
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Location = new System.Drawing.Point(17, 446);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(0, 16);
            this.CurrentLabel.TabIndex = 54;
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(184, 362);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(179, 63);
            this.LastButton.TabIndex = 53;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click_1);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(17, 362);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 63);
            this.NextButton.TabIndex = 52;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(184, 292);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(179, 63);
            this.PreviousButton.TabIndex = 51;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click_1);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(14, 293);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(164, 63);
            this.FirstButton.TabIndex = 50;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(263, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 20);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Reccomend?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(263, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 20);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Awards";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 47;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DebugTextbox
            // 
            this.DebugTextbox.Location = new System.Drawing.Point(184, 172);
            this.DebugTextbox.Multiline = true;
            this.DebugTextbox.Name = "DebugTextbox";
            this.DebugTextbox.Size = new System.Drawing.Size(179, 114);
            this.DebugTextbox.TabIndex = 46;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 175);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(164, 51);
            this.SaveButton.TabIndex = 45;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Picture:";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(184, 86);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(179, 80);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 43;
            this.MoviePictureBox.TabStop = false;
            this.MoviePictureBox.Click += new System.EventHandler(this.MoviePictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Director:";
            // 
            // DirectorTextbox
            // 
            this.DirectorTextbox.Location = new System.Drawing.Point(263, 6);
            this.DirectorTextbox.Name = "DirectorTextbox";
            this.DirectorTextbox.Size = new System.Drawing.Size(100, 22);
            this.DirectorTextbox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sales:";
            // 
            // SalesTextbox
            // 
            this.SalesTextbox.Location = new System.Drawing.Point(78, 147);
            this.SalesTextbox.Name = "SalesTextbox";
            this.SalesTextbox.Size = new System.Drawing.Size(100, 22);
            this.SalesTextbox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Actors:";
            // 
            // ActorsTextbox
            // 
            this.ActorsTextbox.Location = new System.Drawing.Point(78, 119);
            this.ActorsTextbox.Name = "ActorsTextbox";
            this.ActorsTextbox.Size = new System.Drawing.Size(100, 22);
            this.ActorsTextbox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Popularity:";
            // 
            // PopularityTextbox
            // 
            this.PopularityTextbox.FormattingEnabled = true;
            this.PopularityTextbox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "VeryHigh"});
            this.PopularityTextbox.Location = new System.Drawing.Point(78, 92);
            this.PopularityTextbox.Name = "PopularityTextbox";
            this.PopularityTextbox.Size = new System.Drawing.Size(100, 24);
            this.PopularityTextbox.TabIndex = 35;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(13, 65);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(47, 16);
            this.LevelLabel.TabIndex = 34;
            this.LevelLabel.Text = "Rated:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(13, 37);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(47, 16);
            this.TypeLabel.TabIndex = 32;
            this.TypeLabel.Text = "Genre:";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(78, 34);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(100, 22);
            this.GenreTextbox.TabIndex = 31;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(78, 6);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.NameTextbox.TabIndex = 29;
            // 
            // RatedTextbox
            // 
            this.RatedTextbox.FormattingEnabled = true;
            this.RatedTextbox.Items.AddRange(new object[] {
            "PG",
            "PG13",
            "M",
            "R"});
            this.RatedTextbox.Location = new System.Drawing.Point(78, 59);
            this.RatedTextbox.Name = "RatedTextbox";
            this.RatedTextbox.Size = new System.Drawing.Size(100, 24);
            this.RatedTextbox.TabIndex = 56;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 504);
            this.Controls.Add(this.RatedTextbox);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DebugTextbox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DirectorTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalesTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActorsTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopularityTextbox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DebugTextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DirectorTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActorsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PopularityTextbox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.ComboBox RatedTextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

