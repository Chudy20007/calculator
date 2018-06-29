using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "0";
            }
            else
            tbValues.Text += "0";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "1";
            }
            else
                tbValues.Text += "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "2";
            }
            else
                tbValues.Text += "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "3";
            }
            else
                tbValues.Text += "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "4";
            }
            else
                tbValues.Text += "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "5";
            }
            else
                tbValues.Text += "5";
        }


        protected void Button6_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "6";
            }
            else
                tbValues.Text += "6";
        }


        protected void Button7_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "7";
            }
            else
                tbValues.Text += "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "8";
            }
            else
                tbValues.Text += "8";
        }


        protected void Button9_Click(object sender, EventArgs e)
        {
            if (emptyValues() == false)
            {
                tbResult.Text = "";
                tbValues.Text = "9";
            }
            else
                tbValues.Text += "9";
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (checkValueChar() ==true)
            {
                return;
            }
            if (tbResult.Text.Length > 0)
            {
                tbValues.Text = "";
                int count = 1;
                do
                {
                    tbValues.Text += tbResult.Text[count];
                    count++;
                } while (count < tbResult.Text.Length);

                tbResult.Text = "";
            }
            tbValues.Text += "+";
        }

        protected void ButtonSubb_Click(object sender, EventArgs e)
        {
            if (checkValueChar() == true)
            {
                return;
            }
            if (tbResult.Text.Length > 0)
            {
               
                tbValues.Text = "";
                int count = 1;
                do
                {
                    tbValues.Text += tbResult.Text[count];
                    count++;
                } while (count < tbResult.Text.Length);

                tbResult.Text = "";
            }
            tbValues.Text += "-";
        }

        protected void ButtonPercent_Click(object sender, EventArgs e)
        {
            if (checkValueChar() == true)
            {
                return;
            }

            if (tbResult.Text.Length > 0)
            {
                tbValues.Text = "";
                int count = 1;
                do
                {
                    tbValues.Text += tbResult.Text[count];
                    count++;
                } while (count < tbResult.Text.Length);

                tbResult.Text = "";
            }
            tbValues.Text += "%";
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (checkValueChar() == true)
            {
                return;
            }

            if (tbResult.Text.Length > 0)
            {
                tbValues.Text = "";
                int count = 1;
                do
                {
                    tbValues.Text += tbResult.Text[count];
                    count++;
                } while (count < tbResult.Text.Length);

                tbResult.Text = "";
            }
            tbValues.Text += "/";
        }

        protected void ButtonD_Click(object sender, EventArgs e)
        {
            if (checkValueChar() == true)
            {
                return;
            }

            if (tbValues.Text.Length == 0)
            {
                tbValues.Text += "0,";
                return;
            }
            int count = 0;
           bool isComma = false;
            while (count < tbValues.Text.Length && (tbValues.Text[count] != '+' || tbValues.Text[count] != '-'
                || tbValues.Text[count] != '*' || tbValues.Text[count] != '/' || tbValues.Text[count] != '%'))
            {

               
               if (tbValues.Text[count] == ',')
                {
                    isComma = true;
                }
                

                if (isComma == false && count == tbValues.Text.Length - 1)
                {

                    tbValues.Text += ",";
                    return;
                }
                count++;
            }
               if ((tbValues.Text[tbValues.Text.Length-1] == '+' || tbValues.Text[tbValues.Text.Length-1] == '-' 
                    || tbValues.Text[tbValues.Text.Length-1] == '*' || tbValues.Text[tbValues.Text.Length-1] == '/' ||
                    tbValues.Text[tbValues.Text.Length-1] == '%') && (tbValues.Text[tbValues.Text.Length - 1] != ',' || tbValues.Text[tbValues.Text.Length - 2] != ','))
                {
                    tbValues.Text += "0,";
                return;
                }

               
                if (tbValues.Text.Length>0 && tbValues.Text[tbValues.Text.Length - 1] != ',')
                {
                tbValues.Text += ",";
                return;
                }
                
        }

        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            int count = 0;
            string value1=null, value2=null;
            string operationChar=null;
            bool findChar = false;

            if (tbValues.Text.Length == 0)
            {
                tbValues.Text = "0";
                return;
            }

            else
                try
                {
                    do
                    {


                        if (tbValues.Text[count] == ('+'))
                        {
                            operationChar = "+";
                            findChar = true;
                            break;
                        }

                        if (tbValues.Text[count] == ('-'))
                        {
                            operationChar = "-";
                            findChar = true;
                            break;
                        }

                        if (tbValues.Text[count] == ('*'))
                        {
                            operationChar = "*";
                            findChar = true;
                            break;
                        }

                        if (tbValues.Text[count] == ('/'))
                        {
                            operationChar = "/";
                            findChar = true;
                            break;
                        }

                        if (tbValues.Text[count] == ('%'))
                        {
                            operationChar = "%";
                            findChar = true;
                            break;

                        }
                        value1 += tbValues.Text[count];
                        count++;

                    } while ((findChar != true));

                }
                catch
                {
                    tbValues.Text = "ERROR";
                }
            count++;
            try
            {
                do
                {
                    value2 += tbValues.Text[count];
                    count++;
                } while (count < tbValues.Text.Length);
            }
            catch
            {
                tbValues.Text += "";
                tbResult.Text += "";
            }

            if ((Calculate(value1, value2, operationChar)).ToString() == "0")
            {
                tbValues.Text = "";
                tbResult.Text = ("Niedozwolona operacja!");
                return;
            }
            else
            {
                tbResult.Text = "=" + (Calculate(value1, value2, operationChar)).ToString();
            }

        }

        protected double Calculate (string val1, string val2, string Char)
        {
            double result=0;
            try
            {
                if (Char == "+")
                    return result = double.Parse(val1) + double.Parse(val2);

                if (Char == "-")
                    return result = double.Parse(val1) - double.Parse(val2);

                if (Char == "*")
                    return result = double.Parse(val1) * double.Parse(val2);

                if (Char == "/" && val2 != "0")
                    return result = double.Parse(val1) / double.Parse(val2);

                if (Char == "%")
                    return result = double.Parse(val1) % double.Parse(val2);
            }
            catch
            {
                tbValues.Text = "ERROR";
            }

            return 0;
            

           
            
            
        }

        protected void ButtonRad_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbResult.Text.Length == 0)
                    tbResult.Text = "=" + Math.Sqrt(double.Parse(tbValues.Text)).ToString();
                else
                {
                    char[] OperationsChars = { '=', '+', '-', '*', '/', '%' };

                    string result = tbResult.Text.TrimStart(OperationsChars);
                    tbValues.Text = tbResult.Text.TrimStart(OperationsChars);
                    tbResult.Text = "=" + Math.Sqrt(double.Parse(result)).ToString();
                }
            }
            catch
            {
                tbResult.Text = "";
                tbValues.Text = "";
            }

        }

        protected bool checkValueChar ()
        {
            try
            {
                if (tbValues.Text[tbValues.Text.Length - 1] == '+' || tbValues.Text[tbValues.Text.Length - 1] == '*' || tbValues.Text[tbValues.Text.Length - 1] == '/'
                    || tbValues.Text[tbValues.Text.Length - 1] == '-' || tbValues.Text[tbValues.Text.Length - 1] == '%')
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        protected void ButtonPower_Click(object sender, EventArgs e)
        {
            try
            {
                if (emptyValues() == false)
                {

                    tbValues.Text = Math.Pow(double.Parse(tbResult.Text), 2).ToString();
                    tbResult.Text = "";
                }
                else
                {
                    double x = double.Parse(tbValues.Text);
                    tbValues.Text = "";
                    tbResult.Text = Math.Pow(x, 2).ToString();
                }
            }
            catch
            {
                tbValues.Text = "";
                tbResult.Text = "";
            }

        }

       

        protected void ButtonMul_Click(object sender, EventArgs e)
        {
            if (checkValueChar() == true)
            {
                return;
            }

            if (tbResult.Text.Length > 0)
            {
                tbValues.Text = "";
                int count = 1;
                do
                {
                    tbValues.Text += tbResult.Text[count];
                    count++;
                } while (count < tbResult.Text.Length);

                tbResult.Text = "";
            }
            tbValues.Text += "*";
        }
        protected bool emptyValues ()
        {
            if (tbResult.Text.Length > 0)
                return false;

            return true;
        }
        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            tbValues.Text = "";
            tbResult.Text = "";
        }
    }
}