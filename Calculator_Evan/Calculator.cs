using System.Data;
using System;

namespace Calculator_Evan
{
    public partial class Abacus : Form
    {
        string resultString; 

        public Abacus()
        {
            InitializeComponent();

            //makes resultString=result, make the result box empty on start
            result.Text = "";
            resultString = result.Text;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //null
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            /*
             try to calculate answer, if error occurs, catch by replacing result.Text with error, if not calculate 
            the answer an replace result.Text with it
            */
            try
            {
                object resultCalc = new DataTable().Compute(resultString, null);

                double calculatedValue = Convert.ToDouble(resultCalc);

                resultString = calculatedValue.ToString();
                result.Text = resultString;
            }
            catch
            {
                resultString = "galidasdv"; //galidasdv means error
                result.Text = resultString;
            }
        }

        //add * to resultString, make result.Text = result string
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            resultString += "*";
            result.Text = resultString;
        }

        //add 7 to resultString, make result.Text = result string
        private void button7_Click(object sender, EventArgs e)
        {
            resultString += "7";
            result.Text = resultString;
        }

        //add 8 to resultString, make result.Text = result string
        private void button8_Click(object sender, EventArgs e)
        {
            resultString += "8";
            result.Text = resultString;
        }

        //add 9 to resultString, make result.Text = result string
        private void button9_Click(object sender, EventArgs e)
        {
            resultString += "9";
            result.Text = resultString;
        }

        //add / to resultString, make result.Text = result string
        private void btnDiv_Click(object sender, EventArgs e)
        {
            resultString += "/";
            result.Text = resultString;
        }

        //add 4 to resultString, make result.Text = result string
        private void button4_Click(object sender, EventArgs e)
        {
            resultString += "4";
            result.Text = resultString;
        }

        //add 5 to resultString, make result.Text = result string
        private void button5_Click(object sender, EventArgs e)
        {
            resultString += "5";
            result.Text = resultString;
        }

        //add 6 to resultString, make result.Text = result string
        private void button6_Click(object sender, EventArgs e)
        {
            resultString += "6";
            result.Text = resultString;
        }

        //add 1 to resultString, make result.Text = result string
        private void button1_Click(object sender, EventArgs e)
        {
            resultString += "1";
            result.Text = resultString;
        }

        //add 2 to resultString, make result.Text = result string
        private void button2_Click(object sender, EventArgs e)
        {
            resultString += "2";
            result.Text = resultString;
        }

        //add 3 to resultString, make result.Text = result string
        private void button3_Click(object sender, EventArgs e)
        {
            resultString += "3";
            result.Text = resultString;
        }

        //add - to resultString, make result.Text = result string
        private void btnSub_Click(object sender, EventArgs e)
        {
            resultString += "-";
            result.Text = resultString;
        }

        private void lblResult_Layout(object sender, EventArgs e)
        {
            //null
        }

        private void lblTtitle_Click(object sender, EventArgs e)
        {
            //null
        }

        private void label1_Layout(object sender, EventArgs e)
        {
            //null
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            //null
        }

        //clears result
        private void buttonCE_Click(object sender, EventArgs e)
        {
            resultString = "";
            result.Text = resultString;
        }

        //add 0 to resultString, make result.Text = result string
        private void button0_Click(object sender, EventArgs e)
        {
            resultString += "0";
            result.Text = resultString;
        }

        //add + to resultString, make result.Text = result string
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultString += "+";
            result.Text = resultString;
        }

        //add . to resultString, make result.Text = result string
        private void btnDes_Click(object sender, EventArgs e)
        {
            resultString += ".";
            result.Text = resultString;
        }
    }
}