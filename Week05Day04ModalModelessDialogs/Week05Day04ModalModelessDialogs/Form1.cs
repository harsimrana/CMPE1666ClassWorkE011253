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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /* Modal Dialogs: Used to gather data from user
        * 
        * Modal and Modeless
        * Modal: steals the focus from main form until user is going to perform some actions: clicking any button
        * Modeless: stays on the screen and allows the main form to retain the focus
        * 
        */

        /* We can creat our own Modal or modeless one as well
         * How??
         * Project - Add New Item -> Windows Form - Forms window Forms
         * 
         */
        private void UI_Btn_Message_Click(object sender, EventArgs e)
        {
            // Message                , Caption       Buttons
            //MessageBox.Show("Button has been clicked", "Display Box", MessageBoxButtons.YesNoCancel);
            // Instead of using MessageBox, I want to open my own ModalDialogUserName
            //

            // Create an object of our ModalDialogUserName
            ModalDialogUserForm dialog = new ModalDialogUserForm();

            //dialog.Show();  // ModeLess one

           // Console.WriteLine(dialog.Show());

            Console.WriteLine(dialog.getUserName());
            DialogResult result = dialog.ShowDialog();  // Modal one

            //if (result == DialogResult.OK)
            //{
            //    Console.WriteLine("OK button was pressed on Dialog");

            //    // Place your code here to handle the result from the dialog


            //    // It is not possible to target any control [properties/event] from
            //    // another class directly here

            //    //UI_Tbx_InputUsername.Text // NO

            //    //Console.WriteLine(dialog.UI_Tbx_InputUsername.Text);
            //    Console.WriteLine($"Inside Main Form {dialog.getUserName()}");

            //    string username = dialog.getUserName();
            //    //validation
            //    if (username.Length > 0)
            //    { 
            //        //Compare Username or anything else you want to do 


            //        // Practice Question
            //        // Grab Username and password -> compare it with any constant value
                    
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Dialog was closed with Cancel or X button");
            //}

        }
        
    }
}
