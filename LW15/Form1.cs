using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LW15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOK.Text = "OK";
            lblResult.Text = "";

            btnOK2.Text = "OK";
            lblResult2.Text = "";

            btnOK3.Text = "True or False?";
            lblResult3.Text= "";

            btnOK4.Text = "Check the answer";
            lblResult4.Text = "";

            btnOK5.Text = "Check the answer";
            lblResult5.Text = "";

            btnOK6.Text = "Change the element";
            lblResult6.Text = "";

            btnOK7.Text = "Isolate";
            lblResult7.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double result = (1+Math.Sin(Math.Sqrt(x+1)))/(Math.Cos(12*y-4));
            lblResult.Text = result.ToString();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtY.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtX1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double y1 = Convert.ToDouble(txtY1.Text);
            double y2 = Convert.ToDouble(txtY2.Text);
            double result2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            lblResult2.Text = result2.ToString();
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtX1.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtY1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtY1.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtX2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtY2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtY2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtC.Text);
            double d = Convert.ToDouble(txtD.Text);
            double a = Convert.ToDouble(txtA.Text);
            double result3a = a * a;
            double result3b = a * a * a;
            if (c==result3a && d==result3b)
            {
                lblResult3.Text = "True";
            }
            else
            {
                lblResult3.Text = "False";
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtC.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK3.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtD.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtD.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK3.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtA.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtA.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK3.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            double ax1 = Convert.ToDouble(txtAx1.Text);
            double ay1 = Convert.ToDouble(txtAy1.Text);
            double bx2 = Convert.ToDouble(txtBx2.Text);
            double by2 = Convert.ToDouble(txtBy2.Text);
            double cx3 = Convert.ToDouble(txtCx3.Text);
            double cy3 = Convert.ToDouble(txtCy3.Text);
            double result4 = (0.5)*((bx2-ax1)*(cy3-ay1)-(cx3-ax1)*(by2-ay1));
            if (result4 >= 0 && result4 < 0.000000001)
            {
                lblResult4.Text = "Points are located on the same line";
            }
            else
            {
                lblResult4.Text = "Points are not located on the same line, S of triangle = " + result4.ToString();
            }
        }

        private void txtAx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtAx1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtAx1.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtAy1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtAy1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtAy1.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtBx2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtBx2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtBy2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtBy2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtBy2.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtCx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtCx3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtCx3.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtCy3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtCy3.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtCy3.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK4.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            string s = txtArray.Text;
            string[] subs = s.Split(' ');

            List<double> l = new List<double>();
            foreach (string ss in subs)
            {
                l.Add(float.Parse(ss));
            }

            double m = double.MinValue;
            int mi = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > m)
                {
                    m = l[i];
                    mi = i;
                }
            }
            l[mi] = 0;

            lblResult6.Text = String.Join(" ", l.ToArray());
        }

        private void txtArray_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if (e.KeyChar == ' ')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK6.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            string s = txtCharS.Text;
            int a = s.IndexOf('(');
            int b = s.IndexOf(')');

            string result7 = s.Substring(a, b - a + 1);
            lblResult7.Text = result7;
        }
    }
}