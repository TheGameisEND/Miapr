using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabN8
{
    public partial class frmMain : Form
    {
        private SyntaxMethod _solver;
        public frmMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /*private void btnAdd_Click(object sender, EventArgs e)
        {

            string input = tbString.Text;
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLower(c) && char.IsLetter(c))
                {
                    result.Append(c);
                }
            }

            tbString.Text = result.ToString();
            if (result.Length != 0)
                if (tbStrings.Text.Length == 0) 
                {
                    tbStrings.Text = result.ToString();
                }
                else
                {
                    tbStrings.Text = string.Concat(tbStrings.Text,Environment.NewLine,result.ToString());
                }
        }*/

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStrings.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (_solver != null)
            {
                //tbCreatedString.Text = _solver.GenerateString(1000);
                var sortedStrings = _solver.GenerateStrings(10).OrderBy(s => s.Length).ToArray();
                tbCreatedString.Text = string.Join(Environment.NewLine, sortedStrings);
            }
        }

        private void btnCreateGrammar_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            var strings = tbStrings.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            if (strings.Length == 0 || strings.Length == 1 && strings[0] == "")
            {
                return;
            }
            data.AddRange(strings);
            data.Remove("");
            _solver = new SyntaxMethod(data);
            _solver.CreateGrammar();
            tbGrammar.Text = _solver.OutputGrammarText();
        }
        
        
    }
}