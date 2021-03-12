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
    public partial class EditGrammarForm : Form
    {
        Grammar g = new Grammar();
        public EditGrammarForm(Grammar g)
        {
            this.g = g;
            InitializeComponent();
            startSymbolTextBox.Text = g.StartSymbol.ToString();
            terminalsTextBox.Text = Helper.CharListToString(g.Terminals);
            nonterminalsTextBox.Text = Helper.CharListToString(g.Nonterminals);
            productionsDataGridView.DataSource = g.ProductionList;
            productionsDataGridView.AutoResizeColumns();
        }

    }
}
