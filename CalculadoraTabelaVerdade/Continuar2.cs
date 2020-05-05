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
    public partial class Continuar2 : Form
    {
        public static string[] possibility1 = new string[4];
        public static string[] possibility2 = new string[4];
        public static string[] result1Return = new string[4];
        public static string condition1, condition2, stringOperators, condition1value, condition2value;
        public Continuar2(string[] _result1Return)
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                possibility1[i] = _result1Return[i];
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            
            //Possibilidade dois

            if (srbp.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.p2[i];
                }
            }
            else if (srbq.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.q2[i];
                }
            }
            else if (srbnp.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.np2[i];
                }
            }
            else if (srbnq.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.nq2[i];
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    possibility2[i] = LogicalTable.p2[i];
                }
            }

            //Calculando Resultados


            if (rbConjuncao.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            else if (rbDisjuncao.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.or(condition1value, condition2value);
                }
            }
            else if (rbDisjuncaoExclusiva.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.xor(condition1value, condition2value);
                }
            }
            else if (rbCondicional.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.ifthen(condition1value, condition2value);
                }
            }
            else if (rbBicondicional.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.ifonlyif(condition1value, condition2value);
                }
            }
            else
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    result1Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            var resultado2 = new Resultado2(possibility1, possibility2, result1Return);
            resultado2.Show();
            this.Hide();
        }
    }
}
