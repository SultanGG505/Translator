using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransForm
{
    public partial class Form4 : Form
    {
        public int index = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            index++;
            if (index == 1)
            {
                string input = @"some stringy input";
                string call = @"""c:\PHP\php.exe""";
                string param1 = @"-f";
                string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\1.php""";
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
                myProcessStartInfo.UseShellExecute = false;
                myProcessStartInfo.RedirectStandardError = true;
                myProcessStartInfo.RedirectStandardOutput = true;
                myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                StreamReader myStreamReader1 = myProcess.StandardOutput;
                StreamReader myStreamReader2 = myProcess.StandardError;
                string myString1 = myStreamReader1.ReadLine();
                string myString2 = myStreamReader2.ReadLine();
                Output.Text = myString1 + myString2;
            }
             if (index == 2)
            {
                string input = @"some stringy input";
                string call = @"""c:\PHP\php.exe""";
                string param1 = @"-f";
                string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\2.php""";
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
                myProcessStartInfo.UseShellExecute = false;
                myProcessStartInfo.RedirectStandardError = true;
                myProcessStartInfo.RedirectStandardOutput = true;
                myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                StreamReader myStreamReader1 = myProcess.StandardOutput;
                StreamReader myStreamReader2 = myProcess.StandardError;
                string myString1 = myStreamReader1.ReadLine();
                string myString2 = myStreamReader2.ReadLine();
                Output.Text = myString1 + myString2;
            }
            if (index == 3)
            {
                string input = @"some stringy input";
                string call = @"""c:\PHP\php.exe""";
                string param1 = @"-f";
                string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\3.php""";
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
                myProcessStartInfo.UseShellExecute = false;
                myProcessStartInfo.RedirectStandardError = true;
                myProcessStartInfo.RedirectStandardOutput = true;
                myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                StreamReader myStreamReader1 = myProcess.StandardOutput;
                StreamReader myStreamReader2 = myProcess.StandardError;
                string myString1 = myStreamReader1.ReadLine();
                string myString2 = myStreamReader2.ReadLine();
                Output.Text = myString1 + myString2;
            }
            if (index == 4)
            {
                string input = @"some stringy input";
                string call = @"""c:\PHP\php.exe""";
                string param1 = @"-f";
                string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\4.php""";
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
                myProcessStartInfo.UseShellExecute = false;
                myProcessStartInfo.RedirectStandardError = true;
                myProcessStartInfo.RedirectStandardOutput = true;
                myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                StreamReader myStreamReader1 = myProcess.StandardOutput;
                StreamReader myStreamReader2 = myProcess.StandardError;
                string myString1 = myStreamReader1.ReadLine();
                string myString2 = myStreamReader2.ReadLine();
                Output.Text = myString1 + myString2;
            }
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 1;
            string input = @"some stringy input";
            string call = @"""c:\PHP\php.exe""";
            string param1 = @"-f";
            string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\1.php""";
            Process myProcess = new Process();
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardError = true;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
            myProcess.StartInfo = myProcessStartInfo;
            myProcess.Start();
            StreamReader myStreamReader1 = myProcess.StandardOutput;
            StreamReader myStreamReader2 = myProcess.StandardError;
            string myString1 = myStreamReader1.ReadLine();
            string myString2 = myStreamReader2.ReadLine();
            Output.Text = myString1 + myString2;
        }
    }
}
