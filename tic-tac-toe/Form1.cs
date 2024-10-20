﻿using System;
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
            CheckWin();
            CheckDraw();
            
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
        private void CheckWin()
        {
            if (button11.Text == button12.Text && button12.Text == button13.Text && button11.Text != "") Win();
            else if (button21.Text == button22.Text && button22.Text == button23.Text && button21.Text != "") Win();
            else if (button31.Text == button32.Text && button32.Text == button33.Text && button31.Text != "") Win();
            else if (button11.Text == button22.Text && button22.Text == button33.Text && button11.Text != "") Win();
            else if (button13.Text == button22.Text && button22.Text == button31.Text && button13.Text != "") Win();
            else if (button11.Text == button21.Text && button21.Text == button31.Text && button11.Text != "") Win();
            else if (button12.Text == button22.Text && button22.Text == button32.Text && button12.Text != "") Win();
            else if (button13.Text == button23.Text && button23.Text == button33.Text && button13.Text != "") Win();
            else countMoves++;
        }

        private void Win()
        {
            playerLabel.ForeColor = Color.LightGreen;
            if (countMoves % 2 == 1) playerLabel.Text = "Победил игрок 2";
            else playerLabel.Text = "Победил игрок 1";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;

            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";

            playerLabel.Text = "Игрок 1";
            playerLabel.ForeColor = Color.SkyBlue;

            countMoves = 0;
        }
        private void CheckDraw()
        {
            if (countMoves == 9)
            {
                playerLabel.Text = "Ничья";
                playerLabel.ForeColor = Color.Gray;
            }
        }

    }
}
