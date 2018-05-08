namespace MechForge
{
    partial class Form1
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
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(45, 31);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(1228, 20);
            this.FolderTextBox.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1295, 28);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileListBox
            // 
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(45, 90);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(306, 524);
            this.FileListBox.TabIndex = 2;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(376, 90);
            this.editorTextBox.Multiline = true;
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editorTextBox.Size = new System.Drawing.Size(994, 524);
            this.editorTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 673);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.FolderTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.TextBox editorTextBox;
    }
}

