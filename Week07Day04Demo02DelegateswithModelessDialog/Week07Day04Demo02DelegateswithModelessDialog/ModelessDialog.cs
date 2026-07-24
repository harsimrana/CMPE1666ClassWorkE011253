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
{  // Delegate for sending notifications to the main form
    public delegate void delVoidString(string s);

    public delegate void delVoidVoid();

    public partial class ModelessDialog : Form
    {
        // Delegate reference will contain the callback function

        public delVoidString _dTextChanged = null;

        public delVoidVoid _dFormClosing = null;

        public ModelessDialog()
        {
            InitializeComponent();
        }

        private void UI_Input_Tbx_TextChanged(object sender, EventArgs e)
        {
            // When the text will be changed in the textbox, the callback method will be
            // called to update the label on the main form
            // making sure object is not null
            if (_dTextChanged != null)
            {   // shortcut to call callback method
                _dTextChanged(UI_Input_Tbx.Text);
            }
        }

        private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {  /* usually x button will normally close the dialog and 
            * dispose off it from memory
            * here we just want to hide it instead of closing it
            * so we will try to intercept the form closing event,
            * check the reason, and override the close one with hide
            * Dialog being closed by user? Then do not close it, hide it
            */
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_dFormClosing != null)
                {
                    _dFormClosing();
                    // calling the callback function in Main form
                }
                
                // stop the close from happening
                e.Cancel = true;

                // hide the dialog
                Hide();
            }

        }
    }
}
