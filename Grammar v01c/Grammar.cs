using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Grammar_v01c
{
    public class Grammar
    {
        private string originalInput;

        #region date membre
        char startSymbol;
        List<char> nonterminals = new List<char>();
        List<char> terminals = new List<char>();
        List<Production> productionList = new List<Production>();
    

        public string OriginalInput { get => originalInput; set => originalInput = value; }



        public List<char> Nonterminals { get => nonterminals; set => nonterminals = value; }
        public List<char> Terminals { get => terminals; set => terminals = value; }

        public List<Production> ProductionList { get => productionList; set => productionList = value; }
        public char StartSymbol { get => startSymbol; set => startSymbol = value; }


        #endregion

        #region constructors
        public Grammar()
        {

        }



        public Grammar(string originalInput)
        {
            OriginalInput = originalInput;

            StartSymbol = OriginalInput[0];

            nonterminals = Helper.UpperLetters(OriginalInput);
            terminals = Helper.LowerLetters(OriginalInput);

            SetProductions();
        }

        #endregion

        internal void Parse(string originalInput)
        {
            OriginalInput = originalInput;

            StartSymbol = OriginalInput[0];

            nonterminals = Helper.UpperLetters(OriginalInput);
            terminals = Helper.LowerLetters(OriginalInput);

            SetProductions();
        }
        internal string GrammarInfoAsText()
        {

            return $@"Let G be a grammar with nonterminal symbols N = {Helper.FormatAsSet(Nonterminals)},<br>
        set of terminal symbols T = {Helper.FormatAsSet(Terminals)}<br>.
        start symbol {StartSymbol} <br>
        set of production rules P = {FormatAsSet(ProductionList)}<br>";
        }

 
        internal bool IsValidNonterminal(char symbol)
        {
            return char.IsUpper(symbol);
        }
        internal bool IsValidTerminal(char symbol)
        {
            return char.IsLower(symbol) || Properties.Resources.TerminalChars.Contains(symbol);
        }
        internal bool IsValidStartSymbol(char symbol)
        {
            return nonterminals.Contains(symbol) ;
        }

        internal bool IsValidProduction(Production p)
        {
            if (!GrammarProvider.GetGrammar().nonterminals.Contains(p.Left))
            {
                return false;
            }

            foreach (var c in p.Right)
            {
                if (!GrammarProvider.GetGrammar().nonterminals.Contains(c) &&
                    !GrammarProvider.GetGrammar().terminals.Contains(c)){
                    return false;
                }
            }

            return true;        
        }

        public string GetProductionAsHTML(Production p)
        {
            StringBuilder t = new StringBuilder();

            t.Append(Helper.ColoredChar(p.Left,Color.FromName(Properties.Resources.NonterminalsColor)));
            t.Append(Helper.ColoredString(" → ", Properties.Resources.DefaultColor));
            t.Append(FormatAsHtml(p.Right));

            return t.ToString();
        }

        private string FormatAsHtml(string word)
        {
            StringBuilder p = new StringBuilder();

            foreach (var c in word)
            {
                if (IsTerminal(c))
                {
                    p.Append(Helper.ColoredChar(c, Color.FromName(Properties.Resources.TerminalsColor)));
                }
                else
                {
                    p.Append(Helper.ColoredChar(c, Color.FromName(Properties.Resources.NonterminalsColor)));
                }
            }

            return p.ToString();
        }

        private bool IsTerminal(char c)
        {
            return terminals.Contains(c);
        }

        internal string GrammarInfoAsHTML()
        {
            StringBuilder t = new StringBuilder();
            t.Append("Start symbol S=");
            t.Append(FormatAsHtml(StartSymbol.ToString()));
            t.Append(Helper.ColoredString("<br>nonterminals  N=",Properties.Resources.DefaultColor));
            t.Append(Helper.FormatAsSet(nonterminals, Color.FromName( Properties.Resources.NonterminalsColor)));
            t.Append("<br>terminals  T=");
            t.Append(Helper.FormatAsSet(terminals, Color.FromName(Properties.Resources.TerminalsColor)));

            foreach (var p in productionList)
            {
                t.Append("<br>");
                t.Append(GetProductionAsHTML(p));
            }

            return t.ToString();
        }
        private string FormatAsSet(List<Production> productionList)
        {
            // {S->Aa , A->ab }

            string result = "{"; // nu uitati ca ar trebui StringBuilder in loc de string
            foreach (Production production in ProductionList)
            {
                result += production.Left + "->" + production.Right + " , ";
            }

            result = result.Remove(result.Length - 3, 3); // sterge " , " de la sfarsit
            result += "}";

            return result;
        }
        private void SetProductions()
        {
            // "SaA$Sb$Aaa&" => S->aA  S->b  A->aa
            // OriginalInput => ProductionList

            ProductionList.Clear();

            foreach (var production in OriginalInput.Split('$', '&'))
            {
                if (production.Length > 0)
                {
                    ProductionList.Add(
                        new Production
                        {
                            Left = production[0],
                            Right = production.Remove(0, 1)
                        }
                    );
                }
            }
        }
        internal void SaveToJson(string fileName)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(fileName, json);
        }
        internal void LoadFromFile(string fileName) // de gasit solutie mai eleganta :)
        {
            string json = File.ReadAllText(fileName);
            Grammar tempGrammar = new Grammar();
            tempGrammar = JsonConvert.DeserializeObject<Grammar>(json);

            startSymbol = tempGrammar.startSymbol;
            nonterminals = tempGrammar.nonterminals;
            terminals = tempGrammar.terminals;
            productionList = tempGrammar.productionList;
        }
    }
}