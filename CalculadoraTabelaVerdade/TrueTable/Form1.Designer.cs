﻿namespace CalculadoraTabelaVerdade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RadioButtonLogical = new System.Windows.Forms.RadioButton();
            this.RadioButtonNumeric = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Tabela Verdade";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "2 Proposições";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(280, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "3 Proposições";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RadioButtonLogical
            // 
            this.RadioButtonLogical.AutoSize = true;
            this.RadioButtonLogical.Checked = true;
            this.RadioButtonLogical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonLogical.Location = new System.Drawing.Point(61, 69);
            this.RadioButtonLogical.Name = "RadioButtonLogical";
            this.RadioButtonLogical.Size = new System.Drawing.Size(77, 20);
            this.RadioButtonLogical.TabIndex = 3;
            this.RadioButtonLogical.TabStop = true;
            this.RadioButtonLogical.Text = "Logical";
            this.RadioButtonLogical.UseVisualStyleBackColor = true;
            // 
            // RadioButtonNumeric
            // 
            this.RadioButtonNumeric.AutoSize = true;
            this.RadioButtonNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonNumeric.Location = new System.Drawing.Point(144, 69);
            this.RadioButtonNumeric.Name = "RadioButtonNumeric";
            this.RadioButtonNumeric.Size = new System.Drawing.Size(83, 20);
            this.RadioButtonNumeric.TabIndex = 4;
            this.RadioButtonNumeric.Text = "Numeric";
            this.RadioButtonNumeric.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(553, 249);
            this.Controls.Add(this.RadioButtonNumeric);
            this.Controls.Add(this.RadioButtonLogical);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Tabela Verdade v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RadioButtonLogical;
        private System.Windows.Forms.RadioButton RadioButtonNumeric;
    }
}

