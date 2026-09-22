namespace LabN6
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.numObjectsCount = new System.Windows.Forms.NumericUpDown();
            this.lblObjectCount = new System.Windows.Forms.Label();
            this.cbMaximized = new System.Windows.Forms.CheckBox();
            this.pnlPlot = new System.Windows.Forms.Panel();
            this.dgvDistances = new System.Windows.Forms.DataGridView();
            this.cbDistances = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.numObjectsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDistances)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnSolve.Location = new System.Drawing.Point(68, 24);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(206, 46);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // numObjectsCount
            // 
            this.numObjectsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.numObjectsCount.Location = new System.Drawing.Point(510, 34);
            this.numObjectsCount.Maximum = new decimal(new int[] {20, 0, 0, 0});
            this.numObjectsCount.Minimum = new decimal(new int[] {3, 0, 0, 0});
            this.numObjectsCount.Name = "numObjectsCount";
            this.numObjectsCount.Size = new System.Drawing.Size(202, 34);
            this.numObjectsCount.TabIndex = 1;
            this.numObjectsCount.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // lblObjectCount
            // 
            this.lblObjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblObjectCount.Location = new System.Drawing.Point(331, 36);
            this.lblObjectCount.Name = "lblObjectCount";
            this.lblObjectCount.Size = new System.Drawing.Size(173, 23);
            this.lblObjectCount.TabIndex = 2;
            this.lblObjectCount.Text = "Object count";
            // 
            // cbMaximized
            // 
            this.cbMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbMaximized.Location = new System.Drawing.Point(772, 28);
            this.cbMaximized.Name = "cbMaximized";
            this.cbMaximized.Size = new System.Drawing.Size(161, 40);
            this.cbMaximized.TabIndex = 3;
            this.cbMaximized.Text = "Maximized";
            this.cbMaximized.UseVisualStyleBackColor = true;
            // 
            // pnlPlot
            // 
            this.pnlPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.pnlPlot.Location = new System.Drawing.Point(12, 93);
            this.pnlPlot.Name = "pnlPlot";
            this.pnlPlot.Size = new System.Drawing.Size(1215, 551);
            this.pnlPlot.TabIndex = 4;
            // 
            // dgvDistances
            // 
            this.dgvDistances.AllowUserToAddRows = false;
            this.dgvDistances.AllowUserToDeleteRows = false;
            this.dgvDistances.AllowUserToResizeColumns = false;
            this.dgvDistances.AllowUserToResizeRows = false;
            this.dgvDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistances.Location = new System.Drawing.Point(591, 93);
            this.dgvDistances.Name = "dgvDistances";
            this.dgvDistances.ReadOnly = true;
            this.dgvDistances.RowTemplate.Height = 24;
            this.dgvDistances.Size = new System.Drawing.Size(636, 551);
            this.dgvDistances.TabIndex = 0;
            // 
            // cbDistances
            // 
            this.cbDistances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbDistances.Location = new System.Drawing.Point(998, 28);
            this.cbDistances.Name = "cbDistances";
            this.cbDistances.Size = new System.Drawing.Size(161, 40);
            this.cbDistances.TabIndex = 5;
            this.cbDistances.Text = "Distances";
            this.cbDistances.UseVisualStyleBackColor = true;
            this.cbDistances.CheckedChanged += new System.EventHandler(this.cbDistances_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 676);
            this.Controls.Add(this.cbDistances);
            this.Controls.Add(this.dgvDistances);
            this.Controls.Add(this.pnlPlot);
            this.Controls.Add(this.cbMaximized);
            this.Controls.Add(this.lblObjectCount);
            this.Controls.Add(this.numObjectsCount);
            this.Controls.Add(this.btnSolve);
            this.Name = "frmMain";
            this.Text = "Hierarchy";
            ((System.ComponentModel.ISupportInitialize) (this.numObjectsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDistances)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox cbDistances;

        private System.Windows.Forms.DataGridView dgvDistances;


        private System.Windows.Forms.Panel pnlPlot;

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.NumericUpDown numObjectsCount;
        private System.Windows.Forms.Label lblObjectCount;
        private System.Windows.Forms.CheckBox cbMaximized;

        #endregion
    }
}