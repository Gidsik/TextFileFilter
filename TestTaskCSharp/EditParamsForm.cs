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
    public partial class EditParamsForm : Form
    {
        public EditParamsForm()
        {
            InitializeComponent();
            deletePunctuationCheckBox.Checked = Settings.DeletePunctuation;
            minLengthTextBox.Text = Settings.MinLength.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int tempParse;
            if (int.TryParse(minLengthTextBox.Text, out tempParse))
            {
                Settings.MinLength = tempParse;
                this.DialogResult = DialogResult.OK;
                Settings.DeletePunctuation = deletePunctuationCheckBox.Checked;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("необходимо ввести число");
            }
        }
    }
}
