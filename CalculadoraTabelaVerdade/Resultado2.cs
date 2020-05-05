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
    public partial class Resultado2 : Form
    {
        public static string[] possibility1 = new string[4];
        public static string[] possibility2 = new string[4];
        public static string[] result1Return = new string[4];
        public Resultado2(string[] _possibility1)
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                possibility1[i] = _possibility1[i];
            }

            ShowResult();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ShowResult()
        {
            label1.Text = possibility1[0];
            label2.Text = possibility1[1];
            label3.Text = possibility1[2];
            label4.Text = possibility1[3];

        }
    }
}
