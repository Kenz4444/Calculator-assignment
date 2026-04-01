using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_assignment
{
    public partial class simplecalculator : Form
    {
        double firstNumber;
        double secondNumber;
        double output;
        string operation;


        public simplecalculator()
        {
            InitializeComponent();
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
           
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = "+";
            lbloutput.Text = firstNumber + operation;
            txtinput.Clear();
            
            
        }

       

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = "-";
            lbloutput.Text = firstNumber + operation;
            txtinput.Clear();
        }


        private void btnmultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = "X";
            lbloutput.Text = firstNumber + operation;
            txtinput.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = "÷";
            lbloutput.Text = firstNumber + operation;
            txtinput.Clear();
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = "²";
            lbloutput.Text = firstNumber + operation;
            txtinput.Clear();
        }

        private void btnsquareroot_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtinput.Text);
            operation = " √";
            lbloutput.Text = operation + firstNumber;
            txtinput.Clear();
        }


        private void btnenter_Click(object sender, EventArgs e)
        {
            if (operation== "√" || operation== "²")
            {
                 
                lbloutput.Text = firstNumber + operation;
            }
            else
            {
                secondNumber = Convert.ToDouble(txtinput.Text);
                lbloutput.Text = firstNumber + operation + secondNumber;
                txtinput.Clear();
            }
                
            
            
            if (operation== "+")
            {
                lbloutput.Text = firstNumber + operation + secondNumber + " = " +(firstNumber +  secondNumber);
            }
            else if (operation == "-")
            {
                lbloutput.Text = firstNumber + operation + secondNumber + " = " + (firstNumber - secondNumber);
            }
            else if (operation == "X")
            {
                lbloutput.Text = firstNumber + operation + secondNumber + " = " + (firstNumber * secondNumber);
            }
            else if (operation == "÷")
            {
                lbloutput.Text = firstNumber + operation + secondNumber + " = " + (firstNumber / secondNumber);
            }
            else if (operation== "√")
            {
                lbloutput.Text = operation + firstNumber  + " = " + (Math.Sqrt(firstNumber));
            }
            
        }
    }
}
