using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTabelaVerdade.Calculator
{
    public partial class Calculator : Form
    {
        Decimal Number;
        Decimal Result;
        Decimal LastNumber;
        String Operator;
        public Calculator()
        {
            InitializeComponent();

            Clear();
        }

        private void Clear()
        {
            Number = 0;
            Result = 0;
            LastNumber = 0;
            Operator = "+";
            TextBoxResult.Text = null;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Operator = "+";
                LastNumber = Convert.ToDecimal(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
            catch (Exception Error)
            {
                Debug.Logger(Error.Message.ToString());
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Operator = "-";
                LastNumber = Convert.ToDecimal(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
            catch (Exception Error)
            {
                Debug.Logger(Error.Message.ToString());
            }
        }

        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            try
            {
                Operator = "*";
                LastNumber = Convert.ToDecimal(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
            catch (Exception Error)
            {
                Debug.Logger(Error.Message.ToString());
            }
        }

        private void ButtonDivided_Click(object sender, EventArgs e)
        {
            try
            {
                Operator = "/";
                LastNumber = Convert.ToDecimal(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
            catch (Exception Error)
            {
                Debug.Logger(Error.Message.ToString());
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                Number = Convert.ToDecimal(TextBoxResult.Text);
                if (Operator == "+")
                {
                    try
                    {
                        Result = LastNumber + Number;
                        LastNumber = Result;
                        Operator = "+";
                        TextBoxResult.Text = string.Empty + Result;
                    }
                    catch (Exception Error)
                    {
                        Debug.Logger(Error.Message.ToString());
                    }
                }
                else if (Operator == "-")
                {
                    try
                    {
                        Result = LastNumber - Number;
                        LastNumber = Result;
                        Operator = "-";
                        TextBoxResult.Text = string.Empty + Result;
                    }
                    catch (Exception Error)
                    {
                        Debug.Logger(Error.Message.ToString());
                    }
                }
                else if (Operator == "/")
                {
                    try
                    {
                        Result = LastNumber / Number;
                        LastNumber = Result;
                        Operator = "/";
                        TextBoxResult.Text = string.Empty + Result;
                    }
                    catch (Exception Error)
                    {
                        Debug.Logger(Error.Message.ToString());
                    }
                }
                else if (Operator == "*")
                {
                    try
                    {
                        Result = LastNumber * Number;
                        LastNumber = Result;
                        Operator = "*";
                        TextBoxResult.Text = string.Empty + Result;
                    }
                    catch (Exception Error)
                    {
                        Debug.Logger(Error.Message.ToString());
                    }
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception Error)
            {
                Debug.Logger(Error.Message.ToString());
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + "9";
        }
    }
}
