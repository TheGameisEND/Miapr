using System;
using System.Collections.Generic;
using System.Drawing;

namespace LabN7
{
    public class Result
    {
        public int Value { get; set; }
        public bool[] Used { get; set; }    

        public Result(int value, bool[] used)
        {
            Value = value;
            Used = used;
        }
    }
    
    public static class Analyzer
    {
        private const float XShift = 150;
        private const float YShift = 150;
        //A, B - grammar
        //rule = FullRule x 3
        //used = used lines from data
        //grammar entire grammar (all Grammars and Rules)
        public static List<Result> Check(int a, int b, int rule, bool[] used, List<Line> data, FullGrammar grammar)
        {
            if ((a & GrammarElement.Term) != 0 && (b & GrammarElement.Term) != 0)
            {
                List<Result> res = new List<Result>();
                for (int i = 0; i < used.Length; i++)
                {
                    for (int j = 0; j < used.Length; j++)
                    {
                        if (i == j || used[i] || used[j])
                        {
                            continue;
                        }

                        if (Rule.CheckRuleLines(data[i], data[j], 
                                grammar.Rules[rule].A, grammar.Rules[rule].B, grammar.Rules[rule].Base))
                        {
                            bool[] temp = (bool[]) used.Clone();
                            temp[i] = true;
                            temp[j] = true;
                            res.Add(new Result(i, temp));
                        }
                        
                    }
                }

                return res;
            }

            if ((a & GrammarElement.Term) == 0 && (b & GrammarElement.Term) != 0)
            {
                List<Result> res = new List<Result>();
                List<Result> possibleStates = Check(grammar.Grammar[a].A, grammar.Grammar[a].B,
                    grammar.Grammar[a].Rule, used, data, grammar);
                foreach (var tempRes in possibleStates)
                {
                    used = tempRes.Used;
                    int i = tempRes.Value;
                    
                    for (int j = 0; j < used.Length; j++)
                    {
                        if (i == j  || used[j])
                        {
                            continue;
                        }

                        if (Rule.CheckRuleLines(data[i], data[j], 
                                grammar.Rules[rule].A, grammar.Rules[rule].B, grammar.Rules[rule].Base))
                        {
                            bool[] temp = (bool[]) used.Clone();
                            temp[i] = true;
                            temp[j] = true;
                            res.Add(new Result(i, temp));
                        }
                        
                    }
                }
                return res;
            } 
            
            if ((a & GrammarElement.Term) != 0 && (b & GrammarElement.Term) == 0)
            {
                List<Result> res = new List<Result>();
                List<Result> possibleStates = Check(grammar.Grammar[b].A, grammar.Grammar[b].B,
                    grammar.Grammar[b].Rule, used, data, grammar);
                foreach (var tempRes in possibleStates)
                {
                    used = tempRes.Used;
                    int j = tempRes.Value;
                    
                    for (int i = 0; i < used.Length; i++)
                    {
                        if (i == j || used[i])
                        {
                            continue;
                        }

                        if (Rule.CheckRuleLines(data[i], data[j], 
                                grammar.Rules[rule].A, grammar.Rules[rule].B, grammar.Rules[rule].Base))
                        {
                            bool[] temp = (bool[]) used.Clone();
                            temp[i] = true;
                            temp[j] = true;
                            res.Add(new Result(i, temp));
                        }
                        
                    }
                }
                return res;
            }
            else
            {  
                List<Result> res = new List<Result>();
                List<Result> possibleStatesA = Check(grammar.Grammar[a].A, grammar.Grammar[a].B,
                    grammar.Grammar[a].Rule, used, data, grammar);
                List<Result> possibleStatesB = Check(grammar.Grammar[b].A, grammar.Grammar[b].B,
                    grammar.Grammar[b].Rule, used, data, grammar);

                foreach (var tempResA in possibleStatesA)
                {
                    foreach (var tempResB in possibleStatesB)
                    {
                        bool[] usedA = tempResA.Used;
                        bool[] usedB = tempResB.Used;
                        if (!MergeArrays(ref usedA, usedB, used))
                        {
                            continue;
                        }

                        int i = tempResA.Value;
                        int j = tempResB.Value;
                        
                        if (i == j)
                        {
                            continue;
                        }

                        if (Rule.CheckRuleLines(data[i], data[j], 
                                grammar.Rules[rule].A, grammar.Rules[rule].B, grammar.Rules[rule].Base))
                        {
                            bool[] temp = (bool[]) usedA.Clone();
                            temp[i] = true;
                            temp[j] = true;
                            res.Add(new Result(i, temp));
                        }
                    }
                }
                
                return res;
            }
        }

        private static bool MergeArrays(ref bool[] arr1, bool[] arr2, bool[] prev)
        {
            for (int i = 0; i < prev.Length; i++)
            {
                if (arr1[i] && arr2[i] && !prev[i])
                {
                    return false;
                }
                arr1[i] = arr1[i] ^ arr2[i] || prev[i];
            }
            return true;
        }

        public static void Generate(Line val, int a, int b, int rule, FullGrammar grammar, List<Line> res)
        {
            if (val == null)
            {
                Random rand = new Random();
                float x = XShift + rand.Next(30) + (float)rand.NextDouble();
                float y = YShift + rand.Next(30) + (float)rand.NextDouble();
                PointF point = new PointF(x,y);
                val = new Line(point , Rule.CreateLine(point, grammar.Rules[rule].Base));
            }

            var pair = Rule.GetPairLine(val, grammar.Rules[rule]);
            
            if ((a & GrammarElement.Term) == 0)
            {
                Generate(val, grammar.Grammar[a].A, grammar.Grammar[a].B, grammar.Grammar[a].Rule, grammar, res);
            }
            else
            {
                res.Add(val);
            }
            
            if ((b & GrammarElement.Term) == 0)
            {
                Generate(pair, grammar.Grammar[b].A, grammar.Grammar[b].B, grammar.Grammar[b].Rule, grammar, res);
            }
            else
            {
                res.Add(pair);
            }
        }
    }
}