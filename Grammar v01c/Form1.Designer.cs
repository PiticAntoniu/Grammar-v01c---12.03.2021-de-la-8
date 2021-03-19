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
            this.editButton = new System.Windows.Forms.Button();
            this.noLambdaProductionsButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.grammarSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(510, 81);
            this.parseButton.Margin = new System.Windows.Forms.Padding(6);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(150, 44);
            this.parseButton.TabIndex = 0;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(86, 81);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(378, 31);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "SaA$Sb$Aaa&";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(553, 477);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 54);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(741, 477);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(134, 54);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // grammarInfoWebBrowser
            // 
            this.grammarInfoWebBrowser.Location = new System.Drawing.Point(86, 137);
            this.grammarInfoWebBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.grammarInfoWebBrowser.MinimumSize = new System.Drawing.Size(40, 38);
            this.grammarInfoWebBrowser.Name = "grammarInfoWebBrowser";
            this.grammarInfoWebBrowser.Size = new System.Drawing.Size(734, 329);
            this.grammarInfoWebBrowser.TabIndex = 5;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(31, 482);
            this.editButton.Margin = new System.Windows.Forms.Padding(6);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 44);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // noLambdaProductionsButton
            // 
            this.noLambdaProductionsButton.Location = new System.Drawing.Point(221, 482);
            this.noLambdaProductionsButton.Name = "noLambdaProductionsButton";
            this.noLambdaProductionsButton.Size = new System.Drawing.Size(153, 50);
            this.noLambdaProductionsButton.TabIndex = 7;
            this.noLambdaProductionsButton.Text = "no @ prod";
            this.noLambdaProductionsButton.UseVisualStyleBackColor = true;
            this.noLambdaProductionsButton.Click += new System.EventHandler(this.noLambdaProductionsButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(389, 482);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(142, 44);
            this.saveAsButton.TabIndex = 8;
            this.saveAsButton.Text = "Save as...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // grammarSaveFileDialog
            // 
            this.grammarSaveFileDialog.DefaultExt = "json";
            this.grammarSaveFileDialog.Filter = "\"Data Files (*.json)|*.json\"";
            // 
            // grammarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 550);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.noLambdaProductionsButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.grammarInfoWebBrowser);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.parseButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "grammarInfoForm";
            this.Text = "Grammar Info";
            this.Load += new System.EventHandler(this.grammarInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.WebBrowser grammarInfoWebBrowser;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button noLambdaProductionsButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog grammarSaveFileDialog;
    }
}

