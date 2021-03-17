namespace Grammar_v01c
{
    partial class EditGrammarForm
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
            this.startSymbolTextBox = new System.Windows.Forms.TextBox();
            this.terminalsTextBox = new System.Windows.Forms.TextBox();
            this.nonterminalsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.productionsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startSymbolTextBox
            // 
            this.startSymbolTextBox.Location = new System.Drawing.Point(188, 29);
            this.startSymbolTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startSymbolTextBox.Name = "startSymbolTextBox";
            this.startSymbolTextBox.Size = new System.Drawing.Size(196, 31);
            this.startSymbolTextBox.TabIndex = 0;
            // 
            // terminalsTextBox
            // 
            this.terminalsTextBox.Location = new System.Drawing.Point(188, 79);
            this.terminalsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.terminalsTextBox.Name = "terminalsTextBox";
            this.terminalsTextBox.Size = new System.Drawing.Size(196, 31);
            this.terminalsTextBox.TabIndex = 1;
            // 
            // nonterminalsTextBox
            // 
            this.nonterminalsTextBox.Location = new System.Drawing.Point(188, 140);
            this.nonterminalsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nonterminalsTextBox.Name = "nonterminalsTextBox";
            this.nonterminalsTextBox.Size = new System.Drawing.Size(196, 31);
            this.nonterminalsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simbol de start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Terminale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Neterminale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Productii";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(85, 506);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(150, 44);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(269, 506);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // productionsDataGridView
            // 
            this.productionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionsDataGridView.ColumnHeadersVisible = false;
            this.productionsDataGridView.Location = new System.Drawing.Point(29, 225);
            this.productionsDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productionsDataGridView.Name = "productionsDataGridView";
            this.productionsDataGridView.RowHeadersVisible = false;
            this.productionsDataGridView.RowHeadersWidth = 82;
            this.productionsDataGridView.Size = new System.Drawing.Size(440, 269);
            this.productionsDataGridView.TabIndex = 10;
            // 
            // EditGrammarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 565);
            this.Controls.Add(this.productionsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nonterminalsTextBox);
            this.Controls.Add(this.terminalsTextBox);
            this.Controls.Add(this.startSymbolTextBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditGrammarForm";
            this.Text = "EditGrammarForm";
            ((System.ComponentModel.ISupportInitialize)(this.productionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startSymbolTextBox;
        private System.Windows.Forms.TextBox terminalsTextBox;
        private System.Windows.Forms.TextBox nonterminalsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView productionsDataGridView;
    }
}