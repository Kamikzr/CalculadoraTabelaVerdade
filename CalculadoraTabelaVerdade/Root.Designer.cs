namespace CalculadoraTabelaVerdade
{
    partial class Root
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
            System.Windows.Forms.Label LabelVersions;
            this.LabelCredits = new System.Windows.Forms.Label();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonCalculator = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonMatrix = new System.Windows.Forms.Button();
            this.ButtonConverters = new System.Windows.Forms.Button();
            this.ButtonInterest = new System.Windows.Forms.Button();
            this.ButtonArea = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ButtonBMI = new System.Windows.Forms.Button();
            this.ButtonMultTable = new System.Windows.Forms.Button();
            this.ButtonTrueTable = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            LabelVersions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelVersions
            // 
            LabelVersions.AutoSize = true;
            LabelVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            LabelVersions.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelVersions.Location = new System.Drawing.Point(439, 361);
            LabelVersions.Name = "LabelVersions";
            LabelVersions.Size = new System.Drawing.Size(63, 16);
            LabelVersions.TabIndex = 14;
            LabelVersions.Text = "V 1.0®";
            LabelVersions.Click += new System.EventHandler(this.LabelVersions_Click);
            // 
            // LabelCredits
            // 
            this.LabelCredits.AutoSize = true;
            this.LabelCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCredits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCredits.Location = new System.Drawing.Point(2, 320);
            this.LabelCredits.Name = "LabelCredits";
            this.LabelCredits.Size = new System.Drawing.Size(186, 54);
            this.LabelCredits.TabIndex = 13;
            this.LabelCredits.Text = "Criado por: \r\n             > Murilo Chianfa\r\n             > Marcelo Yida\r\n";
            this.LabelCredits.Click += new System.EventHandler(this.LabelCredits_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonAverage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAverage.Location = new System.Drawing.Point(182, 80);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(139, 35);
            this.ButtonAverage.TabIndex = 2;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = false;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // ButtonCalculator
            // 
            this.ButtonCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCalculator.Location = new System.Drawing.Point(37, 80);
            this.ButtonCalculator.Name = "ButtonCalculator";
            this.ButtonCalculator.Size = new System.Drawing.Size(139, 35);
            this.ButtonCalculator.TabIndex = 1;
            this.ButtonCalculator.Text = "Calculator";
            this.ButtonCalculator.UseVisualStyleBackColor = false;
            this.ButtonCalculator.Click += new System.EventHandler(this.ButtonCalculator_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(63, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(374, 40);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Advanced Calculator";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // ButtonMatrix
            // 
            this.ButtonMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMatrix.Location = new System.Drawing.Point(327, 80);
            this.ButtonMatrix.Name = "ButtonMatrix";
            this.ButtonMatrix.Size = new System.Drawing.Size(139, 35);
            this.ButtonMatrix.TabIndex = 3;
            this.ButtonMatrix.Text = "Matrix";
            this.ButtonMatrix.UseVisualStyleBackColor = false;
            this.ButtonMatrix.Click += new System.EventHandler(this.ButtonMatrix_Click);
            // 
            // ButtonConverters
            // 
            this.ButtonConverters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonConverters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConverters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConverters.Location = new System.Drawing.Point(327, 136);
            this.ButtonConverters.Name = "ButtonConverters";
            this.ButtonConverters.Size = new System.Drawing.Size(139, 35);
            this.ButtonConverters.TabIndex = 6;
            this.ButtonConverters.Text = "Converters";
            this.ButtonConverters.UseVisualStyleBackColor = false;
            this.ButtonConverters.Click += new System.EventHandler(this.ButtonConverters_Click);
            // 
            // ButtonInterest
            // 
            this.ButtonInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonInterest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInterest.Location = new System.Drawing.Point(182, 136);
            this.ButtonInterest.Name = "ButtonInterest";
            this.ButtonInterest.Size = new System.Drawing.Size(139, 35);
            this.ButtonInterest.TabIndex = 5;
            this.ButtonInterest.Text = "Interest";
            this.ButtonInterest.UseVisualStyleBackColor = false;
            this.ButtonInterest.Click += new System.EventHandler(this.ButtonInterest_Click);
            // 
            // ButtonArea
            // 
            this.ButtonArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonArea.Location = new System.Drawing.Point(37, 136);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.Size = new System.Drawing.Size(139, 35);
            this.ButtonArea.TabIndex = 4;
            this.ButtonArea.Text = "Area";
            this.ButtonArea.UseVisualStyleBackColor = false;
            this.ButtonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(327, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 35);
            this.button7.TabIndex = 9;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(182, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 35);
            this.button8.TabIndex = 8;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // ButtonBMI
            // 
            this.ButtonBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonBMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBMI.Location = new System.Drawing.Point(37, 194);
            this.ButtonBMI.Name = "ButtonBMI";
            this.ButtonBMI.Size = new System.Drawing.Size(139, 35);
            this.ButtonBMI.TabIndex = 7;
            this.ButtonBMI.Text = "BMI";
            this.ButtonBMI.UseVisualStyleBackColor = false;
            this.ButtonBMI.Click += new System.EventHandler(this.ButtonBMI_Click);
            // 
            // ButtonMultTable
            // 
            this.ButtonMultTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonMultTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMultTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultTable.Location = new System.Drawing.Point(327, 249);
            this.ButtonMultTable.Name = "ButtonMultTable";
            this.ButtonMultTable.Size = new System.Drawing.Size(139, 35);
            this.ButtonMultTable.TabIndex = 12;
            this.ButtonMultTable.Text = "Multplication Table";
            this.ButtonMultTable.UseVisualStyleBackColor = false;
            this.ButtonMultTable.Click += new System.EventHandler(this.ButtonMultTable_Click);
            // 
            // ButtonTrueTable
            // 
            this.ButtonTrueTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ButtonTrueTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTrueTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrueTable.Location = new System.Drawing.Point(182, 249);
            this.ButtonTrueTable.Name = "ButtonTrueTable";
            this.ButtonTrueTable.Size = new System.Drawing.Size(139, 35);
            this.ButtonTrueTable.TabIndex = 11;
            this.ButtonTrueTable.Text = "True Table";
            this.ButtonTrueTable.UseVisualStyleBackColor = false;
            this.ButtonTrueTable.Click += new System.EventHandler(this.ButtonTrueTable_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(37, 249);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(139, 35);
            this.button12.TabIndex = 10;
            this.button12.Text = "?";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(502, 379);
            this.Controls.Add(LabelVersions);
            this.Controls.Add(this.ButtonMultTable);
            this.Controls.Add(this.ButtonTrueTable);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ButtonBMI);
            this.Controls.Add(this.ButtonConverters);
            this.Controls.Add(this.ButtonInterest);
            this.Controls.Add(this.ButtonArea);
            this.Controls.Add(this.ButtonMatrix);
            this.Controls.Add(this.LabelCredits);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonCalculator);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Root";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Calculator  |  v 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCredits;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonCalculator;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ButtonMatrix;
        private System.Windows.Forms.Button ButtonConverters;
        private System.Windows.Forms.Button ButtonInterest;
        private System.Windows.Forms.Button ButtonArea;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ButtonBMI;
        private System.Windows.Forms.Button ButtonMultTable;
        private System.Windows.Forms.Button ButtonTrueTable;
        private System.Windows.Forms.Button button12;
    }
}