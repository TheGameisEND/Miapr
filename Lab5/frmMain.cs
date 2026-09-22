using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabN5
{
    
    public partial class frmMain : Form
    {
        private const int PlotCenterX = 300;
        private const int PlotCenterY = 200;
        private const int PlotScale = 15;
        private const int PlotObjectSize = 10;
        private const int PlotStartingX = 0;
        private const int PlotEndingX = 600;
        private Potential _potential = new Potential();
        private List<TestingObject> _objs = new List<TestingObject>();
        public frmMain()
        {
            InitializeComponent();
            _objs.Add(new TestingObject(-1,0,1));
            _objs.Add(new TestingObject(1,1,1));
            _objs.Add(new TestingObject(2,0,2));
            _objs.Add(new TestingObject(1,-2,2));
            ShowItems(tbItems);
        }
        
        public bool ShowItems(ListBox listBox)
        {
            listBox.Items.Clear();
            _objs.Sort((x, y) => x.Class.CompareTo(y.Class));

            if (_objs.Count == 0)
            {
                listBox.Items.Add("Class № 1");
                listBox.Items.Add("\n");
                listBox.Items.Add("Class № 2");
                return false;
            }
            bool test = false;
            string temp = "Class № 1";
            listBox.Items.Add(temp);
            
            foreach (var obj in _objs)
            {
                if (obj.Class == 2 && test == false)
                {        
                    temp = "\n";
                    listBox.Items.Add(temp);
                    test = true;
                    temp = "Class № 2";
                    listBox.Items.Add(temp);
         
                }
                string valuesString = "(" + obj.X + "," + obj.Y + ")";
                listBox.Items.Add(valuesString);
            }

            if (test == false)
            {
                temp = "\n";
                listBox.Items.Add(temp); 
                temp = "Class № 2";
                listBox.Items.Add(temp);
            }

            return test;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            _objs.Clear();
            ShowItems(tbItems);
        }

        private float GetFuncVal(int[] arr, float x)
        {
            return (float)(-1 * arr[1] * x + -1 * arr[0]) / (float)(arr[3] * x + arr[2]);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _objs.Add(new TestingObject((int)numX.Value,(int)numY.Value,(int)numClass.Value));
            ShowItems(tbItems);
        }

        private void Draw(Graphics g, int[] arr)
        {
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen,0,PlotCenterY,1400,PlotCenterY ) ;
            g.DrawLine(pen, PlotCenterX, 0, PlotCenterX, 1000);

            Brush penClass1 =  new SolidBrush(Color.Blue);
            Brush penClass2 =  new SolidBrush(Color.Red);
            foreach (var obj in _objs)
            {
                g.FillEllipse(obj.Class == 1 ? penClass1 : penClass2, 
                    obj.X * PlotScale + PlotCenterX- PlotObjectSize / 2,-1 *obj.Y * PlotScale + PlotCenterY - PlotObjectSize / 2,
                    PlotObjectSize,PlotObjectSize);
            }

            Brush func =  new SolidBrush(Color.Green);
            float X = PlotStartingX;
            while (X <= PlotEndingX)
            {
                float xVal = (X - PlotCenterX) / (float)PlotScale;
                float tempX = xVal * PlotScale + PlotCenterX - PlotObjectSize / 4;
                float tempY = -1 * GetFuncVal(arr, xVal) * PlotScale + PlotCenterY - PlotObjectSize / 4;
                g.FillEllipse(func,tempX,tempY, PlotObjectSize / 2,PlotObjectSize / 2);
                X += (float)0.1;
            }
        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (!ShowItems(tbItems))
            {
                MessageBox.Show("Both classes should have at least 1 item");
                return;
            }
            tbFunc.Items.Clear();
            _potential.LearnCollection(_objs);
            int[] arr = _potential.OutSolvingFucn();
            // y = [1] * x - [0] / [3]x + [2]
            tbFunc.Items.Add($"y = ({-1 * arr[1]} * x + {-1 * arr[0]} ) / ({arr[3]} * x + {arr[2]})");

            Graphics g = pnlPlot.CreateGraphics();
            Draw(g,arr);

        }
    }
}