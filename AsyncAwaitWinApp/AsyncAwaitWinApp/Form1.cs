using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncAwaitWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void MyBtn_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharactersInFile);
            task.Start();
            MyLbl.Text = "Processing file. Please wait...";
            int count = await task;
            MyLbl.Text = count.ToString() + " characters in file";
        }

        private int CountCharactersInFile()
        {
            int count = 0;
            StreamReader sr = new StreamReader(@"C:\Data\File.txt");
            string content = sr.ReadToEnd();
            count = content.Length;
            Thread.Sleep(6000);
            return count;
        }
    }
}
