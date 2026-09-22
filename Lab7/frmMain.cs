using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabN7
{
    public partial class frmMain : Form
    {
        private List<Line> _lines = new List<Line>();
        private PointF _lastPoint = new PointF();
        private bool _inDrawing = false;
        private const int LinesForImage = 13;
        public frmMain()
        {
            InitializeComponent();
            
            //Test stuff
            
            // FullGrammar grammar = new FullGrammar();
            // CurrentGrammar.Initialize(grammar);
            // List<Line> data = new List<Line>();
            //
            // 
            _lines.Add(new Line(new PointF( 100,100), new PointF(100, 200)));
            _lines.Add(new Line(new PointF( 100,100), new PointF(200, 100)));
            _lines.Add(new Line(new PointF( 200,100), new PointF(200, 200)));
            _lines.Add(new Line(new PointF( 100,200), new PointF(200, 200)));
            
            _lines.Add(new Line(new PointF( 200,100), new PointF(150, 40)));
            _lines.Add(new Line(new PointF( 100,100), new PointF(150, 40)));
            
            _lines.Add(new Line(new PointF( 140,80), new PointF(140, 60)));
            _lines.Add(new Line(new PointF( 140,80), new PointF(160, 80)));
            _lines.Add(new Line(new PointF( 160,60), new PointF(160, 80)));
            _lines.Add(new Line(new PointF( 160,60), new PointF(140, 60)));
            
            _lines.Add(new Line(new PointF( 130,200), new PointF(130, 140)));
            _lines.Add(new Line(new PointF( 130,140), new PointF(170, 140)));
            _lines.Add(new Line(new PointF( 170,140), new PointF(170, 200)));
            
            
            //
            //
            // bool[] temp = new bool[data.Count];
            // Analyzer.Check(grammar.Grammar[0].A, grammar.Grammar[0].B, grammar.Grammar[0].Rule, temp, data, grammar);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FullGrammar grammar = new FullGrammar();
            CurrentGrammar.Initialize(grammar, 2);
            _lines.Clear();
            Analyzer.Generate(null,grammar.Grammar[0].A, grammar.Grammar[0].B, grammar.Grammar[0].Rule, grammar, _lines);
            Draw();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            bool[] temp = new bool[_lines.Count];
            FullGrammar grammar = new FullGrammar();
            CurrentGrammar.Initialize(grammar, 2);
            if (_lines.Count != LinesForImage)
            {
                MessageBox.Show("Incorrect amount of lines. Can't gather an image from them");
                return;
            }
            if ((Analyzer.Check(grammar.Grammar[0].A, grammar.Grammar[0].B, grammar.Grammar[0].Rule, temp, _lines,
                    grammar)).Count != 0)
            {
                MessageBox.Show("The image corresponds to grammar");
            }
            else
            {
                MessageBox.Show("The Image does NOT correspond to grammar");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _lines.Clear();
            Draw();
        }

        private void Draw()
        {
            Graphics e = pnlDrawField.CreateGraphics();
            Bitmap backBuffer = new Bitmap((int) e.VisibleClipBounds.Width, (int)e.VisibleClipBounds.Height);
            Graphics graphicsBuffer = Graphics.FromImage(backBuffer);
            graphicsBuffer.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            foreach (var line in _lines)
            {
                
                graphicsBuffer.DrawLine(pen, line.Begin, line.End);
            }
            e.DrawImage(backBuffer, 0, 0);
            graphicsBuffer.Dispose();
            backBuffer.Dispose();
        }

        private void pnlDrawField_MouseClick(object sender, MouseEventArgs e)
        {
            if (_inDrawing)
            {
                _lines.Add(new Line(_lastPoint, new PointF(e.X, e.Y)));
                _inDrawing = false;
                Draw();
            }
            else
            {
                _lastPoint = new PointF(e.X, e.Y);              
                _inDrawing = true;
            }
        }
    }
}