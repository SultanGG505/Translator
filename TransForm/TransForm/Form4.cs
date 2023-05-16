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
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prepare input
            string input = @"some stringy input";

            //NOTE: change path according to your own PHP.exe file, if you have the proper environment variables setup, then you can just call PHP.exe directly without the path
            string call = @"""c:\PHP\php.exe""";

            //To execute the PHP file.
            string param1 = @"-f";

            //the PHP wrapper class file location. NOTE: remember to enclose in " (quotes) if there is a space in the directory structure.
            string param2 = @"""C:\Users\sulta\OneDrive\Документы\GitHub\Translator\TransForm\TransForm\phps\1.php""";

            Process myProcess = new Process();

            // Start a new instance of this program but specify the 'spawned' version. using the PHP.exe file location as the first argument.
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(call, "spawn");
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardError = true;
            myProcessStartInfo.RedirectStandardOutput = true;

            //Provide the other arguments.
            myProcessStartInfo.Arguments = string.Format("{0} {1} {2}", param1, param2, input);
            myProcess.StartInfo = myProcessStartInfo;

            //Execute the process
            myProcess.Start();
            StreamReader myStreamReader1 = myProcess.StandardOutput;
            StreamReader myStreamReader2 = myProcess.StandardError;
            // Read the standard output of the spawned process.
            string myString1 = myStreamReader1.ReadLine();
            string myString2 = myStreamReader2.ReadLine();
            //string filePath = "C:/Users/sulta/OneDrive/Документы/GitHub/Translator/TransForm/TransForm/texts/buffer.txt";

            // Записываем строку в файл
           


            Output.Text = myString1 + myString2;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
