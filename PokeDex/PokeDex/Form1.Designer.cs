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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeTextbox = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelTextbox = new System.Windows.Forms.TextBox();
            this.AttackTypeTextbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HPTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpTextbox = new System.Windows.Forms.TextBox();
            this.ShinyTextbox = new System.Windows.Forms.CheckBox();
            this.LegendaryTextbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerationTextbox = new System.Windows.Forms.TextBox();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DebugTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(64, 12);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.NameTextbox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(11, 43);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(42, 16);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type:";
            // 
            // TypeTextbox
            // 
            this.TypeTextbox.Location = new System.Drawing.Point(64, 40);
            this.TypeTextbox.Name = "TypeTextbox";
            this.TypeTextbox.Size = new System.Drawing.Size(100, 22);
            this.TypeTextbox.TabIndex = 2;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(11, 71);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(43, 16);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level:";
            // 
            // LevelTextbox
            // 
            this.LevelTextbox.Location = new System.Drawing.Point(64, 68);
            this.LevelTextbox.Name = "LevelTextbox";
            this.LevelTextbox.Size = new System.Drawing.Size(100, 22);
            this.LevelTextbox.TabIndex = 4;
            // 
            // AttackTypeTextbox
            // 
            this.AttackTypeTextbox.FormattingEnabled = true;
            this.AttackTypeTextbox.Items.AddRange(new object[] {
            "Special_Attack",
            "Special_Defense",
            "Attack",
            "Defense"});
            this.AttackTypeTextbox.Location = new System.Drawing.Point(64, 95);
            this.AttackTypeTextbox.Name = "AttackTypeTextbox";
            this.AttackTypeTextbox.Size = new System.Drawing.Size(100, 24);
            this.AttackTypeTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attack:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "HP:";
            // 
            // HPTextbox
            // 
            this.HPTextbox.Location = new System.Drawing.Point(64, 125);
            this.HPTextbox.Name = "HPTextbox";
            this.HPTextbox.Size = new System.Drawing.Size(100, 22);
            this.HPTextbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Exp:";
            // 
            // ExpTextbox
            // 
            this.ExpTextbox.Location = new System.Drawing.Point(64, 153);
            this.ExpTextbox.Name = "ExpTextbox";
            this.ExpTextbox.Size = new System.Drawing.Size(100, 22);
            this.ExpTextbox.TabIndex = 10;
            // 
            // ShinyTextbox
            // 
            this.ShinyTextbox.AutoSize = true;
            this.ShinyTextbox.Location = new System.Drawing.Point(267, 40);
            this.ShinyTextbox.Name = "ShinyTextbox";
            this.ShinyTextbox.Size = new System.Drawing.Size(62, 20);
            this.ShinyTextbox.TabIndex = 12;
            this.ShinyTextbox.Text = "Shiny";
            this.ShinyTextbox.UseVisualStyleBackColor = true;
            // 
            // LegendaryTextbox
            // 
            this.LegendaryTextbox.AutoSize = true;
            this.LegendaryTextbox.Location = new System.Drawing.Point(267, 66);
            this.LegendaryTextbox.Name = "LegendaryTextbox";
            this.LegendaryTextbox.Size = new System.Drawing.Size(94, 20);
            this.LegendaryTextbox.TabIndex = 13;
            this.LegendaryTextbox.Text = "Legendary";
            this.LegendaryTextbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Generation:";
            // 
            // GenerationTextbox
            // 
            this.GenerationTextbox.Location = new System.Drawing.Point(261, 12);
            this.GenerationTextbox.Name = "GenerationTextbox";
            this.GenerationTextbox.Size = new System.Drawing.Size(100, 22);
            this.GenerationTextbox.TabIndex = 14;
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Location = new System.Drawing.Point(182, 92);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(179, 80);
            this.PokemonPictureBox.TabIndex = 16;
            this.PokemonPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Picture:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 181);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(164, 51);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DebugTextbox
            // 
            this.DebugTextbox.Location = new System.Drawing.Point(182, 178);
            this.DebugTextbox.Multiline = true;
            this.DebugTextbox.Name = "DebugTextbox";
            this.DebugTextbox.Size = new System.Drawing.Size(179, 114);
            this.DebugTextbox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DebugTextbox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PokemonPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerationTextbox);
            this.Controls.Add(this.LegendaryTextbox);
            this.Controls.Add(this.ShinyTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HPTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttackTypeTextbox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelTextbox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeTextbox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.TextBox LevelTextbox;
        private System.Windows.Forms.ComboBox AttackTypeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HPTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpTextbox;
        private System.Windows.Forms.CheckBox ShinyTextbox;
        private System.Windows.Forms.CheckBox LegendaryTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenerationTextbox;
        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DebugTextbox;
        private System.Windows.Forms.Button button1;
    }
}

