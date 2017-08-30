using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{

    //This project/program is designed to roll a dice of 6 sides through a random object. 
    //The random object will be called 20 times, this is the rolling function, so that the dice doesn't roll instantly. 
    public partial class Form1 : Form
    {

        private int randomNumber = 0;//Integer in which the dice outcome will depend on. 
        private Random rand = new Random();
        private List<Image> imagelist = new List<Image>();//List to store the die images (sides 1 - 6)
        private int timerCounter = 0;//Timer counter, set to 20 on button listener. 

        //Directory of the images. 
        string string1 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/One.jpg";
        string string2 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/Two.jpg";
        string string3 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/Three.jpg";
        string string4 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/Four.jpg";
        string string5 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/Five.jpg";
        string string6 = "C:/Users/YW_ADMIN/Documents/Visual Studio 2015/Projects/DiceRoller/DiceRoller/bin/Dice/Six.jpg";

        //Upon application start up, the images will be added to the object List named imagelist. 
        public Form1()
        {
            InitializeComponent();

            imagelist.Clear();
            imagelist.Add(Image.FromFile(string1));
            imagelist.Add(Image.FromFile(string2));
            imagelist.Add(Image.FromFile(string3));
            imagelist.Add(Image.FromFile(string4));
            imagelist.Add(Image.FromFile(string5));
            imagelist.Add(Image.FromFile(string6));
        }

        //Button listener.
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Set the counter to 20, everytime the timer ticks (1 millisecond), 1 second would be 1000 for timer interval. 
            //Start the timer. 
            timerCounter = 20;
            timer2.Interval = 10;
            timer2.Start();
        }

        //void method to generate a new random number (1 - 6) from the imagelist. 
        //Call the result method with the generated random number as the output parameter. 
        private void randomInt()
        {
            randomNumber = rand.Next(imagelist.Count + 1);
            result(randomNumber);
        }

        //void result method, the input parameter is the int number. int number is the randomly generated number given out by void randomInt() method. 
        private void result(int number)
        {

            //If the number is x, then return the corresponding image with the x number of sides using returnImagePath method with x being the output parameter. 
            //Also label will change upon x changing. 
            switch (number)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a ONE";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a TWO";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a THREE";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a FOUR";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a FIVE";
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(returnImagePath(number));
                    lblResult.Text = "You rolled a SIX";
                    break;
            }
        }

        private string returnImagePath(int number)
        {
            
            //If number is x, then return the corresponding string to number x. 
            if (number == 1)
            {
                return string1;
            }
            else if (number == 2)
            {
                return string2;
            }
            else if (number == 3)
            {
                return string3;
            }
            else if (number == 4)
            {
                return string4;
            }
            else if (number == 5)
            {
                return string5;
            }
            else
            {
                return string6;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //For every timer tick of 1 millisecond, the int timerCounter decrements by 1. 
            timerCounter--;

            //Call this method to roll the dice while timer ticks. 
            randomInt();

            //label1.Text = timerCounter.ToString();

            //If the counter reaches 0, stop the timer and reset the counter back up to 20. 
            if (timerCounter == 0)
            {
                timer2.Stop();
                timerCounter = 20;
            }
        }
    }
}
