using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_4U0_Lesson_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //txtLineLength is disabled
            txtLineLength.Enabled = false;
            //rttMidpoint is disabled 
            rttMidpoint.Enabled = false;
            //rttLinear is disabled
            rttLinear.Enabled = false;
        }

        public void Clear()
        {
            //Point inputs are cleared 
            txtPoint1x.Clear();
            txtPoint1y.Clear();
            txtPoint2x.Clear();
            txtPoint2y.Clear();

            //Output textboxes are cleared 
            rttLinear.Clear();
            txtLineLength.Clear();
            rttMidpoint.Clear();
            //txtPoint1x is focused 
            txtPoint1x.Focus();
        }

        //Struct Points is defined 
        public struct Points
        {
            public int x;
            public int y;
        }

        int GreatestCommonDenominator(int iNumeratorValue, int iDenominatorValue)
        {
            iNumeratorValue = Math.Abs(iNumeratorValue);
            iDenominatorValue = Math.Abs(iDenominatorValue);

            //This for loops loops through all the numbers between 1 and the smaller number of the numerator and denominator
            for (int i = Math.Min(iNumeratorValue, iDenominatorValue); i > 1; i--)
            {
                //Finds value that is divisible by the numerator and the denominator 
                if (iNumeratorValue % i == 0 && iDenominatorValue % i == 0)
                {// value i becomes the greatest factor
                    return i;
                }
            }
            ///1 is return when no value is found 
            return 1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                //If the input is not empty
                if ((txtPoint1x.Text != "") && (txtPoint1y.Text != "") && (txtPoint2x.Text != "") && (txtPoint2y.Text != ""))
                {
                    //Declare variables of type Points
                    Points Point1, Point2;

                    //Converts txtPoint1x to int32
                    Point1.x = Int32.Parse(txtPoint1x.Text);
                    //Converts txtPoint1y to int32
                    Point1.y = Int32.Parse(txtPoint1y.Text);
                    //Converts txtPoint2x to int32
                    Point2.x = Int32.Parse(txtPoint2x.Text);
                    //Converts txtPoint2y to int32
                    Point2.y = Int32.Parse(txtPoint2y.Text);

                    //Integer variables are declared
                    int islopexvalue = Point2.x - Point1.x,
                        islopeyvalue = Point2.y - Point1.y,
                        iGreatestCommonFactor;

                    //String variables are declared
                    string strslopedash, strbdashnumvalue;
                    //Declared variables are given temporary variables
                    strslopedash = "";
                    strbdashnumvalue = ""; 

                    //If the length of the numerator of the slope is greater than the denominator's
                    if (islopeyvalue.ToString().Length >= islopexvalue.ToString().Length)
                    {
                         strslopedash = new string('-', islopeyvalue.ToString().Length * 2 + 2); 
                         
                         //If the length of the numerator of the b value is greater than the denominator's
                         if (((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length >= islopexvalue.ToString().Length)
                         {
                            strbdashnumvalue = new string('-', ((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length * 2 + 2);
                         }

                         //If the length of the numerator of the b value is less than the denominator's
                         else if (((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length < islopexvalue.ToString().Length)
                         {
                            strbdashnumvalue = new string('-', islopexvalue.ToString().Length * 2 + 2);
                         } 
                    }

                    //If the length of the numerator of the slope is less than the denominator's
                    else if (islopeyvalue.ToString().Length < islopexvalue.ToString().Length)
                    {
                         strslopedash = new string('-', islopexvalue.ToString().Length * 2 + 2);

                         //If the length of the numerator of the b value is greater than the denominator's
                         if (((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length >= islopexvalue.ToString().Length)
                         {
                             strbdashnumvalue = new string('-', ((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length * 2 + 2);
                         }

                         //If the length of the numerator of the b value is less than the denominator's
                         else if (((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)).ToString().Length < islopexvalue.ToString().Length)
                         {
                             strbdashnumvalue = new string('-', islopexvalue.ToString().Length * 2 + 2);
                         } 
                    }

                    //The numerator of the slope if the slope is a fraction is converted to a string
                    string strslopenumerator = (/*Denominator of slope*/Point2.x - Point1.x).ToString();
                    //A reasonable number of spaces is inserted depending on the pattern: 6 spaces plus the length of the denominator of the slope if the slope is a fraction 
                    string strspace = new string(' ', strslopenumerator.Length + 9);

                    //Integer variables are declared and assigned 
                    int ixvaluesum = Point1.x + Point2.x;
                    int iyvaluesum = Point1.y + Point2.y;

                    //string strMidpointdashx and strMidpointdashy are lines of dashes
                    //number of dashes is based on the number of digits in the numerator of the x value of the midpoint times 2, 2 dashes are added due to formatting
                    //following is saved as a string 
                    string strMidpointdashx = new string('-', ixvaluesum.ToString().Length * 2 + 2);
                    //number of dashes is based on the number of digits in the numerator of the y value of the midpoint times 2, 2 dashes are added due to formatting
                    //following is saved as a string 
                    string strMidpointdashy = new string('-', iyvaluesum.ToString().Length * 2 + 2);

                    //spacing is based on the number of digits in the numerator of the x value of the midpoint subtracted by 1
                    //following is saved as a string 
                    string strMidpointspacedenomx = new string(' ', ixvaluesum.ToString().Length - 1);
                    //spacing is based on the number of digits in the numerator of the y value of the midpoint subtracted by 1
                    //following is saved as a string 
                    string strMidpointspacedenomy = new string(' ', iyvaluesum.ToString().Length - 1);

                    // integral variable is declared
                    //This variable will determine the number of spaces between the numerator of the x value or the midpoint and the denominator 
                    int iMidpointspacenum;

                    // iMidpointspacenum is given a temporary variable of 3
                    iMidpointspacenum = 3;

                    // if the both numerators of the x and y value of the midpount is greater than zero 
                    if ((ixvaluesum > 0) && (iyvaluesum > 0))
                        iMidpointspacenum = 3;

                    //if the numerator of the x value is greater than zero and the numertor of the y value is less than zero or vice versa 
                    else if (((ixvaluesum > 0) && (iyvaluesum < 0)) || ((ixvaluesum < 0) && (iyvaluesum > 0)))
                        iMidpointspacenum = 4;

                    // if the both numerators of the x and y value of the midpount is less than zero 
                    else if ((ixvaluesum < 0) && (iyvaluesum < 0))
                        iMidpointspacenum = 5;

                    //spacing is based on the variable iMidpointspacenum 
                    //following is saved as a string   
                    string strMidpointspacenum = new string(' ', iMidpointspacenum);
                    

                    string strMidpointxevenyodd = new string(' ', ixvaluesum.ToString().Length * 2); 

                    //If the x and the y value of the midpoint is odd. 
                    if ((ixvaluesum % 2 != 0) && (iyvaluesum % 2 != 0))
                    {
                        rttMidpoint.Text = /*Line 1*/ "  " + ixvaluesum + "   " + iyvaluesum + "\n" +
                                           /*Line 2*/ "(" + strMidpointdashx + "," + strMidpointdashy + ")" + "\n" +
                                           /*Line 3*/ "  " + strMidpointspacedenomx + "2" + strMidpointspacedenomx + "   " + strMidpointspacedenomy + "2";
                    }

                    //If the x and the y value of the midpoint is even 
                    else if ((ixvaluesum % 2 == 0) && (iyvaluesum % 2 == 0))
                    {
                        rttMidpoint.Text = "(" + (ixvaluesum / 2) + "," + (iyvaluesum / 2) + ")";
                    }

                    //If the x value is odd and the y value is even 
                    else if ((ixvaluesum % 2 != 0) && (iyvaluesum % 2 == 0))
                    {
                        rttMidpoint.Text = /*Line 1*/ "  " + ixvaluesum + "\n" +
                                           /*Line 2*/ "(" + strMidpointdashx + "," + iyvaluesum /2 + ")" + "\n" +
                                           /*Line 3*/ "  " + strMidpointspacedenomx + "2";
                    }

                       
                    
                    //If the x value is even and the y value is odd 
                    else if ((ixvaluesum % 2 == 0) && (iyvaluesum % 2 != 0))
                    {
                        rttMidpoint.Text = /*Line 1*/ "  " + strMidpointxevenyodd + " " + iyvaluesum + "\n" +
                                           /*Line 2*/ "(" + ixvaluesum / 2 +  "," + strMidpointdashy + ")" + "\n" +
                                           /*Line 3*/ "  " + strMidpointxevenyodd + " " + strMidpointspacedenomy + "2";
                    }

                    //Line length is calculated and rounded to 3 decimal places
                    double dlinelength = Math.Round((Math.Sqrt(islopexvalue ^ 2 + islopeyvalue ^ 2)), 3);
                    //dlinelength is converted to a string and displayed to the user
                    txtLineLength.Text = dlinelength + " unit(s)";

                    //Equation of the line calculations 
                    //If the denominator of the slope is a zero
                    if (Point2.x - Point1.x == 0)
                    {
                        //Then linear equation is x = b
                        rttLinear.Text = "x = " + Point1.x;
                        return;
                    }

                    //Following is in respect to the linear model y=mx+b
                    if (/*If the denominator of the slope is not a multiple of the numerator*/((/*Numerator of slope*/Point2.y - Point1.y) % (/*Denominator of slope*/Point2.x - Point1.x) != 0))
                    {

                        iGreatestCommonFactor = GreatestCommonDenominator(islopeyvalue, islopexvalue);
                        islopeyvalue /= iGreatestCommonFactor;
                        islopexvalue /= iGreatestCommonFactor;

                         //If b from y = mx + b is a fraction 
                        if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) % (/*Denominator of slope*/Point2.x - Point1.x) != 0))
                        {
                            if ((islopeyvalue < 0) && (islopexvalue < 0) || (islopeyvalue > 0) && (islopexvalue < 0))
                            {
                                //Both the numerator and the denominator are multiplied by -1 
                                islopeyvalue = islopeyvalue * -1;
                                islopexvalue = islopexvalue * -1;
                            }

                            rttLinear.Text = /*Line 1*/ "      " + islopeyvalue + strspace + ((Point1.y * islopexvalue) - (Point1.x * islopeyvalue)) + "\n" 
                                             /*Line 2*/ + "y = " + strslopedash + " x + " + strbdashnumvalue + "\n" 
                                             /*Line 3*/ + "      " + islopexvalue + strspace + islopexvalue;

                            
                        }

                        //If b from y = mx + b is not a fraction 
                        else if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) % (/*Denominator of slope*/Point2.x - Point1.x) == 0))
                        {
                            if ((islopeyvalue < 0) && (islopexvalue < 0) || (islopeyvalue > 0) && (islopexvalue < 0))
                            {
                                //Both the numerator and the denominator are multiplied by -1 
                                islopeyvalue = islopeyvalue * -1;
                                islopexvalue = islopexvalue * -1;
                            }

                            rttLinear.Text = /*Line 1*/ "      " + islopeyvalue + strspace + "\n" 
                                             /*Line 2*/ + "y = " + strslopedash + " x + " + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))) + "\n" 
                                             /*Line 3*/ + "      " + islopexvalue;
                        }
                    }

                    else if (/*If the denominator of the slope is a multiple of the numerator*/((/*Numerator of slope*/Point2.y - Point1.y) % (/*Denominator of slope*/Point2.x - Point1.x) == 0))
                    {
                        //If b from y = mx+b is a negative 
                        if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x) < 0))
                        {
                            rttLinear.Text = ("y = " + (((/*Numerator of slope*/Point2.y - Point1.y) / (/*Denominator of slope*/Point2.x - Point1.x))) + "x + " + "(" + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))) + ")");
                        }

                        //If b from y = mx+b is a positive
                        if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x) > 0))
                        {
                            rttLinear.Text = /*Line 1*/ "y = " + (((/*Numerator of slope*/Point2.y - Point1.y) / (/*Denominator of slope*/Point2.x - Point1.x))) + "x + " + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x)));
                        }

                        //If b from y = mx + b is 0
                        if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x)) == 0)
                        {
                            rttLinear.Text = /*Line 1*/ "y = " + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x)));
                        }

                        //If the slope is 1 
                        else if ((/*Numerator of slope*/Point2.y - Point1.y) / (/*Denominator of slope*/Point2.x - Point1.x) == 1)
                        {
                            rttLinear.Text = ("y = x + " + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))));

                            //If b from y = mx+b is a negative 
                            if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x) < 0))
                            {

                                rttLinear.Text = ("y = x + " + "(" + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))) + ")");
                            }
                        }

                        //If the slope is -1 
                        else if ((/*Numerator of slope*/Point2.y - Point1.y) / (/*Denominator of slope*/Point2.x - Point1.x) == -1)
                        {
                            rttLinear.Text = ("y = -x + " + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))));

                            //If b from y = mx+b is a negative 
                            if (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x) < 0))
                            {
                                rttLinear.Text = ("y = -x + " + "(" + (((Point1.y * (/*Denominator of slope*/Point2.x - Point1.x)) - (Point1.x * (/*Numerator of slope*/Point2.y - Point1.y)) / (/*Denominator of slope*/Point2.x - Point1.x))) + ")");
                            }
                        }

                        //If the slope is zero
                        else if (Point2.y - Point1.y == 0)
                        {
                            rttLinear.Text = "y = " + Point1.y;
                        }
                    }
                }

                else
                {
                    //Messagebox is displayed when the input is empty 
                    MessageBox.Show("Input error detected. Please assure that all inputs are not empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            catch
            {

                //Messagebox is displayed when the input contains letters or symbols 
                MessageBox.Show("Input error detected. Please assure that all inputs only contain digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the program 
            Application.Exit();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messagebox is displayed advising the user on how to pilot the program 
            MessageBox.Show("Hello user! Welcome to Linear Equation Calculator, to pilot the program please review the following instructions." + "\n" + "" + "\n" + "1. Enter two coordinates." + "\n" + "" + "\n" + "2. Click to button named CALCULATE to determine the linear equation that intersects the two points, the midpoint, and the length between the two points." + "\n" + "" + "\n" + "3. Click the button named CLEAR to clear all or the tab named EXIT under FILE to exit the program." + "\n" + "" + "\n" + "Enjoy!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

