using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskCSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void choseFilesBtn_Click(object sender, EventArgs e)
        {
            if (pickInputFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            choosedFilesPanel.Controls.Clear();

            for (int i = 0; i < pickInputFileDialog.FileNames.Length; i++)
            {
                choosedFilesPanel.Controls.Add(new FileInfoControl(pickInputFileDialog.FileNames[i], pickInputFileDialog.SafeFileNames[i]));
            }
        }

        private void editParamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditParamsForm()).ShowDialog();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            foreach (FileInfoControl c in choosedFilesPanel.Controls)
            {
                c.Start();
            }
        }

        private void pickOutputDirBtn_Click(object sender, EventArgs e)
        {
            if (pickOutputFolderDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach (FileInfoControl c in choosedFilesPanel.Controls)
            {
                c.SetOutputDir(pickOutputFolderDialog.SelectedPath);
            }
        }
    }
}
