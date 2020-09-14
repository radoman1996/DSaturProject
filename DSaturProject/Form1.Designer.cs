namespace DSaturProject
{
    partial class Form1
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
            this.btnColorGraph = new System.Windows.Forms.Button();
            this.btnSudoku = new System.Windows.Forms.Button();
            this.panelColorGraph = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSolution = new System.Windows.Forms.Panel();
            this.labelSolution = new System.Windows.Forms.Label();
            this.labelGraphInformation = new System.Windows.Forms.Label();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnShowSolutionGraphColor = new System.Windows.Forms.Button();
            this.btnChromaticNumber = new System.Windows.Forms.Button();
            this.comboBoxSelectGraph = new System.Windows.Forms.ComboBox();
            this.panelSudoku = new System.Windows.Forms.Panel();
            this.panelShowSudoku = new System.Windows.Forms.Panel();
            this.btnSolveSudoku = new System.Windows.Forms.Button();
            this.comboBoxSudokuExample = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelColorGraph.SuspendLayout();
            this.panelSolution.SuspendLayout();
            this.panelSudoku.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColorGraph
            // 
            this.btnColorGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorGraph.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorGraph.Location = new System.Drawing.Point(12, 12);
            this.btnColorGraph.Name = "btnColorGraph";
            this.btnColorGraph.Size = new System.Drawing.Size(204, 35);
            this.btnColorGraph.TabIndex = 0;
            this.btnColorGraph.Text = "Bojenje grafova";
            this.btnColorGraph.UseVisualStyleBackColor = true;
            this.btnColorGraph.Click += new System.EventHandler(this.btnColorGraph_Click);
            // 
            // btnSudoku
            // 
            this.btnSudoku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSudoku.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSudoku.Location = new System.Drawing.Point(12, 55);
            this.btnSudoku.Name = "btnSudoku";
            this.btnSudoku.Size = new System.Drawing.Size(204, 35);
            this.btnSudoku.TabIndex = 1;
            this.btnSudoku.Text = "Sudoku";
            this.btnSudoku.UseVisualStyleBackColor = true;
            this.btnSudoku.Click += new System.EventHandler(this.btnSudoku_Click);
            // 
            // panelColorGraph
            // 
            this.panelColorGraph.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelColorGraph.Controls.Add(this.label1);
            this.panelColorGraph.Controls.Add(this.panelSolution);
            this.panelColorGraph.Controls.Add(this.labelGraphInformation);
            this.panelColorGraph.Controls.Add(this.btnShowGraph);
            this.panelColorGraph.Controls.Add(this.btnShowSolutionGraphColor);
            this.panelColorGraph.Controls.Add(this.btnChromaticNumber);
            this.panelColorGraph.Controls.Add(this.comboBoxSelectGraph);
            this.panelColorGraph.Location = new System.Drawing.Point(222, 12);
            this.panelColorGraph.Name = "panelColorGraph";
            this.panelColorGraph.Size = new System.Drawing.Size(625, 464);
            this.panelColorGraph.TabIndex = 2;
            this.panelColorGraph.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bojenje grafova";
            // 
            // panelSolution
            // 
            this.panelSolution.AutoScroll = true;
            this.panelSolution.Controls.Add(this.labelSolution);
            this.panelSolution.Location = new System.Drawing.Point(286, 51);
            this.panelSolution.Name = "panelSolution";
            this.panelSolution.Size = new System.Drawing.Size(333, 398);
            this.panelSolution.TabIndex = 6;
            this.panelSolution.Visible = false;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolution.Location = new System.Drawing.Point(42, 17);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(42, 17);
            this.labelSolution.TabIndex = 0;
            this.labelSolution.Text = "label2";
            // 
            // labelGraphInformation
            // 
            this.labelGraphInformation.AutoSize = true;
            this.labelGraphInformation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphInformation.Location = new System.Drawing.Point(16, 89);
            this.labelGraphInformation.Name = "labelGraphInformation";
            this.labelGraphInformation.Size = new System.Drawing.Size(42, 19);
            this.labelGraphInformation.TabIndex = 5;
            this.labelGraphInformation.Text = "label";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowGraph.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGraph.Location = new System.Drawing.Point(13, 410);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(254, 39);
            this.btnShowGraph.TabIndex = 4;
            this.btnShowGraph.Text = "Grafički prikaz";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnShowSolutionGraphColor
            // 
            this.btnShowSolutionGraphColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSolutionGraphColor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSolutionGraphColor.Location = new System.Drawing.Point(13, 363);
            this.btnShowSolutionGraphColor.Name = "btnShowSolutionGraphColor";
            this.btnShowSolutionGraphColor.Size = new System.Drawing.Size(254, 39);
            this.btnShowSolutionGraphColor.TabIndex = 3;
            this.btnShowSolutionGraphColor.Text = "Prikaži rješenje";
            this.btnShowSolutionGraphColor.UseVisualStyleBackColor = true;
            this.btnShowSolutionGraphColor.Click += new System.EventHandler(this.btnShowSolutionGraphColor_Click);
            // 
            // btnChromaticNumber
            // 
            this.btnChromaticNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChromaticNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChromaticNumber.Location = new System.Drawing.Point(13, 316);
            this.btnChromaticNumber.Name = "btnChromaticNumber";
            this.btnChromaticNumber.Size = new System.Drawing.Size(254, 39);
            this.btnChromaticNumber.TabIndex = 2;
            this.btnChromaticNumber.Text = "Hromatski broj";
            this.btnChromaticNumber.UseVisualStyleBackColor = true;
            this.btnChromaticNumber.Click += new System.EventHandler(this.btnChromaticNumber_Click);
            // 
            // comboBoxSelectGraph
            // 
            this.comboBoxSelectGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGraph.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGraph.FormattingEnabled = true;
            this.comboBoxSelectGraph.Location = new System.Drawing.Point(13, 51);
            this.comboBoxSelectGraph.Name = "comboBoxSelectGraph";
            this.comboBoxSelectGraph.Size = new System.Drawing.Size(254, 25);
            this.comboBoxSelectGraph.TabIndex = 0;
            this.comboBoxSelectGraph.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGraph_SelectedIndexChanged);
            // 
            // panelSudoku
            // 
            this.panelSudoku.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSudoku.Controls.Add(this.panelShowSudoku);
            this.panelSudoku.Controls.Add(this.btnSolveSudoku);
            this.panelSudoku.Controls.Add(this.comboBoxSudokuExample);
            this.panelSudoku.Controls.Add(this.label2);
            this.panelSudoku.Location = new System.Drawing.Point(222, 12);
            this.panelSudoku.Name = "panelSudoku";
            this.panelSudoku.Size = new System.Drawing.Size(625, 464);
            this.panelSudoku.TabIndex = 3;
            this.panelSudoku.Visible = false;
            // 
            // panelShowSudoku
            // 
            this.panelShowSudoku.Location = new System.Drawing.Point(164, 106);
            this.panelShowSudoku.Name = "panelShowSudoku";
            this.panelShowSudoku.Size = new System.Drawing.Size(452, 355);
            this.panelShowSudoku.TabIndex = 3;
            // 
            // btnSolveSudoku
            // 
            this.btnSolveSudoku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolveSudoku.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolveSudoku.Location = new System.Drawing.Point(331, 58);
            this.btnSolveSudoku.Name = "btnSolveSudoku";
            this.btnSolveSudoku.Size = new System.Drawing.Size(204, 30);
            this.btnSolveSudoku.TabIndex = 2;
            this.btnSolveSudoku.Text = "Riješi sudoku";
            this.btnSolveSudoku.UseVisualStyleBackColor = true;
            this.btnSolveSudoku.Click += new System.EventHandler(this.btnSolveSudoku_Click);
            // 
            // comboBoxSudokuExample
            // 
            this.comboBoxSudokuExample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSudokuExample.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSudokuExample.FormattingEnabled = true;
            this.comboBoxSudokuExample.Items.AddRange(new object[] {
            "Sudoku 1",
            "Sudoku 2",
            "Sudoku 3",
            "Sudoku 4",
            "Sudoku 5"});
            this.comboBoxSudokuExample.Location = new System.Drawing.Point(76, 59);
            this.comboBoxSudokuExample.Name = "comboBoxSudokuExample";
            this.comboBoxSudokuExample.Size = new System.Drawing.Size(204, 27);
            this.comboBoxSudokuExample.TabIndex = 1;
            this.comboBoxSudokuExample.SelectedIndexChanged += new System.EventHandler(this.comboBoxSudokuExample_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUDOKU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 488);
            this.Controls.Add(this.panelSudoku);
            this.Controls.Add(this.panelColorGraph);
            this.Controls.Add(this.btnSudoku);
            this.Controls.Add(this.btnColorGraph);
            this.Name = "Form1";
            this.Text = "Aplikacija za grafove";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelColorGraph.ResumeLayout(false);
            this.panelColorGraph.PerformLayout();
            this.panelSolution.ResumeLayout(false);
            this.panelSolution.PerformLayout();
            this.panelSudoku.ResumeLayout(false);
            this.panelSudoku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColorGraph;
        private System.Windows.Forms.Button btnSudoku;
        private System.Windows.Forms.Panel panelColorGraph;
        private System.Windows.Forms.Panel panelSudoku;
        private System.Windows.Forms.Label labelGraphInformation;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.Button btnShowSolutionGraphColor;
        private System.Windows.Forms.Button btnChromaticNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectGraph;
        private System.Windows.Forms.Panel panelSolution;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Panel panelShowSudoku;
        private System.Windows.Forms.Button btnSolveSudoku;
        private System.Windows.Forms.ComboBox comboBoxSudokuExample;
        private System.Windows.Forms.Label label2;
    }
}

