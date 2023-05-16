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
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_iskhodny_kod.txt");
                if (myString2 != null && myString2 != "")
                {
                    int errorIndex = myString2.IndexOf("error:") + "error:".Length;
                    int inIndex = myString2.IndexOf("in", errorIndex);
                    string content = myString2.Substring(errorIndex, inIndex - errorIndex).Trim();

                    // Запись последних трех слов в отдельную строку
                    string[] words = myString2.Split(' ');
                    int length = words.Length;
                    string lastThreeWords = $"{words[length - 3]} {words[length - 2]} {words[length - 1]}";

                    Console.WriteLine("Извлеченное содержимое: " + content);
                    Console.WriteLine("Последние три слова: " + lastThreeWords);

                    Output.Text = content + lastThreeWords;
                }
                else
                {
                    Output.Text = "Ошибок нет";
                }


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
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_2_iskhodny_kod.txt");
                if (myString2 != null && myString2 != "")
                {
                    int errorIndex = myString2.IndexOf("error:") + "error:".Length;
                    int inIndex = myString2.IndexOf("in", errorIndex);
                    string content = myString2.Substring(errorIndex, inIndex - errorIndex).Trim();

                    // Запись последних трех слов в отдельную строку
                    string[] words = myString2.Split(' ');
                    int length = words.Length;
                    string lastThreeWords = $"{words[length - 3]} {words[length - 2]} {words[length - 1]}";

                    Console.WriteLine("Извлеченное содержимое: " + content);
                    Console.WriteLine("Последние три слова: " + lastThreeWords);

                    Output.Text = content + lastThreeWords;
                }
                else
                {
                    Output.Text = "Ошибок нет";
                }
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
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_3_iskhodny_kod.txt");
                if (myString2 != null && myString2 != "")
                {
                    int errorIndex = myString2.IndexOf("error:") + "error:".Length;
                    int inIndex = myString2.IndexOf("in", errorIndex);
                    string content = myString2.Substring(errorIndex, inIndex - errorIndex).Trim();

                    // Запись последних трех слов в отдельную строку
                    string[] words = myString2.Split(' ');
                    int length = words.Length;
                    string lastThreeWords = $"{words[length - 3]} {words[length - 2]} {words[length - 1]}";

                    Console.WriteLine("Извлеченное содержимое: " + content);
                    Console.WriteLine("Последние три слова: " + lastThreeWords);

                    Output.Text = content + lastThreeWords;
                }
                else
                {
                    Output.Text = "Ошибок нет";
                }
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
                Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_4_iskhodny_kod.txt");
                if (myString2 != null && myString2 != "")
                {
                    int errorIndex = myString2.IndexOf("error:") + "error:".Length;
                    int inIndex = myString2.IndexOf("in", errorIndex);
                    string content = myString2.Substring(errorIndex, inIndex - errorIndex).Trim();

                    // Запись последних трех слов в отдельную строку
                    string[] words = myString2.Split(' ');
                    int length = words.Length;
                    string lastThreeWords = $"{words[length - 3]} {words[length - 2]} {words[length - 1]}";

                    Console.WriteLine("Извлеченное содержимое: " + content);
                    Console.WriteLine("Последние три слова: " + lastThreeWords);

                    Output.Text = content + lastThreeWords;
                }
                else
                {
                    Output.Text = "Ошибок нет";
                }
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
            Ishod.Text = File.ReadAllText("C:\\Users\\sulta\\OneDrive\\Документы\\GitHub\\Translator\\TransForm\\TransForm\\texts\\Primer_1_iskhodny_kod.txt");
            if (myString2 != null && myString2 != "")
            {
                int errorIndex = myString2.IndexOf("error:") + "error:".Length;
                int inIndex = myString2.IndexOf("in", errorIndex);
                string content = myString2.Substring(errorIndex, inIndex - errorIndex).Trim();

                // Запись последних трех слов в отдельную строку
                string[] words = myString2.Split(' ');
                int length = words.Length;
                string lastThreeWords = $"{words[length - 3]} {words[length - 2]} {words[length - 1]}";

                Console.WriteLine("Извлеченное содержимое: " + content);
                Console.WriteLine("Последние три слова: " + lastThreeWords);

                Output.Text = content + lastThreeWords;
            }
            else
            {
                Output.Text = "Ошибок нет";
            }
        }
    }
}
