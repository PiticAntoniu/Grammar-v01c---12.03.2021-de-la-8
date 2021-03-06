using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar_v01c
{
    class GrammarAlgorithms
    {
        internal static Grammar EliminateLambdaProductions(Grammar originalGrammar)
        {
            Grammar lambdaFreeGrammar = new Grammar();
            List<char> Ne = new List<char>();
            Ne = ListaDeNeterminaleCareDucInLambda(originalGrammar);

            lambdaFreeGrammar = InitializareNoiiGramaticiInFunctieDeSimbolulDeStart(originalGrammar, Ne);

            foreach (var p in originalGrammar.ProductionList)
            {
                lambdaFreeGrammar.ProductionList.AddRange(ExpandProduction(p, Ne));
            }

            ClearUpProductions(lambdaFreeGrammar);

            return lambdaFreeGrammar;
        }

        private static void ClearUpProductions(Grammar lambdaFreeGrammar)
        {
            lambdaFreeGrammar.ProductionList.RemoveAll(p => (
                                    (p.Right.Equals(Properties.Resources.Lambda) &&
                                    (p.Left != lambdaFreeGrammar.StartSymbol))));

            Grammar g = new Grammar();

            List<Production> prod = new List<Production>();

            foreach (var p in lambdaFreeGrammar.ProductionList)
            {
                if (!Exists(prod,p))
                {
                    prod.Add(p);
                }
            }

            lambdaFreeGrammar.ProductionList = prod;
        }

        private static bool Exists(List<Production> productionList, Production production)
        {
            foreach (var p in productionList)
            {
                if (p.Left == production.Left && p.Right.Equals(production.Right))
                {
                    return true;
                }
            }
            return false;
        }

        private static List<Production> ExpandProduction(Production p, List<char> Ne)
        {
            List<Production> result = new List<Production>();

            Expand(p, Ne, 0, result, p.Right);

            return result;
        }

        static void Expand(Production p, List<char> Ne, int index, List<Production> result, string s)
        {
            if (index >= s.Length)
            {
                Console.WriteLine(p.Left + "->" + s);
                p.Right = s;
                if (s.Length > 0) result.Add(new Production { Left = p.Left,Right = s});
                return;
            }

            Expand(p, Ne, index + 1, result, s);
            if (Ne.Contains(s[index]))
            {
                string t = s.Remove(index, 1);
                Expand(p, Ne, index, result, t);
            }


        }

        private static Grammar InitializareNoiiGramaticiInFunctieDeSimbolulDeStart(Grammar originalGrammar, List<char> Ne)
        {
            Grammar lambdaFreeGrammar = new Grammar();
            lambdaFreeGrammar.Terminals.AddRange(originalGrammar.Terminals);
            if (Ne.Contains(originalGrammar.StartSymbol))
            {
                char newStartSymbol = Properties.Resources.NewStartSymbol[0];
                char lambda = Properties.Resources.Lambda[0];

                lambdaFreeGrammar.Nonterminals.AddRange(originalGrammar.Nonterminals);
                lambdaFreeGrammar.Nonterminals.Add(newStartSymbol);
                lambdaFreeGrammar.StartSymbol = newStartSymbol;

                lambdaFreeGrammar.ProductionList.Add(
                    new Production { Left = newStartSymbol, Right = lambda.ToString() });
                lambdaFreeGrammar.ProductionList.Add(
                                    new Production { Left = newStartSymbol, Right = originalGrammar.StartSymbol.ToString() });

            }
            else
            {
                lambdaFreeGrammar.Nonterminals.AddRange(originalGrammar.Nonterminals);
                lambdaFreeGrammar.StartSymbol = originalGrammar.StartSymbol;
                lambdaFreeGrammar.ProductionList.Clear();
            }

            return lambdaFreeGrammar;
        }

        private static List<char> ListaDeNeterminaleCareDucInLambda(Grammar g)
        {
            int i = 0;

            List<char>[] N = new List<char>[100];
            N[i] = new List<char>(g.ProductionList.Where(x => x.Right.Equals("@"))
                            .Select(x => x.Left).ToList());

            //foreach (var p in g.ProductionList)
            //{
            //    if (p.Right.Equals("@"))
            //    {
            //        N[i].Add(p.Left);
            //    }
            //}


            do
            {
                i++;
                N[i] = new List<char>(N[i - 1]);
                //foreach (var p in GrammarProvider.GetGrammar().ProductionList)
                //{
                //    if (Helper.StringHasOnlyCharsFromCharList(p.Right, N[i - 1]))
                //    {
                //        N[i].Add(p.Left);
                //    }
                //}
                //N[i] = N[i].Distinct().ToList();

                N[i].AddRange(GrammarProvider.GetGrammar().ProductionList
                                .Where(x => Helper.StringHasOnlyCharsFromCharList(x.Right, N[i - 1]))
                                .Select(x => x.Left));
                N[i] = N[i].Distinct().ToList();
            }
            while (!N[i].SequenceEqual(N[i - 1]));

            return N[i];
        }

    }
}
