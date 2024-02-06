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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PokeDex
{
    enum attack { Attack, Defense, Special_Attack, Special_Defense }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public attack AttackType;
        public int HP;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Generation;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            CurrentLabel.Text = current.ToString();
            pokemons = new Pokemon[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Pokemon p = ReadPokemon(S);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                showpokemon(pokemons[0]);
            }
        }

        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.AttackType = (attack)Enum.Parse(typeof(attack), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            p.Generation = int.Parse(fields[6]);
            if (fields[7].ToString() == "True")
            {
                p.Shiny = true;
            }
            else
            {
                p.Shiny = false;
            }
            if (fields[8].ToString() == "True")
            {
                p.Legendary = true;
            }
            else
            {
                p.Legendary = false;
            }

            return p;


        }

        private void Save()
        {
                string tmp = "";
               tmp = "";
               tmp += NameTextbox.Text;
               tmp += "|";
               tmp += TypeTextbox.Text;
               tmp += "|";
               tmp += LevelTextbox.Text;
               tmp += "|";
               tmp += AttackTypeTextbox.Text;
               tmp += "|";
               tmp += HPTextbox.Text;
               tmp += "|";
               tmp += ExpTextbox.Text;
               tmp += "|";
               tmp += GenerationTextbox.Text;
               tmp += "|";
               tmp += checkBox1.Checked.ToString();
               tmp += "|";
               tmp += checkBox2.Checked.ToString();
                pokemons[current] = ReadPokemon(tmp);

                StreamWriter outFile = new StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(PokemonToString(pokemons[i]));
            }
                outFile.Close();
        }

        private string PokemonToString(Pokemon p)
        {
            string retVal = "";
            retVal += p.Name;
            retVal += "|";
            retVal += p.Type.ToString();
            retVal += "|";
            retVal += p.Level.ToString();
            retVal += "|";
            retVal += p.AttackType.ToString();
            retVal += "|";
            retVal += p.HP.ToString();
            retVal += "|";
            retVal += p.Exp.ToString();
            retVal += "|";
            retVal += p.Generation.ToString();
            retVal += "|";
            retVal += p.Shiny.ToString();
            retVal += "|";
            retVal += p.Legendary.ToString();
            return retVal;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }


        void showpokemon(Pokemon p)
        {
            NameTextbox.Text = p.Name;
            TypeTextbox.Text = p.Type;
            LevelTextbox.Text = p.Level.ToString();
            AttackTypeTextbox.Text = p.AttackType.ToString();
            HPTextbox.Text = p.HP.ToString();
            ExpTextbox.Text = p.Exp.ToString();
            GenerationTextbox.Text = p.Generation.ToString();
            checkBox1.Checked = p.Shiny;
            checkBox2.Checked = p.Legendary;

        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            Save();         
            current = 0;
            CurrentLabel.Text = current.ToString();
            showpokemon(pokemons[current]);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            Save();
            current = count;
            CurrentLabel.Text = current.ToString();
            showpokemon(pokemons[current]);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                Save();
                current--;
                CurrentLabel.Text = current.ToString();
                showpokemon(pokemons[current]);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (current < count -1)
            {
                Save();
                current++;
                CurrentLabel.Text = current.ToString();
                showpokemon(pokemons[current]);
            }
        }

        private void Clear()
        {
            NameTextbox.Text = "";
            TypeTextbox.Text = "";
            LevelTextbox.Text = "";
            AttackTypeTextbox.Text = "";
            HPTextbox.Text = "";
            ExpTextbox.Text = "";
            GenerationTextbox.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
            Clear();
        }
    }
}