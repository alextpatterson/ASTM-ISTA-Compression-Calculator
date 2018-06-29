using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compression_Assistant
{
    public partial class Form2 : Form
    {
        TextBox updateMe;
        public Form2(TextBox tb) : base()
        {
            InitializeComponent();
            updateMe = tb;
        }

        private void unknownAcceptBtn_Click(object sender, EventArgs e)
        {
            int S = 0; //number of boxes
            int H; //box height

            H = int.Parse(boxHTxt.Text);

            if (radioYes.Checked || radioIDK.Checked)
            {
                S =  196 / H;
            }
            else if (RadioNo.Checked)
            {
                S = 90 / H;
            }
            updateMe.Text = S.ToString();
            this.Close();
        }
    }
}
