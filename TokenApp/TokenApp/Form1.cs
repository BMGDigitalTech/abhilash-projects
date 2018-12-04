using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenApp
{
    public partial class Form1 : Form
    {
        public static int token = 0;
        public static Queue<int> queueToken;

        public Form1()
        {
            InitializeComponent();
            queueToken = new Queue<int>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            token++;
            queueToken.Enqueue(token);
            UpdateListBox();

        }

        private void UpdateListBox()
        {
            tokenListBox.Items.Clear();
            foreach (int item in queueToken)
            {
                tokenListBox.Items.Add(item);
            }
            int cnt = queueToken.Count == 0 ? 0 : queueToken.Count - 1; 
            WatingListLabel.Text = "There are " + cnt + " before you in the queue";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallCustomerInQueue(textBox1, 1);
        }

        private void CallCustomerInQueue(TextBox textbox,int counterNumber)
        {
            if (queueToken.Count == 0)
            {
                textbox.Text = "No customers";
            }
            else
            {
                int item = queueToken.Dequeue();
                textbox.Text = item.ToString();
                CurrentProcessLabel.Text = "Token Number: " + item.ToString() + " Please go to counter " + counterNumber;
                UpdateListBox();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallCustomerInQueue(textBox2, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallCustomerInQueue(textBox3, 3);
        }
    }
}
