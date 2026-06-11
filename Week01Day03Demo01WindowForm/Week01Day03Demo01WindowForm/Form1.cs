using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01Day03Demo01WindowForm
{
    public partial class UI_Form_Form1 : Form
    {
        public UI_Form_Form1()
        {
            InitializeComponent();
        }

        private void UI_Form_Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form has been loaded");
        }

        private void UI_Form_Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form is shown on the screen");

        }

        private void UI_Form_Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Paint event occurrued");
        }

        private void UI_Form_Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"Form is closing Reason of closing {e.CloseReason}" );
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Preventing the user from closing the form
                //e.Cancel = true;
            }

        }

        private void UI_Form_Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Form has been closed");
        }

        private void UI_Form_Form1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            // change the title for the fom
            Text = "Mouse is hovering over the form";
        }

        private void UI_Form_Form1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            Text = "Mouse has left";
        }

        private void UI_Login_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Transfer Text button clicked");
            // changing the title of the form
            //this.Text = "Login Form";
            UI_Login_btn.BackColor = Color.Green;

            /* Take the text from Text Box and show it on label 
             * Then, empty your text box
             */

            if (UI_Input_Tbx.Text.ToString().Length > 0)
            {
                UI_Input_Tbx.ForeColor = Color.White;
                UI_Input_Tbx.BackColor = Color.Green;
                // Transfering text to label
                UI_Display_Lbl.Text = UI_Input_Tbx.Text;
                // Making text box empty
                UI_Input_Tbx.Text = String.Empty; // or "" empty string
            }
            else
            {
                // TO TEST THIS UNCOMMENT THIS FOLLOWING
                /*
                UI_Input_Tbx.ForeColor = Color.White;
                UI_Input_Tbx.BackColor = Color.Red;

                // Give a warning message
                UI_Input_Tbx.Text = " You cannot leave it empty";
                */

                // Give a pop up message for warning
                // MessageBox is not a control, it is used to display error/warning messages to user 
                
                MessageBox.Show(" You cannot leave text box empty");
            }
        }

        private void UI_Sum_Btn_Click(object sender, EventArgs e)
        {
            // Grab text from textbox 1 and textbox 2
            // Perform addition
            // Show the result on the screen

            int numb1, numb2, sum;

            if (UI_Input1_Tbx.Text.Length > 0 && UI_Input2_Tbx.Text.Length > 0)
            {
                int.TryParse(UI_Input1_Tbx.Text, out numb1);
                int.TryParse(UI_Input2_Tbx.Text, out numb2);

                sum = numb1 + numb2;

                UI_Screen_Lbl.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Please provide both values");
            }
        }
    }
}
