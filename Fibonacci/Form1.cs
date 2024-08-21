using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberofloops = 0;
        int secondlatestnumber = 0;
        int latestnumber = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            secondlatestnumber = 0;
            latestnumber = 1;

            int.TryParse(textBox1.Text, out numberofloops);

            richTextBox1.Text = secondlatestnumber.ToString() + " " + (latestnumber).ToString();

            for (int timeslooped = 0; timeslooped < numberofloops; timeslooped++)
            {
                richTextBox1.Text += " ";
                int newLatestNumber = secondlatestnumber + latestnumber;
                richTextBox1.Text += newLatestNumber;
                secondlatestnumber = latestnumber;
                latestnumber = newLatestNumber;
            }
        }
    }
}
