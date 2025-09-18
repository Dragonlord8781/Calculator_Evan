namespace Calculator_Evan
{
    public partial class Abacus : Form
    {
        string resultString;

        public Abacus()
        {
            InitializeComponent();

            result.Text = " ";
            resultString = result.Text;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            resultString += "*";
            result.Text = resultString;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultString += "7";
            result.Text = resultString;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultString += "8";
            result.Text = resultString;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultString += "9";
            result.Text = resultString;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            resultString += "/";
            result.Text = resultString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultString += "4";
            result.Text = resultString;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultString += "5";
            result.Text = resultString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultString += "6";
            result.Text = resultString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultString += "1";
            result.Text = resultString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultString += "2";
            result.Text = resultString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultString += "3";
            result.Text = resultString;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            resultString += "-";
            result.Text = resultString;
        }

        private void lblResult_Layout(object sender, EventArgs e)
        {

        }

        private void lblTtitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Layout(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultString += "0";
            result.Text = resultString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultString += "+";
            result.Text = resultString;
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            resultString += ".";
            result.Text = resultString;
        }
    }
}