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

namespace Gent_WordCloudExercies
{
    public partial class WordCloudForm : Form
    {
        public WordCloudForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\WordCloudExamples"));
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string fileName = openFileDialog.FileName;
                filePathTextBox.Text = fileName;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void FormKeyPress(object sender, KeyPressEventArgs e)
        {
            //char '\u001b' corresponds to the Escape key
            if (e.KeyChar.Equals('\u001b'))
            {
                Close();
            }
        }
    }
}
