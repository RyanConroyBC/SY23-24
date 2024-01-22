using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDex
{
    enum attack {Special_Attack, Special_Defense, Attack, Defense}
    struct Pokemon
    {
        string Name;
        string Type;
        int Level;
        attack AttackType;
        int HP;
        int Exp;
        bool Legandary;
        bool Shiny;
        int Generation;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
                {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string S = inFile.ReadToEnd();
                inFile.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DebugTextbox.Clear();
            DebugTextbox.Text += NameTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += TypeTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += LevelTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += AttackTypeTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += HPTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += ExpTextbox.Text;
            DebugTextbox.Text += " | ";
            DebugTextbox.Text += GenerationTextbox.Text;
            DebugTextbox.Text += " | ";
           if (ShinyTextbox.Checked == true)
            {
                DebugTextbox.Text += "Is Shiny";
            }
           else
            {
                DebugTextbox.Text += "Not Shiny";
            }
            DebugTextbox.Text += " | ";
            if (LegendaryTextbox.Checked == true)
            {
                DebugTextbox.Text += "Is Legendary";
            }
            else
            {
                DebugTextbox.Text += "Not Legendary";
            }

            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            outFile.Write(DebugTextbox.Text);
            outFile.Close();
        }
    }
}
