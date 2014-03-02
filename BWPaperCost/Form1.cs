using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BWPaperCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float ClampFontSize(float value)
        {
            value = Math.Max(value, 2);
            value = Math.Min(value, 128);
            return value;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            /*string inputString = "";

            for (int i = 0; i < txtBoxInput.Text.Length; i++)
            {
                char c = txtBoxInput.Text[i];

                if (char.IsLetter(c))
                    inputString += c;
            }

            inputString = inputString.ToLower();
            

            if (inputString.Contains("clear"))
            {
                txtBoxInput.Clear();
                btnClear_Click(null, null);
                return;
            }
            if (inputString.Contains("quit") || inputString.Contains("exit"))
            {
                btnExit_Click(null, null);
            }*/

            string inputString = txtBoxInput.Text.ToLower();

            if (inputString.Contains('c') && inputString.Contains('l') && 
                inputString.Contains('e') && inputString.Contains('a') && 
                inputString.Contains('r'))
            {
                txtBoxInput.Clear();
                btnClear_Click(null, null);
                return;
            }
            if ((inputString.Contains('q') && inputString.Contains('u') && inputString.Contains('i') && inputString.Contains('t'))
                || (inputString.Contains('e') && inputString.Contains('x') && inputString.Contains('i') && inputString.Contains('t')))
            {
                btnExit_Click(null, null);
                return;
            }

            inputString = "";

            for (int i = 0; i < txtBoxInput.Text.Length; i++)
            {
                char c = txtBoxInput.Text[i];

                if (char.IsDigit(c))
                    inputString += c;
            }
            
            if (inputString == "")
            {
                txtBoxInput.Clear();
                return;
            }

            int input;
            try
            {
                input = int.Parse(inputString);
            }
            catch (Exception)
            {
                txtBoxInput.Clear();
                return;
            }

            txtBoxInput.Clear();
            
            txtBoxResult.AppendText("\r\n" + input + ": " + (input * .05).ToString("C"));

            txtBoxInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDecreaseFontSize_Click(object sender, EventArgs e)
        {
            txtBoxResult.Font = new Font(FontFamily.GenericSansSerif, ClampFontSize(txtBoxResult.Font.Size - 2), txtBoxResult.Font.Style);
            txtBoxInput.Focus();
        }

        private void btnIncreaseFontSize_Click(object sender, EventArgs e)
        {
            txtBoxResult.Font = new Font(FontFamily.GenericSansSerif, ClampFontSize(txtBoxResult.Font.Size + 2), txtBoxResult.Font.Style);
            txtBoxInput.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
            txtBoxInput.Focus();
        }

        private void txtBoxResult_Click(object sender, EventArgs e)
        {
            txtBoxInput.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                btnDecreaseFontSize_Click(null, null);
            }
            if (e.KeyChar == '=')
            {
                btnIncreaseFontSize_Click(null, null);
            }
        }

        private void txtBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                btnDecreaseFontSize_Click(null, null);
                e.Handled = true;
            }
            if (e.KeyChar == '=')
            {
                btnIncreaseFontSize_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
