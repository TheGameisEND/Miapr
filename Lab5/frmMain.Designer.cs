namespace LabN5
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFunc = new System.Windows.Forms.ListBox();
            this.tbItems = new System.Windows.Forms.ListBox();
            this.lblResFuncs = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numClass = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlPlot = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFunc
            // 
            this.tbFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbFunc.FormattingEnabled = true;
            this.tbFunc.ItemHeight = 28;
            this.tbFunc.Location = new System.Drawing.Point(497, 186);
            this.tbFunc.Name = "tbFunc";
            this.tbFunc.Size = new System.Drawing.Size(417, 32);
            this.tbFunc.TabIndex = 12;
            // 
            // tbItems
            // 
            this.tbItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbItems.FormattingEnabled = true;
            this.tbItems.ItemHeight = 28;
            this.tbItems.Location = new System.Drawing.Point(9, 32);
            this.tbItems.Name = "tbItems";
            this.tbItems.Size = new System.Drawing.Size(406, 200);
            this.tbItems.TabIndex = 11;
            // 
            // lblResFuncs
            // 
            this.lblResFuncs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblResFuncs.Location = new System.Drawing.Point(577, 144);
            this.lblResFuncs.Name = "lblResFuncs";
            this.lblResFuncs.Size = new System.Drawing.Size(264, 39);
            this.lblResFuncs.TabIndex = 10;
            this.lblResFuncs.Text = "Resulting function\r\n";
            // 
            // lblClasses
            // 
            this.lblClasses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblClasses.Location = new System.Drawing.Point(130, -2);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(232, 31);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "Items";
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnSolve.Location = new System.Drawing.Point(850, 16);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(170, 51);
            this.btnSolve.TabIndex = 13;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // numX
            // 
            this.numX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numX.Location = new System.Drawing.Point(512, 104);
            this.numX.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numX.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 30);
            this.numX.TabIndex = 14;
            // 
            // numY
            // 
            this.numY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numY.Location = new System.Drawing.Point(654, 104);
            this.numY.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numY.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 30);
            this.numY.TabIndex = 15;
            // 
            // numClass
            // 
            this.numClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numClass.Location = new System.Drawing.Point(807, 104);
            this.numClass.Maximum = new decimal(new int[] {2, 0, 0, 0});
            this.numClass.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numClass.Name = "numClass";
            this.numClass.Size = new System.Drawing.Size(120, 30);
            this.numClass.TabIndex = 16;
            this.numClass.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblX.Location = new System.Drawing.Point(534, 70);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(88, 31);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblY.Location = new System.Drawing.Point(676, 70);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(88, 31);
            this.lblY.TabIndex = 18;
            this.lblY.Text = "Y";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblClass.Location = new System.Drawing.Point(826, 70);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(88, 31);
            this.lblClass.TabIndex = 19;
            this.lblClass.Text = "Class";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnAdd.Location = new System.Drawing.Point(467, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 51);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnClear.Location = new System.Drawing.Point(653, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 51);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear Items";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlPlot
            // 
            this.pnlPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlot.Location = new System.Drawing.Point(171, 254);
            this.pnlPlot.Name = "pnlPlot";
            this.pnlPlot.Size = new System.Drawing.Size(799, 459);
            this.pnlPlot.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 751);
            this.Controls.Add(this.pnlPlot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numClass);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbFunc);
            this.Controls.Add(this.tbItems);
            this.Controls.Add(this.lblResFuncs);
            this.Controls.Add(this.lblClasses);
            this.Name = "frmMain";
            this.Text = "Lab5";
            ((System.ComponentModel.ISupportInitialize) (this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numClass)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlPlot;

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numClass;
        private System.Windows.Forms.Label lblClass;

        private System.Windows.Forms.NumericUpDown numX;

        private System.Windows.Forms.Button btnSolve;

        private System.Windows.Forms.ListBox tbFunc;
        private System.Windows.Forms.ListBox tbItems;
        private System.Windows.Forms.Label lblResFuncs;
        private System.Windows.Forms.Label lblClasses;

        #endregion
    }
}