using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Day04Demo02DelegateswithModelessDialog
{
    public partial class Form1 : Form
    {
        ModelessDialog dlg = null;

        /* MAIN Plan
         * -- Main Form 
         * -- Modeless Dialog Form
         * -- checkbox Main Form: checkk will open the modeless Dialog
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        //When the checkbox is checked for the firts time,
        // the modeless dialog is created and shown 
        // Subsequently, when the checkbox is unchecked  the dialog is hidden
        private void UI_Show_Dialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Show_Dialog_Cbx.Checked)
            {

                if (dlg == null)
                {
                    dlg = new ModelessDialog();
                    dlg._dTextChanged = CallBackTextChanged;
                    dlg._dFormClosing = CallBackFormClosing;
                }
                //dlg.ShowDialog();  // Modal
                dlg.Show(); // Modeless one
                
            }
            else
            {
                dlg.Hide();
            }
        }

        private void CallBackTextChanged(string str)
        { 
            UI_Output_Lbl.Text = str;
        }

        private void CallBackFormClosing()
        { 
           UI_Show_Dialog_Cbx.Checked = false;

            UI_Output_Lbl.Text = String.Empty;           
        }
    }
}
