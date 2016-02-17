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

            resultLabel.Text = "You got it in " + inputs.Count();
        }
    }
}
