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
    public partial class Continuar3 : Form
    {
        public static string[] possibility1 = new string[8];
        public static string[] possibility2 = new string[8];
        public static string[] result3Return = new string[8];
        public static string condition1, condition2, stringOperators, condition1value, condition2value, stringPossibility1, stringPossibility2;


        public Continuar3(string[] _result3Return, string _stringPossibility1)
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                possibility1[i] = _result3Return[i];
            }
            stringPossibility1 = _stringPossibility1;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
