using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool Turn { get; set; } = true; // true = X turn, false = Y turn;
        public int Count { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Me", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            Count++;
            Turn = !Turn;
            button.Enabled = false;

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool thereIsaWinner = false;
            //Horizontal Checks
            if (A1Btn.Text == A2Btn.Text && A2Btn.Text == A3Btn.Text && !A1Btn.Enabled)
            {
                thereIsaWinner = true;
            }
            if (B1Btn.Text == B2Btn.Text && B2Btn.Text == B3Btn.Text && !B1Btn.Enabled)
            {
                thereIsaWinner = true;
            }
            if (C1Btn.Text == C2Btn.Text && C2Btn.Text == C3Btn.Text && !C1Btn.Enabled)
            {
                thereIsaWinner = true;
            }

            //Vertical Checks
            if (A1Btn.Text == B1Btn.Text && B1Btn.Text == C1Btn.Text && !A1Btn.Enabled)
            {
                thereIsaWinner = true;
            }
            if (A2Btn.Text == B2Btn.Text && B2Btn.Text == C2Btn.Text && !A2Btn.Enabled)
            {
                thereIsaWinner = true;
            }
            if (A3Btn.Text == B3Btn.Text && B3Btn.Text == C3Btn.Text && !A3Btn.Enabled)
            {
                thereIsaWinner = true;
            }

            //Diagonal Checks
            if (A1Btn.Text == B2Btn.Text && B2Btn.Text == C3Btn.Text && !A1Btn.Enabled)
            {
                thereIsaWinner = true;
            }
            if (A3Btn.Text == B2Btn.Text && B2Btn.Text == C1Btn.Text && !A3Btn.Enabled)
            {
                thereIsaWinner = true;
            }



            if (thereIsaWinner)
            {
                DisableButtons();
                string winner = "";
                if (Turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                Count = 0;
                MessageBox.Show(winner + "Wins!");
            }
            else
            {
                if (Count == 9)
                {
                    MessageBox.Show("Draw, Bummer!");
                }
            }
        }
        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

    }
}
