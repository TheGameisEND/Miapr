using System.Collections.Generic;

namespace LabN7
{
    public class FullLineRule
    {
        public FullRule A { get; set; }
        public FullRule B { get; set; }
        public FullRule Base { get; set; }

        public FullLineRule(FullRule a, FullRule b, FullRule bas)
        {
            A = a;
            B = b;
            Base = bas;
        }
    }
    
    public class FullGrammar
    {
        public FullGrammar()
        {
            Grammar = new List<GrammarElement>();
            Rules = new List<FullLineRule>();
        }
        public List<GrammarElement> Grammar { get; set; }
        public List<FullLineRule> Rules { get; set; }
    }
}