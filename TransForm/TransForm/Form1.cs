using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;



namespace TransForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCmdText;

            strCmdText = "/C python C://Users//SultanGG505_PC//Documents//GitHub//Translator//TransForm//TransForm//main.py";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
