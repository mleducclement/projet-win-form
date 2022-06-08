namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        long operand;
        string op; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processButtonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand = Convert.ToInt64(display.Text);
            Button button = (Button)sender;
            op = button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(op == "+")
            {     
                display.Text = Add(operand, Convert.ToInt64(display.Text)).ToString();
            }
        }

        void initDisplay()
        {
            display.Text = "0";
        }

        long Add(long x, long y)
        {
            return x + y;
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