using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTabelaVerdade
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        private void ButtonCalculator_Click(object sender, EventArgs e)
        {
            if(!FormCalculator.IsHandleCreated)
                FormCalculator = new Calculator.Calculator();
            FormCalculator.Show();
            FormCalculator.Activate();
            Debug.Logger("Calculator Opened");
        }

        private void ButtonConverters_Click(object sender, EventArgs e)
        {
            if (!FormConverters.IsHandleCreated)
                FormConverters = new Converters.Converters();
            FormConverters.Show();
            FormConverters.Activate();
            Debug.Logger("Converters Opened");
        }

        private void ButtonMatrix_Click(object sender, EventArgs e)
        {
            if (!FormMatrix.IsHandleCreated)
                FormMatrix = new Matrix.Matrix();
            FormMatrix.Show();
            FormMatrix.Activate();
            Debug.Logger("Matrix Opened");
        }

        private void ButtonArea_Click(object sender, EventArgs e)
        {
            if (!FormArea.IsHandleCreated)
                FormArea = new Area.Area();
            FormArea.Show();
            FormArea.Activate();
            Debug.Logger("Area Opened");
        }

        private void ButtonInterest_Click(object sender, EventArgs e)
        {
            if (!FormInterest.IsHandleCreated)
                FormInterest = new Interest.Interest();
            FormInterest.Show();
            FormInterest.Activate();
            Debug.Logger("Interest Opened");
        }

        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            if (!FormAverage.IsHandleCreated)
                FormAverage = new Average.Average();
            FormAverage.Show();
            FormAverage.Activate();
            Debug.Logger("Average Opened");
        }

        private void ButtonBMI_Click(object sender, EventArgs e)
        {
            if (!FormBMI.IsHandleCreated)
                FormBMI = new BMI.BMI();
            FormBMI.Show();
            FormBMI.Activate();
            Debug.Logger("BMI Opened");
        }

        private void ButtonTrueTable_Click(object sender, EventArgs e)
        {
            if (!FormTrueTable.IsHandleCreated)
                FormTrueTable = new Form1();
            FormTrueTable.Show();
            FormTrueTable.Activate();
            Debug.Logger("TrueTable Opened");
        }

        private void ButtonMultTable_Click(object sender, EventArgs e)
        {
            if (!FormMultTable.IsHandleCreated)
                FormMultTable = new MultTable.MultTable();
            FormMultTable.Show();
            FormMultTable.Activate();
            Debug.Logger("MultTable Opened");
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            //Visiting The Project
            System.Diagnostics.Process.Start("https://github.com");
            Debug.Logger("Github Project Opened");
        }

        private void LabelCredits_Click(object sender, EventArgs e)
        {
            //Visiting The Owners Of Project
            System.Diagnostics.Process.Start("https://github.com/MuriloChianfa");
            System.Diagnostics.Process.Start("https://github.com/Kamikzr");
            Debug.Logger("Github Of Owners Opened");
        }

        private void LabelVersions_Click(object sender, EventArgs e)
        {
            //Visiting The Versions Of Project
            System.Diagnostics.Process.Start("https://github.com");
            Debug.Logger("Versions Of The Project Opened");
        }


        //Instantiating HWND To All Windows

        private static Area.Area FormArea = new Area.Area();
        private static Average.Average FormAverage = new Average.Average();
        private static BMI.BMI FormBMI = new BMI.BMI();
        private static Calculator.Calculator FormCalculator = new Calculator.Calculator();
        private static Converters.Converters FormConverters = new Converters.Converters();
        private static Interest.Interest FormInterest = new Interest.Interest();
        private static Matrix.Matrix FormMatrix = new Matrix.Matrix();
        private static MultTable.MultTable FormMultTable = new MultTable.MultTable();
        private static Form1 FormTrueTable = new Form1();
    }
}
