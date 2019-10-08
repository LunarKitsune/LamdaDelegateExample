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

        /*
         *  Delegates: A Type safe pointer to a function with a matching signature. 
         *  
         *  Delegates are declared using the delegate key word. 
         * 
         *  There are a couple of good things to know about delegates:
         *      *You can either go by the parameters if you are just inserting variables
         *      
         *      *if you go with LINQ expressions with delegates, parameter must be a matching signature
         *     to the delegate parameters (delegate parameters are int int, parameters are int int)
         *      
         *      
         */ 

        #region Delegates
        private delegate int doCalc(int numberOne, int numberTwo); //First Delegate

        private delegate int squareNum(int Number); //Delegate used for squaring numbers

        private delegate double getSquareArea(double x, double y);

        #endregion Delegates

        #region Buttons
        private void BtnDelegate_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;

            //Parameters to be used within the delegate  instantiations.
            int firstNumber, secondnumber;
            
            //Here we instantiate doCalc and point to the methods AddNums, and subtract respectively with delegate b and c
            
            //Recal that doCalc requires parameters int, int. ( delegate doCalc(int number1, int number2) )
            doCalc b = addNums;
            doCalc c = Subtract;
            
            if(int.TryParse(txtNumOneInput.Text, out firstNumber) == true && int.TryParse(txtNum2Input.Text, out secondnumber) == true)
            {
                //Here when we need to call the delegates and run them for a result its essentially this
                //you call your instantiaton of your delegate in this case b, and then insert parameters that would've been
                //inserted into the provided methods otherwise.
                
                //delegateVariable[method parameters of method provided]
                //equivalant to addNums(firstNumber, secondNumber)
                rtbOutput.Text = $"Adding Numbers: {b(firstNumber, secondnumber)}\r\n";
                
                //Same thing here for delegate b, but doing this for c with the subtract method rather than the addNums
                //Method
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

            //Here squareNum is declared here. It expects an integer
            //(recall delegate int squareNum(int number) where number is an parameter
            squareNum squareThis = x => x * x;

            //we declare firstNumber here wich will be being put in place to the parameter
            int firstNumber;

            if (int.TryParse(txtNumOneInput.Text, out firstNumber) == true)
            {
                //we call square this as: delegate[Parameter to insert] to get the result
                rtbOutput.Text = $"This number squared from number 1 text box is {squareThis(firstNumber)}";
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

            //Here we define getSquareArea delegate "getArea"

            //Recall the delegate is defined as: getSquareArea(double x double Y)

            //In order to insert two parameters we define get area and then after the equals sign
            //and make up the paramaters double a, and double b, and how they will be interacting after
            //the LINQ expression.

            //This basically says with get area using double a and b, Multiply both the parameters by each othr
            //to get a result. 
            getSquareArea getArea = (double a, double b) => a * b;

            //These will be the parameters to be inserted
            int length = 20, width = 10;


            //Same as the squareNum example, the delegate pointer is insterted(getArea)
            //with the parameter inserts of length, and width.
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

            //variable used for the conditional statement in the upcoming LINQ statement
            int high = 5;

            //This is a general LINQ expression. this is used to enumerate over a list. 
            //In this method a list of numbers is generated in a for loop making numbers 1 - 10

            //This expression will become a list essentially saying
            //collected numbers x where x in numbers list is heigher than 5.
            var greaterThan = numbers.Where(x => x > high);

            rtbOutput.Text = $"These are the numbers greater than 5:\n{"".PadRight(25, '*')}\r\n";

            foreach(int greaterInteger in numbers)
            {
                rtbOutput.Text += $"{greaterInteger}\r\n";
            }
        }

        #endregion buttons


        //FUNCTIONS meant to go into the delegate pointers for demonstration
        #region general form functions

        private int addNums(int integer1, int integer2)
        {
            return integer1 + integer2;
        }

        private int Subtract(int integer1, int integer2)
        {
            return integer1 - integer2;
        }
        #endregion general form functions
    }
}
