namespace Grammar_v01c
{
    partial class grammarInfoForm
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
            this.parseButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.grammarInfoWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(255, 42);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 0;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(43, 42);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(191, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "SaA$Sb$Aaa&";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(43, 247);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(137, 247);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(67, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // grammarInfoWebBrowser
            // 
            this.grammarInfoWebBrowser.Location = new System.Drawing.Point(43, 71);
            this.grammarInfoWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.grammarInfoWebBrowser.Name = "grammarInfoWebBrowser";
            this.grammarInfoWebBrowser.Size = new System.Drawing.Size(367, 171);
            this.grammarInfoWebBrowser.TabIndex = 5;
            // 
            // grammarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 286);
            this.Controls.Add(this.grammarInfoWebBrowser);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.parseButton);
            this.Name = "grammarInfoForm";
            this.Text = "Grammar Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.WebBrowser grammarInfoWebBrowser;
    }
}

