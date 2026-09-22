using System.Drawing;

namespace LabN7
{
    public class Line
    {
        public PointF Begin { get; set; }
        public PointF End { get; set; }

        public Line(PointF begin, PointF end)
        {
            Begin = begin;
            End = end;
        }
    }

    public class GrammarElement
    {
        public const int Term = 0b1000000000000000000000000000000; // 31 bit
        public int Rule { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        public GrammarElement(int a, int b, int rule)
        {
            A = a;
            B = b;
            Rule = rule;
        }
        
    }
}