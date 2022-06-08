namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        long operand = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            processOperatorClick(sender);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            processOperatorClick(sender);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            processOperatorClick(sender);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            processOperatorClick(sender);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+":
                    display.Text = Add(operand, Convert.ToInt64(display.Text)).ToString();
                    break;

                case "-":
                    display.Text = Subtract(operand, Convert.ToInt64(display.Text)).ToString(); 
                    break;

                case "x":
                    display.Text = Multiply(operand, Convert.ToInt64(display.Text)).ToString();
                    break;

                case "/":
                    display.Text = Divide(operand, Convert.ToDouble(display.Text)).ToString();
                    break;
            }

            operand = 0;
            op = "";
        }

        long Add(long x, long y)
        {
            return x + y;
        }

        long Subtract(long x, long y)
        {
            return x - y;
        }

        long Multiply(long x, long y)
        {
            return x * y;
        }

        double Divide(double x, double y)
        {
            if(y < 0)
            {
                throw new ArgumentException(String.Format($"Cannot divide by zero :: {y} = 0"));
            }

            return x / y;
        }

        void processOperatorClick(object sender)
        {
            operand = Convert.ToInt64(display.Text);

            Button button = (Button)sender;
            op = button.Text;
            display.Text = "0";
        }

        void processButtonClick(object sender)
        {
            clearDisplayIfZero();
            addDigitToDisplay(sender);
        }

        void clearDisplayIfZero()
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
        }

        void addDigitToDisplay(object sender)
        {
            Button button = (Button)sender;
            display.Text += button.Text;
        }
    }
}

