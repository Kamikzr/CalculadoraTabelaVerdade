using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace CalculadoraTabelaVerdade.Calculator
{
    public partial class Calculator : Form
    {
        Double Number;
        Double Result;
        Double LastNumber;
        String Operator;
        public Calculator()
        {
            InitializeComponent();

            Label1.Text = "Value1";
            Label2.Text = "Value2";
            Label3.Text = "Value3";
            Label4.Text = "Value4";

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

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = TextBoxResult.Text + ",";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            try
            {

                Operator = "+";
                LastNumber = Convert.ToDouble(TextBoxResult.Text);
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
                LastNumber = Convert.ToDouble(TextBoxResult.Text);
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
                LastNumber = Convert.ToDouble(TextBoxResult.Text);
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
                LastNumber = Convert.ToDouble(TextBoxResult.Text);
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
                Number = Convert.ToDouble(TextBoxResult.Text);
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ButtonInsert1_Click(object sender, EventArgs e)
        {
            if(TextBoxResult.Text != "")
            {
                Label1.Text = Convert.ToString(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
        }

        private void ButtonInsert2_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text != "")
            {
                Label2.Text = Convert.ToString(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
        }

        private void ButtonInsert3_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text != "")
            {
                Label3.Text = Convert.ToString(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
        }

        private void ButtonInsert4_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text != "")
            {
                Label4.Text = Convert.ToString(TextBoxResult.Text);
                TextBoxResult.Text = null;
            }
        }

        private void ButtonReturn1_Click(object sender, EventArgs e)
        {
            if(Label1.Text != "Value1")
                TextBoxResult.Text = Label1.Text;
        }

        private void ButtonReturn2_Click(object sender, EventArgs e)
        {
            if (Label2.Text != "Value2")
                TextBoxResult.Text = Label2.Text;
        }

        private void ButtonReturn3_Click(object sender, EventArgs e)
        {
            if (Label3.Text != "Value3")
                TextBoxResult.Text = Label3.Text;
        }

        private void ButtonReturn4_Click(object sender, EventArgs e)
        {
            if (Label4.Text != "Value4")
                TextBoxResult.Text = Label4.Text;
        }
    }
}
