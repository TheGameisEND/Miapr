using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabN7
{
    //Characterise position of the point 2 if point 1 was an origin.
    //ValueX - amount of pixels shifted into Ruled direction for OX
    //ValueY - amount of pixels shifted into Ruled direction for OY
    //Delta  - amount of pixels allowed to 'miss'
    
    //Any value = -1 means that pixels shift doesn't matter and delta will allow rule to be reversed by Delta pixels
    //(e.g. being on Delta pixel Below if rule is Above)
    public class FullRule   
    {
        public const float DefaultDelta = 10f;
        public const float AnyValue = -1;
        public int Rule { get; set; }
        public float Delta { get; set; }
        public float ValueX { get; set; }
        public float ValueY { get; set; } 
        public FullRule(int rule, float delta = DefaultDelta, float valueX = AnyValue, float valueY = AnyValue)
        {
            Rule = rule;
            Delta = delta;
            ValueX = valueX;
            ValueY = valueY;
        }
    }
 
    public static class Rule
    {
        public const int AccuracyModifier = 3 * 3 + 1;
        public const int RandInfCap = 50;
        
        public const int Equal   = 0b110000;
        public const int EqualX  = 0b100000;
        public const int EqualY  = 0b010000;
        public const int Above   = 0b001000;
        public const int Below   = 0b000100;
        public const int ToLeft  = 0b000010;
        public const int ToRight = 0b000001;
        public const int Any     = 0b000000;

        private static int AdjustRule(int rule)
        {

            if ((rule & EqualX) != 0)
            {
                rule &= ~ToLeft;
                rule &= ~ToRight;
            }

            if ((rule & EqualY) != 0)
            {
                rule &= ~Below;
                rule &= ~Above;
            }
            
            if ((rule & Above) != 0 && (rule & Below) != 0)
            {
                rule &= ~Below;
            }

            
            if ((rule & ToLeft) != 0 && (rule & ToRight) != 0)
            {
                rule &= ~ToRight;
            }
            return rule;
        }


        private static bool CheckRulePoints(PointF a, PointF b, FullRule rule)
        {
            bool result = true;
            int option = AdjustRule(rule.Rule);
            float valueX = rule.ValueX;
            float valueY = rule.ValueY;
            float eps = rule.Delta;
          
            if ((option & EqualX) != 0)
            {
                if (Math.Abs(a.X - b.X) > eps)
                {
                    result = false;
                } 
            }

            if ((option & EqualY) != 0)
            {
                if (Math.Abs(a.Y - b.Y) > eps)
                {
                    result = false;
                }
            }

            if ((option & Above) != 0)
            {
                if (Math.Abs(valueY - FullRule.AnyValue) > 0.000001)
                {
                    if (Math.Abs(a.Y - b.Y - valueY) > eps)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (b.Y - eps > a.Y)
                    {
                        result = false;
                    }
                }
            }
            
            if ((option & Below) != 0)
            {
                if (Math.Abs(valueY - FullRule.AnyValue) > 0.000001)
                {
                    if (Math.Abs(a.Y - b.Y + valueY) > eps)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (b.Y + eps < a.Y)
                    {
                        result = false;
                    }
                }
            }
            
            if ((option & ToLeft) != 0)
            {
                if (Math.Abs(valueX - FullRule.AnyValue) > 0.000001)
                {
                    if (Math.Abs(a.X - b.X - valueX) > eps)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (b.X - eps > a.X)
                    {
                        result = false;
                    }
                }

            }
            
            if ((option & ToRight) != 0)
            {
                if (Math.Abs(valueX - FullRule.AnyValue) > 0.000001)
                {
                    if (Math.Abs(a.X - b.X + valueX) > eps)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (b.X + eps < a.X)
                    {
                        result = false;
                    }
                }
            }
            
            return result;
        }

        public static bool CheckRuleLines(Line a, Line b, FullRule rule1, FullRule rule2, FullRule baseRule = null)
        {
            
            if (baseRule == null)   
            {
                baseRule = new FullRule(Rule.Any);
            }

            bool result = false;
            
            if (CheckRulePoints(a.Begin, a.End, baseRule))
            {
                bool tempRes = false;
                tempRes |= CheckRulePoints(a.Begin, b.Begin, rule1) && CheckRulePoints(a.End, b.End, rule2);
                tempRes |= CheckRulePoints(a.Begin, b.End, rule1) && CheckRulePoints(a.End, b.Begin, rule2);
                result |= tempRes;
            }

            if (CheckRulePoints(a.End, a.Begin, baseRule))
            {
                bool tempRes = false;
                tempRes |= CheckRulePoints(a.End, b.Begin, rule1) && CheckRulePoints(a.Begin, b.End, rule2);
                tempRes |= CheckRulePoints(a.End, b.End, rule1) && CheckRulePoints(a.Begin, b.Begin, rule2);
                result |= tempRes;
            }

            return result;
        }

        public static PointF CreateLine(PointF point, FullRule rule)
        {
            int option = AdjustRule(rule.Rule);
            float valueX = rule.ValueX;
            float valueY = rule.ValueY;
            float eps = rule.Delta;

            float x = point.X;
            float y = point.Y;

            Random rand = new Random();
            if ((option & EqualX) != 0)
            {
                x += rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
            }

            if ((option & EqualY) != 0)
            {
                y += rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
            }

            if ((option & Above) != 0)
            {
                if (Math.Abs(valueY - FullRule.AnyValue) > 0.000001)
                {
                    y -= valueY + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;

                }
                else
                {
                    y -= rand.Next (RandInfCap) + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
                }
            }
            
            if ((option & Below) != 0)
            {
                if (Math.Abs(valueY - FullRule.AnyValue) > 0.000001)
                {
                    y += valueY + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;

                }
                else
                {
                    y += rand.Next (RandInfCap) + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
                }
            }
            
            if ((option & ToLeft) != 0)
            {
                if (Math.Abs(valueX - FullRule.AnyValue) > 0.000001)
                {
                    x -= valueX + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;

                }
                else
                {
                    x -= rand.Next (RandInfCap) + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
                }
            }
            
            if ((option & ToRight) != 0)
            {
                if (Math.Abs(valueX - FullRule.AnyValue) > 0.000001)
                {
                    x += valueX + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;

                }
                else
                {
                    x += rand.Next (RandInfCap) + rand.Next((int)eps / AccuracyModifier) + (float)rand.NextDouble() - eps / AccuracyModifier / 2;
                }
            }

            return  new PointF(x, y);
        }

        public static Line GetPairLine(Line a, FullLineRule rule)
        {

            FullRule rule1 = rule.A;
            FullRule rule2 = rule.B;
            FullRule baseRule = rule.Base;
            if (baseRule == null)   
            {
                baseRule = new FullRule(Rule.Any);
            }
            
            
            if (CheckRulePoints(a.Begin, a.End, baseRule))
            {
                return new Line(CreateLine(a.Begin, rule1), CreateLine(a.End, rule2));
            }

            if (CheckRulePoints(a.End, a.Begin, baseRule))
            {
                return new Line(CreateLine(a.End, rule1), CreateLine(a.Begin, rule2));
            }

            return null;
        }
    }
}