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
    public partial class Form3 : Form
    {
        public static string condition1, condition2, stringOperators, condition1value, condition2value;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            this.Hide();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string[] possibility1 = new string[8];
            if (rbp.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.p3[i];
                }
            }
            else if (rbq.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.q3[i];
                }
            }
            else if (rbnp.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.np3[i];
                }
            }
            else if (rbnq.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.nq3[i];
                }
            }
            else if (rbr.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.r3[i];
                }
            }
            else if (rbnr.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.nr3[i];
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility1[i] = LogicalTable.p3[i];
                }
            }

            // possibility 2

            string[] possibility2 = new string[8];
            if (srbp.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.p3[i];
                }
            }
            else if (srbq.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.q3[i];
                }
            }
            else if (srbnp.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.np3[i];
                }
            }
            else if (srbnq.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.nq3[i];
                }
            }
            else if (srbr.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.r3[i];
                }
            }
            else if (srbnr.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.nr3[i];
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    possibility2[i] = LogicalTable.p3[i];
                }
            }

            // Calculando

            if (rbConjuncao.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.and(condition1value, condition2value);
                }
            }
            else if (rbDisjuncao.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.or(condition1value, condition2value);
                }
            }
            else if (rbDisjuncaoExclusiva.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.xor(condition1value, condition2value);
                }
            }
            else if (rbCondicional.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.ifthen(condition1value, condition2value);
                }
            }
            else if (rbBicondicional.Checked)
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.ifonlyif(condition1value, condition2value);
                }
            }
            else
            {
                for (int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++)
                {
                    condition1value = possibility1[i];
                    condition2value = possibility2[j];
                    LogicalTable.result3Return[k] = Operations.and(condition1value, condition2value);
                }
            }

            //Mostrar result


        }

    }
}
