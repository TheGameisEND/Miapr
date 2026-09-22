namespace LabN7
{
    public static class CurrentGrammar
    {
        public static void Initialize(FullGrammar grammar, float x = 1)
        {
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Below|Rule.EqualX,19f * x,0, 100f * x),
                new FullRule(Rule.ToRight|Rule.EqualY,19f * x,100f * x, 0),
                new FullRule(Rule.Below|Rule.EqualX,19f * x,0, 100f * x)
            ));
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToRight|Rule.EqualY,19f * x,100f * x, 0),
                new FullRule(Rule.Below|Rule.EqualX,19f * x,0, 100f * x),
                new FullRule(Rule.ToRight|Rule.EqualY,19f * x,100f * x, 0)
            ));
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Equal,19f * x,0, 0),
                new FullRule(Rule.ToRight|Rule.Above,19f * x,100f * x, 100f * x),
                new FullRule(Rule.Below|Rule.EqualX,19f * x,0, 100f * x)
            ));
            
            //3
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToLeft|Rule.Above,30f * x,50f * x, 60f * x),
                new FullRule(Rule.Above|Rule.EqualX,19f * x,0, 100f * x),
                new FullRule(Rule.Below|Rule.EqualX,19f * x,0, 100f * x)
            ));
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToLeft|Rule.EqualY,19f * x,100f * x, 0),
                new FullRule(Rule.Equal,19f * x,0, 0),
                new FullRule(Rule.ToLeft|Rule.Above,30f * x,50f * x, 60f * x)
            ));
            
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToRight|Rule.Above,19f * x,40f * x, 20f * x),
                new FullRule(Rule.Below|Rule.ToLeft,19f * x,10f * x, 20f * x),
                new FullRule(Rule.ToRight|Rule.Above,30f * x,50f * x, 60f * x)
            ));
            
            
            //6
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Below|Rule.EqualX,10f * x,0, 20f * x),
                new FullRule(Rule.ToRight|Rule.EqualY,10f * x,20f * x, 0),
                new FullRule(Rule.Below|Rule.EqualX,10f * x,0, 20f * x)
            ));
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToRight|Rule.EqualY,10f * x,20f * x, 0),
                new FullRule(Rule.Below|Rule.EqualX,10f * x,0, 20f * x),
                new FullRule(Rule.ToRight|Rule.EqualY,10f * x,20f * x, 0)
            ));
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Equal,10f * x,0, 0),
                new FullRule(Rule.ToRight|Rule.Above,10f * x,20f * x, 20f * x),
                new FullRule(Rule.Below|Rule.EqualX,10f * x,0, 20f * x)
            ));
            
            
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.ToRight|Rule.EqualY,17f * x,30f * x, 0),
                new FullRule(Rule.ToLeft|Rule.Above,17f * x,70f * x, 60f * x),
                new FullRule(Rule.ToRight|Rule.EqualY,17f * x,100f * x, 0)
            ));
            
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Equal,17f * x,0, 0),
                new FullRule(Rule.ToRight|Rule.Above,17f * x,40f * x, 60f * x),
                new FullRule(Rule.Below|Rule.EqualX,17f * x, 0, 60f * x)
            ));
            
            grammar.Rules.Add(new FullLineRule(
                new FullRule(Rule.Equal,17f * x,0, 0),
                new FullRule(Rule.ToRight|Rule.Below,17f * x,40f * x, 60f * x),
                new FullRule(Rule.ToLeft|Rule.EqualY,17f * x,40f * x, 0)
            ));
            
            
            //Main square
            grammar.Grammar.Add(new GrammarElement(1,2,2));
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, /*GrammarElement.Term*/ 9, 0));
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 3, 1));
            //Top triangle
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 4, 3)); 
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 5, 4));
            //Top square
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 6, 5));
            
            grammar.Grammar.Add(new GrammarElement(7, 8, 8));
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, GrammarElement.Term, 6)); 
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, GrammarElement.Term, 7));
            //Mid square (door)
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 10, 9)); 
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, 11, 10));
            grammar.Grammar.Add(new GrammarElement(GrammarElement.Term, GrammarElement.Term, 11)); 

        }
    }
}