﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gent_WordCloudExercise.Properties;
using Gent_WordCloudExercise.Utilities;

namespace Gent_WordCloudExercise
{
    public partial class WordCloudForm : Form
    {
        internal string OutputFile { get; }
        internal string FilePathDirectory => Path.GetDirectoryName(filePathTextBox.Text);

        public WordCloudForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, @"..\..\..\..\WordCloudExamples");
            OutputFile = "results.txt";
        }

        internal void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        internal void loadButton_Click(object sender, EventArgs e)
        {
            messageLabel.Visible = true;
            if (!string.IsNullOrEmpty(filePathTextBox.Text) && filePathTextBox.Text.EndsWith(".txt"))
            {
                var wordDictionary = new Dictionary<string, int>();

                try
                {
                    using (var sr = new StreamReader(filePathTextBox.Text))
                    {
                        //put entire file on one line
                        string line = sr.ReadToEnd().Trim().ToLower().Replace("\r\n", " ");
                        //replace potential multiple space with a single space
                        line = Regex.Replace(line, @"\s+", " ");
                        string[] words = line.Split(' ');

                        foreach (string word in words)
                        {
                            string nonPunctuationWord = UtilityMethods.RemovePunctuation(word);

                            //checks word for empty string and against the words being filtered out
                            if (nonPunctuationWord.Equals("") ||
                                Utilities.Properties.FilterStrings.Contains(nonPunctuationWord))
                                continue;

                            //if the dictionary contains the word already, increment the count
                            //otherwise initialize the word starting with a count of 1
                            if (wordDictionary.ContainsKey(nonPunctuationWord))
                            {
                                wordDictionary[nonPunctuationWord]++;
                            }
                            else
                            {
                                wordDictionary[nonPunctuationWord] = 1;
                            }
                        }
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    messageLabel.Text = Resources.fileNotFound;
                    return;
                }
                catch (FileNotFoundException)
                {

                    messageLabel.Text = Resources.fileNotFound;
                    return;
                }

                using (var sr = new StreamWriter(OutputFile))
                {
                    foreach (KeyValuePair<string, int> wordCount in wordDictionary)
                    {
                        sr.WriteLine("{0}: {1}", wordCount.Key, wordCount.Value);
                    }
                }

                messageLabel.Text = string.Format(Resources.resultsSuccess, FilePathDirectory);
            }
            else
            {
                messageLabel.Text = Resources.emptyOrNonTextFile;
            }
        }

        internal void FormKeyPress(object sender, KeyPressEventArgs e)
        {
            //char '\u001b' corresponds to the Escape key
            if (e.KeyChar.Equals('\u001b'))
            {
                Close();
            }
        }
    }
}
