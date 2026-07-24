using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week05Day04ModalModelessDialogs
{
    public partial class ModalDialogUserForm : Form
    {
        public ModalDialogUserForm()
        {
            InitializeComponent();
            UI_Tbx_InputUsername.Text = "Simran";
        }

        private void UI_Btn_Ok_Click(object sender, EventArgs e)
        {   // this will cause the form to close and return the value to called
            // value DialogResult.OK will returned to caller
            // You can use that value in the called method to decide 

            DialogResult = DialogResult.OK;

        }

        private void UI_Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        public string getUserName()
        {
            Console.WriteLine($"Inside getUserName {UI_Tbx_InputUsername.Text}");
            return UI_Tbx_InputUsername.Text;
        }

    }
}
