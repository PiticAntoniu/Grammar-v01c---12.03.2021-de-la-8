using System;

namespace Grammar_v01c
{
    internal class GrammarProvider
    {
        static Grammar g = null;
        internal static Grammar GetGrammar()
        {
            if (g == null)
            {
                g = new Grammar(); 
            }
            return g;
        }
    }
}