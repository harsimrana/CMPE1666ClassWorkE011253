using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Day02RadioboxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Red_Rb.Checked)
            {
                UI_Color_Tbx.BackColor = Color.Red;
            }
            if (UI_Blue_Rb.Checked)
            {
                UI_Color_Tbx.BackColor = Color.Blue;
            }

        }


        // Instead of using separate event handlers for each radio button in a group
        // it is better we can use one event handler - Event Consolidation
        /*
        private void UI_Red_Rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UI_Blue_Rb_CheckedChanged(object sender, EventArgs e)
        {

        }
        */

        /* Radio button: One can be checked at a time
         * Checked property to know whether its checked or not
         * Event: CheckedChanged
         * Need to group under a groupbox-> containers
         * 
         */
    }
}
