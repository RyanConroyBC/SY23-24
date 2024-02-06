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
    enum popularity { Low, Medium, High, VeryHigh }

    enum Rated { PG, PG13, M, R }
    struct Movie
    {
        public string Name;
        public string Genre;
        public Rated Rated;
        public popularity Popular;
        public string Actors;
        public int Sales;
        public bool Awards;
        public bool Reccomend;
        public string Director;
        public string Picture;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Movie[] Movies;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            CurrentLabel.Text = current.ToString();
            Movies = new Movie[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Movie.txt"))
            {
                StreamReader inFile = new StreamReader("Movie.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Movie p = ReadMovie(S);
                    Movies[count] = p;
                    count++;
                }
                inFile.Close();
                ShowMovie(Movies[0]);
            }
        }

        private Movie ReadMovie(string s)
        {
            Movie p = new Movie();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Genre = fields[1];
            p.Rated = (Rated)Enum.Parse(typeof(Rated), fields[2]);
            p.Popular = (popularity)Enum.Parse(typeof(popularity), fields[3]);
            p.Actors = fields[4];
            p.Sales = int.Parse(fields[5]);
            p.Director = fields[6];
            if (fields[7].ToString() == "True")
            {
                p.Reccomend = true;
            }
            else
            {
                p.Reccomend = false;
            }
            if (fields[8].ToString() == "True")
            {
                p.Awards = true;
            }
            else
            {
                p.Awards = false;
            }
            p.Picture = fields[9];

            return p;


        }

        private void Save()
        {
            string tmp = "";
            tmp = "";
            tmp += NameTextbox.Text;
            tmp += "|";
            tmp += GenreTextbox.Text;
            tmp += "|";
            tmp += RatedTextbox.Text;
            tmp += "|";
            tmp += PopularityTextbox.Text;
            tmp += "|";
            tmp += ActorsTextbox.Text;
            tmp += "|";
            tmp += SalesTextbox.Text;
            tmp += "|";
            tmp += DirectorTextbox.Text;
            tmp += "|";
            tmp += checkBox1.Checked.ToString();
            tmp += "|";
            tmp += checkBox2.Checked.ToString();
            tmp += "|";
            tmp += MoviePictureBox.ImageLocation;
            Movies[current] = ReadMovie(tmp);

            StreamWriter outFile = new StreamWriter("Movie.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(MovieToString(Movies[i]));
            }
            outFile.Close();
        }

        private string MovieToString(Movie p)
        {
            string retVal = "";
            retVal += p.Name;
            retVal += "|";
            retVal += p.Genre.ToString();
            retVal += "|";
            retVal += p.Rated.ToString();
            retVal += "|";
            retVal += p.Popular.ToString();
            retVal += "|";
            retVal += p.Actors.ToString();
            retVal += "|";
            retVal += p.Sales.ToString();
            retVal += "|";
            retVal += p.Director.ToString();
            retVal += "|";
            retVal += p.Reccomend.ToString();
            retVal += "|";
            retVal += p.Awards.ToString();
            retVal += "|";
            retVal += p.Picture.ToString();
            return retVal;
        }

        void ShowMovie(Movie p)
        {
            NameTextbox.Text = p.Name;
            GenreTextbox.Text = p.Genre;
            RatedTextbox.Text = p.Rated.ToString();
            PopularityTextbox.Text = p.Popular.ToString();
            ActorsTextbox.Text = p.Actors.ToString();
            SalesTextbox.Text = p.Sales.ToString();
            DirectorTextbox.Text = p.Director.ToString();
            checkBox1.Checked = p.Reccomend;
            checkBox2.Checked = p.Awards;
            if (System.IO.File.Exists(p.Picture))
            {
                MoviePictureBox.Load(p.Picture.ToString());
            }

        }
        private void Clear()
        {
            NameTextbox.Text = "";
            GenreTextbox.Text = "";
            RatedTextbox.Text = "";
            SalesTextbox.Text = "";
            PopularityTextbox.Text = "";
            ActorsTextbox.Text = "";
            SalesTextbox.Text = "";
            DirectorTextbox.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            MoviePictureBox.ImageLocation = null;
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                Save();
                current++;
                CurrentLabel.Text = current.ToString();
                ShowMovie(Movies[current]);
            }
        }

        private void LastButton_Click_1(object sender, EventArgs e)
        {
            Save();
            current = count - 1;
            CurrentLabel.Text = current.ToString();
            ShowMovie(Movies[current]);
        }

        private void PreviousButton_Click_1(object sender, EventArgs e)
        {
            if (current > 0)
            {
                Save();
                current--;
                CurrentLabel.Text = current.ToString();
                ShowMovie(Movies[current]);
            }

        }

        private void FirstButton_Click_1(object sender, EventArgs e)
        {
            Save();
            current = 0;
            CurrentLabel.Text = current.ToString();
            ShowMovie(Movies[current]);
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void NewButton_Click_1(object sender, EventArgs e)
        {
            Save();
            current = count;
            count++;
            CurrentLabel.Text = current.ToString();
            Clear();
        }

        private void MoviePictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MoviePictureBox.Load(openFileDialog1.FileName);
        }
    }
}