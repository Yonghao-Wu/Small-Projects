using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        //Controls initialization
        private Label lblFibNumber = new Label();
        private TextBox txtInput = new TextBox(), txtOutput = new TextBox();
        private Button btnGetTheNumber = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Label to display fibonacci number at given index
            this.lblFibNumber.Text = "Result";
            this.lblFibNumber.Location = new Point(13, 70);
            this.lblFibNumber.Size = new Size(65, 15);
            this.Controls.Add(lblFibNumber);

            //Textbox to enter index && watermark for design purposes
            this.txtInput.Size = new Size(111, 20);
            this.txtInput.Location = new Point(13, 13);
            this.txtInput.ForeColor = Color.Gray;
            this.txtInput.Text = "Enter Index...";
            this.txtInput.GotFocus += TxtInput_GotFocus;
            this.txtInput.LostFocus += TxtInput_LostFocus;
            this.Controls.Add(txtInput);

            //Button to submit the index to retrieve the fibonacci number
            this.btnGetTheNumber.Text = "Get Number";
            this.btnGetTheNumber.Size = new Size(75, 23);
            this.btnGetTheNumber.Location = new Point(13, 43);
            this.btnGetTheNumber.Click += new EventHandler(this.btnGetTheNumber_Click);
            this.Controls.Add(btnGetTheNumber);

            //Fun output textbox
            this.txtOutput.Text = "";
            this.txtOutput.Size = new Size(111, 20);
            this.txtOutput.Location = new Point(13, 90);
            this.txtOutput.ReadOnly = true;
            this.Controls.Add(txtOutput);

        }

        //If the textbox lost focus or the user clicks on another textbox and leaves the applied textbox blank, the background watermark will appear. 
        private void TxtInput_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInput.Text)) {
                this.txtInput.Text = "Enter Index...";
                this.txtInput.ForeColor = Color.Gray;
            }
        }

        //If the textbox regains its focus, the user clicks on the textbox while the watermark is active, it will go away until the user leaves it again. 
        private void TxtInput_GotFocus(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.txtInput.Text))
            {
                this.txtInput.Text = "";
                this.txtInput.ForeColor = Color.Black;
            }

        }

        //Button click to determine the fibonacci number at given index and the given index output. 
        private void btnGetTheNumber_Click(object sender, EventArgs e)
        {
            //Create a list of integers. 
            List<int> fibList = new List<int>();

            //Add the numbers 0 and 1 as starting numbers for the fibonacci, this is required. 
            fibList.Add(0);
            fibList.Add(1);

            //Output of user typed index. 
            txtOutput.Text = "Entered Index: " + txtInput.Text;

            //variable is the value of txtInput, if checks to see if variable is a number, if so, parse variable to become an integer. 
            var variable = txtInput.Text;
            if (isNumber(variable) == true)
            {
                int input = int.Parse(variable);

                //If the user input of index is less than or equal to 0, it will not work, lowest index is 1. 
                if (input > 0)
                {
                    //Core logic of the program, fibonacci.
                    for (int i = 2; i < input; i++)
                    {
                        int number = 0;
                        number = fibList.ElementAt(i - 1) + fibList.ElementAt(i - 2);
                        fibList.Add(number);
                    }

                    lblFibNumber.Text = fibList.ElementAt(input - 1).ToString();
                }//end of if
                else
                    MessageBox.Show("There are no number below index of 0.");
            }//End of if
            else
                MessageBox.Show("You did not enter in any numbers.");

        }

        //Method to check if string contains numbers. 
        private bool isNumber(string input) {
            
            foreach(char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
