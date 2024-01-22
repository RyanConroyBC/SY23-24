using System;
using System.CodeDom;
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
        public string Name;
        public string Type;
        public int Level;
        public attack AttackType;
        public int HP;
        public int Exp;
        public bool Legandary;
        public bool Shiny;
        public int Generation;
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

        private void ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.AttackType = (attack) Enum.Parse(typeof(attack), fields[3]);
            p.HP= int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (LegendaryTextbox.Checked == true)
            {
                p.Legandary = fields[6].ToString() == "true";
            }
            else
            {
                p.Legandary = fields[6].ToString() == "false";
            }
            if (ShinyTextbox.Checked == true)
            {
                p.Shiny = fields[7].ToString() == "true";
            }
            else
            {
                p.Shiny = fields[7].ToString() == "false";
            }
            p.Generation = int.Parse(fields[8]);


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
