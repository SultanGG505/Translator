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
    public partial class Form2 : Form
    {
        public int index = 0;
        public Form2()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            Ishod.ReadOnly = true;
            OPZ.ReadOnly = true;
            Leksems.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 1)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_opz.txt");
                Leksems.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_tokeny.txt");
               
            }
            if (index == 2)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_opz.txt");
                Leksems.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_tokeny.txt");
                
            }
            if (index == 3)
            {
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_iskhodny_kod.txt");
                OPZ.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_opz.txt");
                Leksems.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_tokeny.txt");

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
