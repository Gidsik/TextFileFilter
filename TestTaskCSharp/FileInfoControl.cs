using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskCSharp
{
    public partial class FileInfoControl : UserControl
    {
        private string inputFileName;
        private string inputFilePath;

        //private string outputFileName;
        private string outputFilePath;

        private string outputDir;

        private bool outputReady;
        private int state;
        public int State
        {
            get { return state; }
        }

        public FileInfoControl()
        {
            InitializeComponent();

            inputFilePath = "TestFileName.txt";
            
            outputReady = false;

            SetState(0);
            progressBar1.Value = (new Random()).Next(0,100);

        }

        public FileInfoControl(string filePath, string fileName)
        {
            InitializeComponent();

            inputFileName = fileName;
            inputFileNameLabel.Text = inputFilePath = filePath;
            outputFileNameLabel.Text = "выберите файл...";
            outputReady = false;

            SetState(0);
            progressBar1.Value = 0;
        }

        public void SetState(int state)
        {
            switch (state)
            {
                case -1:
                    stateLabel.Text = "Ошибка";
                    break;
                case 0:
                    stateLabel.Text = "Ожидание";
                    break;
                case 1:
                    stateLabel.Text = "Процесс";
                    break;
                case 2:
                    stateLabel.Text = "Готово";
                    break;
                default:
                    return;
            }
            this.state = state;
        }

        public void SetOutputDir(string dir)
        {
            outputDir = dir;
            outputFileNameLabel.Text = outputFilePath = $"{outputDir}/{inputFileName}";
            outputReady = true;
        }

        public void Start()
        {
            if (backgroundWorker.IsBusy || !outputReady)
            {
                return;
            }
            SetState(1);
            backgroundWorker.RunWorkerAsync();
        }

        private void editInputStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show("Операция уже выполняется", inputFilePath);
            }

            if (chooseFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            inputFileNameLabel.Text = inputFilePath = chooseFileDialog.FileName;
            SetState(0);
            progressBar1.Value = 0;
        }

        private void startStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!outputReady)
            {
                return;
            }

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show("Операция уже выполняется", inputFilePath);
            }

            SetState(1);
            backgroundWorker.RunWorkerAsync();
        }

        private void editOuputStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show("Операция уже выполняется");
            }

            if (chooseFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            outputFileNameLabel.Text = outputFilePath = chooseFileDialog.FileName;
            outputReady = true;
            SetState(0);
            progressBar1.Value = 0;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
                backgroundWorker.ReportProgress(0);
                System.IO.StreamReader reader = new System.IO.StreamReader(inputFilePath);
                System.IO.StreamWriter writer = new System.IO.StreamWriter(outputFilePath);
                string inputLine;
                string outputLine;
                int maxLineCount = 0;
                int lineCount = 0;

                while ((inputLine = reader.ReadLine()) != null)
                {
                    maxLineCount++;
                }

                reader.Close();
                reader = new System.IO.StreamReader(inputFilePath);
                while ((inputLine = reader.ReadLine()) != null)
                {
                    outputLine = inputLine;

                    if (Settings.MinLength >= 1)
                    {
                        System.Text.RegularExpressions.Regex regexWords = new System.Text.RegularExpressions.Regex(@"\b(\w{1,"+$"{Settings.MinLength}"+@"})\b");

                        outputLine = regexWords.Replace(outputLine, "");
                    }
                    
                    if (Settings.DeletePunctuation)
                    {
                        System.Text.RegularExpressions.Regex regexPunctuation = new System.Text.RegularExpressions.Regex(@"[.,!?\-;:*\'""()\[\]#^]");

                        outputLine = regexPunctuation.Replace(outputLine, "");
                    }

                    writer.WriteLine(outputLine);

                    lineCount++;
                    //System.Diagnostics.Debug.WriteLine($"to report - {lineCount} / {maxLineCount} = {100 * lineCount / maxLineCount}");
                    backgroundWorker.ReportProgress(100 * lineCount / maxLineCount );
                }

                reader.Close();
                writer.Close();
            
            
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                SetState(-1);
                return;
            }
            
            SetState(2);
            progressBar1.Value = 100;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //System.Diagnostics.Debug.WriteLine($"reported - {e.ProgressPercentage}");
        }

    }
}
