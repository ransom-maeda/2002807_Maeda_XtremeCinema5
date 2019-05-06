using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_XtremeCinema5
{
    public partial class Form1 : Form
    {
        //import variables
        double movieCost = 0,
            totalBalance = 0,
            balance = 0,
            totalMovie,
            totalMember,
            newMovie,
            member;
        int customers = 0;
        string message;
        DialogResult response;


        private void selectColor()
        {
            colorChange.ShowDialog();
        }

        private void selectFont()
        {
            fontChange.ShowDialog();
        }

        //displays a summary of things
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string summaryString = "Total customers - " + customers.ToString() +
    "\n" + "Total Balance - " + totalBalance.ToString("C");

            MessageBox.Show(summaryString, "Summary",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //selects color and sets form color to choice
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor();
            this.BackColor = colorChange.Color;
        }

        //selects font and sets amount due to that font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectFont();
            amountDueOutput.Font = fontChange.Font;
        }

        //displays the order complete
        private void orderCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message = "Is your order complete?";
            response = MessageBox.Show(message, "Order Complete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (response == DialogResult.Yes)
            {
                amountDueOutput.Clear();
                movieTitle.Clear();
                memberToggle.Checked = false;
                memberToggle.Enabled = true;
                newRelease.Checked = false;
                bd.Checked = false;
                dvd.Checked = false;
                balance = 0;
            }
        }

        //clears all values
        private void clearForNextItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amountDueOutput.Clear();
            movieTitle.Clear();
            dvd.Checked = false;
            bd.Checked = false;
            memberToggle.Checked = false;
            newRelease.Checked = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //displays program name and who it was programmed by
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program name - Xtreme Cinema Unit 5 \nProgrammed by - Ransom Maeda");
        }

        //calculates for the charge of a movie
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvd.Checked)
                {
                    movieCost = 4.5;
                }
                else if (bd.Checked)
                {
                    movieCost = 5;
                }

                if (memberToggle.Checked)
                {
                    memberToggle.Enabled = false;
                }
                customers++;
                newMovie++;
                totalMovie = movieCost + newMovie;
                totalMember = totalMovie * member;
                balance = totalMovie - totalMember;
                totalBalance += balance;

                amountDueOutput.Text = totalBalance.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
        }
    }
}
