//TO DO: Document with comments with all understanding on how everything works for the clearer pictures of things.
//I do not feel the document provided in class is a clear enough example with bad variable names, and non-bullet proofing
//included in the paper. I have fixed some of these issues to make this more professional.


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Delegates
        private delegate int doCalc(int numberOne, int numberTwo); //First Delegate

        private delegate int squareNum(int Number); //Delegate used for squaring numbers

        private delegate double getSquareArea(double x, double y);

        #endregion Delegates

        #region Buttons
        private void BtnDelegate_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;

            int firstNumber, secondnumber;
            doCalc b = new doCalc(addNums);
            doCalc c = new doCalc(Subtract);
            
            if(int.TryParse(txtNumOneInput.Text, out firstNumber) == true && int.TryParse(txtNum2Input.Text, out secondnumber) == true)
            {
                rtbOutput.Text = $"Adding Numbers: {b(firstNumber, secondnumber)}\r\n";

                rtbOutput.Text = $"Subtracting Numbers: {c(firstNumber, secondnumber)}";
                
            }
            else
            {
                MessageBox.Show("Invalid input", "Number inputs");
                rtbOutput.Text = "Error";
            }
        }

        private void BtnLamda_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            squareNum sqareThis = x => x * x;
            int firstNumber;

            if (int.TryParse(txtNumOneInput.Text, out firstNumber) == true)
            {
                rtbOutput.Text = $"This number squared from number 1 text box is {sqareThis(firstNumber)}";
            }
            else
            {
                MessageBox.Show("Invalid input", "Number input 1");
                rtbOutput.Text = "Error";
            }
        }

        private void BtnDelegateAlt_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();

            getSquareArea getArea = (double a, double b) => a * b;

            int length = 20, width = 10;

            rtbOutput.Text = $"Area using 20ft * 10ft is {getArea(length, width)}";

        }

        private void BtnEnumerateCollection_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();

            List<int> numbers = new List<int>();

            for(int i = 0; i <= 10; i++)
            {
                numbers.Add(i);
            }

            int high = 5;

            var greaterThan = numbers.Where(x => x > high);

            rtbOutput.Text = $"These are the numbers greater than 5:\n{"".PadRight(25, '*')}\r\n";

            foreach(int greaterInteger in numbers)
            {
                rtbOutput.Text += $"{greaterInteger}\r\n";
            }
        }

        #endregion buttons

        #region general form functions

        private int addNums(int integer1, int integer2)
        {
            return integer1 + integer2;
        }

        private int Subtract(int integer1, int integer2)
        {
            return integer1 - integer2;
        }

        private int 

        #endregion general form functions
    }
}
