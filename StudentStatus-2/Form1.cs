using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStatus_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value;

            // Show the Trackbar value in the lblCredits for user feedback
            lblCredits.Text = trkCredits.Value.ToString();

            // Display the status of the student based on the credits he/she is taking
            if (credits >= 12)
            {
                lblStatus.Text = "Full time";
            }
            else if (credits >= 6)
            {
                lblStatus.Text = "Half time";
            }
            else
            {
                lblStatus.Text = "Less than half time";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
