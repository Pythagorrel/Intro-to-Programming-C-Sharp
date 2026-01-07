using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double op1, op2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(opBox1.Text);
            op2 = Convert.ToDouble(opBox2.Text);

            if(opBox.Text=="+")

            {   result = op1 + op2;
            
            }

            else if(opBox.Text =="-")

            {   result = op1 - op2; 
            
            }

            else if(opBox.Text=="*")
            {   
                result = op1 * op2; 
            }

            else if(opBox.Text=="/")
            {   
                result = op1 / op2;
            
            }
            else
            { //if (
                    MessageBox.Show("Error!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   // == DialogResult.OK)
                    //Application.Exit();
            }
            resBox.Text = Convert.ToString(result);
        }
    }
}
