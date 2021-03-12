using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grammar_v01c
{
    public partial class grammarInfoForm : Form
    {
        Grammar g = new Grammar();
        public grammarInfoForm()
        {
            InitializeComponent();
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            g = new Grammar(inputTextBox.Text);

            grammarInfoWebBrowser.DocumentText = g.GrammarInfoAsText();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            g.SaveToJson(Properties.Resources.DefaultGrammarLocation);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            g.LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            grammarInfoWebBrowser.DocumentText = g.GrammarInfoAsHTML();
        }
    }
}
