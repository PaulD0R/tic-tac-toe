using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countMoves = 0;
        }

        private void ClickCell(object sender, EventArgs e)
        {
            CheckCorrect(sender);
            GameRules(sender);
            countMoves++;
            
        }
        private void CheckCorrect(object sender)
        {
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
        }

        private void GameRules(object sender)
        {
            if (countMoves % 2 == 0)
            {
                sender.GetType().GetProperty("Text").SetValue(sender, "x");
                playerLabel.Text = "Игрок 2";
                playerLabel.ForeColor = Color.IndianRed;
            }
            else
            {
                sender.GetType().GetProperty("Text").SetValue(sender, "o");
                playerLabel.Text = "Игрок 1";
                playerLabel.ForeColor = Color.SkyBlue;
            }
        }

    }
}
