using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Compression_Assistant
{
    //Calculates lbs of compression per box depending on the variables entered for ASTM standards
    //there are a couple event handlers and listeners placed at the top of the class.
    //The method's below are for the ASTM calculator functions. For ISTA see ISTAFunctions class.
    public partial class compLab : Form
    {
        public compLab()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
            

            comboBox1.SelectedIndex = 0;
        }
        //Splash Screen launcher
        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }
        //ASTM button listener
        private void calcBtn_Click(object sender, EventArgs e)
        {         
            SetOutput();
        }
        //ISTA button listener
        private void istaBtn_Click(object sender, EventArgs e)
        {

            double height2 = double.Parse(heightBox2.Text);
            double width2 = double.Parse(widthBox2.Text);
            double length2 = double.Parse(lengthBox2.Text);
          
            ISTATopLoad ista = new ISTATopLoad(height2, length2, width2);

            double hcomp = ista.GetHCompression();
            double wcomp = ista.GetWCompression();
            double lcomp = ista.GetLCompression();

            hCompOut.Text = hcomp.ToString("N0") + " lbs";
            wCompOut.Text = wcomp.ToString("N0") + " lbs";
            lCompOut.Text = lcomp.ToString("N0") + " lbs";
            
            if (hcomp < 25)
            {
                hCompOut.BackColor = Color.Salmon;
            }
            else
            {
                hCompOut.BackColor = Color.LightGreen;
            }
            if (wcomp < 25)
            {
                wCompOut.BackColor = Color.Salmon;
            }
            else
            {
                wCompOut.BackColor = Color.LightGreen;
            }
            if (lcomp < 25)
            {
                lCompOut.BackColor = Color.Salmon;
            }
            else
            {
                lCompOut.BackColor = Color.LightGreen;
            }
        }
        //Listener for Apply Release Test Force
        private void ARButton_Click(object sender, EventArgs e)
        {

            double weight = double.Parse(istaWeightTxt.Text);
            int boxes = int.Parse(numBoxesTxt.Text);
            int F = int.Parse(istaFTxt.Text);

            ApplyRelease reg = new ApplyRelease(weight, boxes, F);

            testForceOut.Text = reg.GetApplyRelease().ToString() + " lbs.";
        }

        //allows ENTER to be pressed for calculation if ASTM Tab is selected
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                AcceptButton = calcBtn;
            }
            
        }
        //allows ENTER to be pressed for calculation if ISTA Tab is selected and text for AR has been changed
        private void istaWeightTxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = ARButton;
        }
        //allows ENTER to be pressed for calculation if ISTA Tab is selected and text for top load has been changed
        private void lengthBox2_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = istaBtn;
        }
        private void numBoxesTxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = istaBtn;
        }
        //Returns the volume of the box using entered values (ASTM)
        private double GetVolume()
        {
            double volume = 0;
            double length = 0;
            double width = 0;
            double height = 0;
            string lengthStr;
            string widthStr;
            string heightStr;
            //Throws exception if the entered value is a negative number or if it isn't a number.
            try
            {
                lengthStr = lengthTxt.Text;
                widthStr = widthTxt.Text;
                heightStr = heightTxt.Text;

                length = double.Parse(lengthStr);
                width = double.Parse(widthStr);
                height = double.Parse(heightStr);

                volume = length * width * height;
                volume = volume / 1728;
            }
            catch(NegativeNumberException e)
            {
                MessageBox.Show("\n" + e.Message);
                
            }
            catch(FormatException e)
            {
                MessageBox.Show("\n" + e.Message);
              
            }
            if (width < 0 || height < 0 || length < 0)
            {
                throw new NegativeNumberException("Negative number not permitted.");
            }
            else
            {
                return volume;
            }
        }
        //Returns the "F" factor according to the assurance level (ASTM)
        private double GetFactor()
        {
            double fFactor = 0;

            if (radio1.Checked)
            {
                fFactor = 10.0;
            }
            else if (radio2.Checked)
            {
                fFactor = 7.0;
            }
            else if (radio3.Checked)
            {
                fFactor = 5;
            }
            return fFactor;
        }
        //returns the stack height to test for depending on the volume of the box (ASTM)
        private double GetStackHeight()
        {
            double volume = GetVolume();
            double weight = double.Parse(weightTxt.Text);
            double stack;
            if (comboBox1.Text.Equals("DC:3") || comboBox1.Text.Equals("DC:4") || comboBox1.Text.Equals("DC:6") || comboBox1.Text.Equals("DC:13"))
            {
                if ((volume >= 2) || (weight < 30))
                {
                    stack = 54;
                }
                else
                {
                    stack = 108;
                }
            }
            else
            {
                stack = 108;
            }
            return stack;
        }
        //Displays the ASTM values for stack height, volume, f-factor, assurance level, and the calculated compression.
        private void SetOutput()
        {
            string stackHeight = GetStackHeight().ToString();
            double volume = GetVolume();
            string vol = volume.ToString("N2");
            string factor = GetFactor().ToString();
            string level = null;
            string compressionLBS = GetComp().ToString("N0");

            if (radio1.Checked)
            {
                level = "1";
            }
            else if (radio2.Checked)
            {
                level = "2";
            }
            else if (radio3.Checked)
            {
                level = "3";
            }

            levResult.Text = level;
            volResult.Text = vol + " ft\xB3";
            factorResult.Text = factor;
            stackResult.Text = stackHeight + " in";
            compResult.Text = compressionLBS + " lbs";
        }
        //calculates the compression level according to ASTM standards
        private double GetComp()
        {
            double mf = double.Parse(mfTxt.Text);
            double vol = GetVolume();
            double stack = GetStackHeight();
            double height = double.Parse(heightTxt.Text);
            double weight = double.Parse(weightTxt.Text);
            double F = GetFactor();
            double comp;
            //If the distribution cycle is 3, 4, 6, or 13, use this formula.
            if (comboBox1.SelectedItem.ToString() == "DC:3" || comboBox1.SelectedItem.ToString() == "DC:4" || comboBox1.SelectedItem.ToString() == "DC:6" || comboBox1.SelectedItem.ToString() == "DC:13")
            {
                comp = (mf * 1 * vol) * ((stack - height) / height) * F;
            }
            //If the distribution cycle is 14 or 16, use this formula.
            else
            {
                comp = weight * 1 * ((stack - height) / height) * F;
            }
            return comp;
        }
        //Opens new dialog box if the ISTA AR # of boxes is unknown.
        private void unknownBoxNumBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(numBoxesTxt);
            f2.ShowDialog();
            
        }
        private void help_Click(object sender, EventArgs e)
        {
            Process.Start("userDoc.exe");
        }
    }
}
