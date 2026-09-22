namespace LabN8
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
            this.tbStrings = new System.Windows.Forms.TextBox();
            this.lblStudyData = new System.Windows.Forms.Label();
            this.tbGrammar = new System.Windows.Forms.TextBox();
            this.lblGrammar = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbCreatedString = new System.Windows.Forms.TextBox();
            this.btnCreateGrammar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStrings
            // 
            this.tbStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStrings.Location = new System.Drawing.Point(21, 58);
            this.tbStrings.Margin = new System.Windows.Forms.Padding(2);
            this.tbStrings.Multiline = true;
            this.tbStrings.Name = "tbStrings";
            this.tbStrings.Size = new System.Drawing.Size(162, 184);
            this.tbStrings.TabIndex = 0;
            this.tbStrings.Text = "caaab\r\nbbaab\r\ncaab\r\nbbab\r\ncab\r\nbbb\r\ncb";
            // 
            // lblStudyData
            // 
            this.lblStudyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudyData.Location = new System.Drawing.Point(21, 20);
            this.lblStudyData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudyData.Name = "lblStudyData";
            this.lblStudyData.Size = new System.Drawing.Size(188, 27);
            this.lblStudyData.TabIndex = 1;
            this.lblStudyData.Text = "Learning data";
            // 
            // tbGrammar
            // 
            this.tbGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGrammar.Location = new System.Drawing.Point(197, 58);
            this.tbGrammar.Margin = new System.Windows.Forms.Padding(2);
            this.tbGrammar.Multiline = true;
            this.tbGrammar.Name = "tbGrammar";
            this.tbGrammar.ReadOnly = true;
            this.tbGrammar.Size = new System.Drawing.Size(162, 184);
            this.tbGrammar.TabIndex = 2;
            // 
            // lblGrammar
            // 
            this.lblGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrammar.Location = new System.Drawing.Point(197, 20);
            this.lblGrammar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrammar.Name = "lblGrammar";
            this.lblGrammar.Size = new System.Drawing.Size(188, 27);
            this.lblGrammar.TabIndex = 3;
            this.lblGrammar.Text = "Resulting grammar";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(379, 257);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(241, 37);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create string";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbCreatedString
            // 
            this.tbCreatedString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCreatedString.Location = new System.Drawing.Point(379, 20);
            this.tbCreatedString.Margin = new System.Windows.Forms.Padding(2);
            this.tbCreatedString.Multiline = true;
            this.tbCreatedString.Name = "tbCreatedString";
            this.tbCreatedString.ReadOnly = true;
            this.tbCreatedString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCreatedString.Size = new System.Drawing.Size(241, 222);
            this.tbCreatedString.TabIndex = 9;
            // 
            // btnCreateGrammar
            // 
            this.btnCreateGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGrammar.Location = new System.Drawing.Point(21, 256);
            this.btnCreateGrammar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateGrammar.Name = "btnCreateGrammar";
            this.btnCreateGrammar.Size = new System.Drawing.Size(338, 38);
            this.btnCreateGrammar.TabIndex = 12;
            this.btnCreateGrammar.Text = "Create grammar";
            this.btnCreateGrammar.UseVisualStyleBackColor = true;
            this.btnCreateGrammar.Click += new System.EventHandler(this.btnCreateGrammar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 310);
            this.Controls.Add(this.btnCreateGrammar);
            this.Controls.Add(this.tbCreatedString);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblGrammar);
            this.Controls.Add(this.tbGrammar);
            this.Controls.Add(this.lblStudyData);
            this.Controls.Add(this.tbStrings);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "frmMain";
            this.Text = "GrammarCreator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblStudyData;
        private System.Windows.Forms.TextBox tbGrammar;

        private System.Windows.Forms.Label lblGrammar;

        private System.Windows.Forms.TextBox tbStrings;

        private System.Windows.Forms.TextBox tbCreatedString;

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCreateGrammar;

        #endregion
    }
}