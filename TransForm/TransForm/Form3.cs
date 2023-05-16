using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransForm
{
    public partial class Form3 : Form
    {
        public int index = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ishod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 1)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_opz.txt");
                Output.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_Out.txt");
                label1.Text = "№1";

            }
            if (index == 2)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_opz.txt");
                Output.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_Out.txt");
                label1.Text = "№2";

            }
            if (index == 3)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_opz.txt");
                Output.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_Out.txt");
                label1.Text = "№3";

            }
            if (index == 4)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_4_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_4_opz.txt");
                Output.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_4_Out.txt");
                label1.Text = "№4";

            }

        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            index = 1;
            Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_iskhodny_kod.txt");
            OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_opz.txt");
            Output.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_Out.txt");
            label1.Text = "№1";
        }
    }
}
