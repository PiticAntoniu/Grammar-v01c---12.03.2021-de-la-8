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
        public EditGrammarForm()
        {
            InitializeComponent();
            startSymbolTextBox.Text = GrammarProvider.GetGrammar().StartSymbol.ToString();
            terminalsTextBox.Text = Helper.CharListToString(GrammarProvider.GetGrammar().Terminals);
            nonterminalsTextBox.Text = Helper.CharListToString(GrammarProvider.GetGrammar().Nonterminals);
            productionsDataGridView.DataSource = GrammarProvider.GetGrammar().ProductionList;
            productionsDataGridView.AutoResizeColumns();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().StartSymbol = startSymbolTextBox.Text[0];
            GrammarProvider.GetGrammar().Nonterminals = Helper.StringToCharList(nonterminalsTextBox.Text);
            GrammarProvider.GetGrammar().Terminals = Helper.StringToCharList(terminalsTextBox.Text);
            Close();
        }

        private void AddNewProductionButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().ProductionList.Add(new Production { Left = 'S', Right = "@" });
            productionsDataGridView.DataSource = null;
            productionsDataGridView.DataSource = GrammarProvider.GetGrammar().ProductionList;
        }

        private void deleteProductionButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().ProductionList.RemoveAt(productionsDataGridView.SelectedRows[0].Index);
            productionsDataGridView.DataSource = null;
            productionsDataGridView.DataSource = GrammarProvider.GetGrammar().ProductionList;
        }



        private void productionsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Production p = new Production();
            p.Left = productionsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()[0];
            p.Right = productionsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (!GrammarProvider.GetGrammar().IsValidProduction(p))
            {
                MessageBox.Show("!");
            }

        }

        private void startSymbolTextBox_Leave(object sender, EventArgs e)
        {
            char startSymbol = startSymbolTextBox.Text[0];
            if (startSymbolTextBox.Text.Length > 1)
            {
                MessageBox.Show("!");
            }
            if (GrammarProvider.GetGrammar().IsValidStartSymbol(startSymbol))
            {
                GrammarProvider.GetGrammar().StartSymbol = startSymbol;
            }
            else
            {
                MessageBox.Show("!");
            }
        }

        private void terminalsTextBox_Leave(object sender, EventArgs e)
        {
            string newTerminals = terminalsTextBox.Text;

            GrammarProvider.GetGrammar().Terminals.Clear();

            foreach (var terminal in newTerminals)
            {
                if (GrammarProvider.GetGrammar().IsValidTerminal(terminal))
                {
                    GrammarProvider.GetGrammar().Terminals.Add(terminal);
                }
                else
                {
                    MessageBox.Show("!");
                }
            }
        }

        private void terminalsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nonterminalsTextBox_Leave(object sender, EventArgs e)
        {
            string newNonterminals = nonterminalsTextBox.Text;

            GrammarProvider.GetGrammar().Terminals.Clear();

            foreach (var nonterminal in newNonterminals)
            {
                if (GrammarProvider.GetGrammar().IsValidNonterminal(nonterminal))
                {
                    GrammarProvider.GetGrammar().Nonterminals.Add(nonterminal);
                }
                else
                {
                    MessageBox.Show("!");
                }
            }
        }

        private void terminalsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GrammarProvider.GetGrammar().IsValidTerminal(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
