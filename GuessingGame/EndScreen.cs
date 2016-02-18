using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();

            resultLabel.Text = "You got it in " + Form1.inputs.Count() + " guesses!"
                + "\n\n" + "Your guesses were: ";
            for (int i = 0; i < Form1.inputs.Count(); i++)
            {
                resultLabel.Text += " " + Form1.inputs[i];
            }
            Form1.inputs.Sort();
            sortLabel.Text = "Sorted list: ";
            for (int i = 0; i < Form1.inputs.Count(); i++)
            {
                sortLabel.Text += " " + Form1.inputs[i];
            }
        }
    }
}
