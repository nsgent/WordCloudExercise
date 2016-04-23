namespace Gent_WordCloudExercies
{
    partial class WordCloudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(385, 33);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(35, 28);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(426, 33);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 28);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Results";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 34);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(367, 22);
            this.filePathTextBox.TabIndex = 2;
            this.filePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "WordCloudExample.txt";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog.ShowReadOnly = true;
            this.openFileDialog.Title = "Select file to analyze";
            // 
            // WordCloudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.openButton);
            this.Name = "WordCloudForm";
            this.Text = "Word Cloud Analyzer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

