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
using System.IO;
using System.Threading;



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

            var pathI = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//Input.txt";
            var I = File.ReadAllText(pathI);
            InputText.Text = I;

            System.Diagnostics.Process.Start("C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//main.exe");


            var pathC = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//C.txt";
            var C = File.ReadAllText(pathC);
            ConstText.Text = C;

            var pathV = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//I.txt";
            var V = File.ReadAllText(pathV);
            VarsText.Text = V;


            var pathN = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//N.txt";
            var N = File.ReadAllText(pathN);
            NumbersText.Text = N;

            var pathO = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//O.txt";
            var O = File.ReadAllText(pathO);
            OpersText.Text = O;

            var pathR = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//R.txt";
            var R = File.ReadAllText(pathR);
            DivisorsText.Text = R;

            var pathTokens = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//tokens.txt";
            var T = File.ReadAllText(pathTokens);
            TokenText.Text = T;

            var pathW = "C://Users//sulta//OneDrive//Документы//GitHub//Translator//TransForm//TransForm//W.txt";
            var W = File.ReadAllText(pathW);
            SpecialText.Text = W;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TokenText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OpersText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NumbersText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SpecialText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();//Form2 -- вторая форма
            newfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newfrm = new Form3();//Form3
            newfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newfrm = new Form4();//Form4
            newfrm.Show();
        }
    }
}
