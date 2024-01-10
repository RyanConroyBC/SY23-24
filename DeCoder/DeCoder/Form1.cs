using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar)
            {
                case 'a':
                    label1.Text += '?';
                    break;
                case 'b':
                    label1.Text += 'X';
                    break;
                case 'c':
                    label1.Text += '-';
                    break;
                case 'd':
                    label1.Text += '+';
                    break;
                case 'e':
                    label1.Text += '(';
                    break;
                case 'f':
                    label1.Text += '&';
                    break;
                case 'g':
                    label1.Text += '%';
                    break;
                case 'h':
                    label1.Text += 'B';
                    break;
                case 'i':
                    label1.Text += '9';
                    break;
                case 'j':
                    label1.Text += '!';
                    break;
                case 'k':
                    label1.Text += 'Z';
                    break;
                case 'l':
                    label1.Text += 'L';
                    break;
                case 'm':
                    label1.Text += '}';
                    break;
                case 'n':
                    label1.Text += '>';
                    break;
                case 'o':
                    label1.Text += '@';
                    break;
                case 'p':
                    label1.Text += '*';
                    break;
                case 'q':
                    label1.Text += '$';
                    break;
                case 'r':
                    label1.Text += '#';
                    break;
                case 's':
                    label1.Text += ')';
                    break;
                case 't':
                    label1.Text += '"';
                    break;
                case 'u':
                    label1.Text += '^';
                    break;
                case 'v':
                    label1.Text += '_';
                    break;
                case 'w':
                    label1.Text += '|';
                    break;
                case 'y':
                    label1.Text += '/';
                    break;
                case 'x':
                    label1.Text += '8';
                    break;
                case 'z':
                    label1.Text += 'A';
                    break;
                default:
                    label1.Text = "";
                    break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '?':
                    label4.Text += 'a';
                    break;
                case 'X':
                    label4.Text += 'b';
                    break;
                case '-':
                    label4.Text += 'c';
                    break;
                case '+':
                    label4.Text += 'd';
                    break;
                case '(':
                    label4.Text += 'e';
                    break;
                case '&':
                    label4.Text += 'f';
                    break;
                case '%':
                    label4.Text += 'g';
                    break;
                case 'B':
                    label4.Text += 'h';
                    break;
                case '9':
                    label4.Text += 'i';
                    break;
                case '!':
                    label4.Text += 'j';
                    break;
                case 'Z':
                    label4.Text += 'k';
                    break;
                case 'L':
                    label4.Text += 'l';
                    break;
                case '}':
                    label4.Text += 'm';
                    break;
                case '>':
                    label4.Text += 'n';
                    break;
                case '@':
                    label4.Text += 'o';
                    break;
                case '*':
                    label4.Text += 'p';
                    break;
                case '$':
                    label4.Text += 'q';
                    break;
                case '#':
                    label4.Text += 'r';
                    break;
                case ')':
                    label4.Text += 's';
                    break;
                case '"':
                    label4.Text += 't';
                    break;
                case '^':
                    label4.Text += 'u';
                    break;
                case '_':
                    label4.Text += 'v';
                    break;
                case '|':
                    label4.Text += 'w';
                    break;
                case 'y':
                    label4.Text += 'x';
                    break;
                case '8':
                    label4.Text += 'y';
                    break;
                case 'A':
                    label4.Text += 'z';
                    break;
                default:
                    label4.Text = "";
                    break;
            }
        }
    }
    }
