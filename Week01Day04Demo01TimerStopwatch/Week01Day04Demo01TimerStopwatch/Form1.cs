using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01Day04Demo01TimerStopwatch
{
    public partial class TimerStopWatch : Form
    {
        // Count variable to track timer

        int count = 0;

        Stopwatch myStopWatch = new Stopwatch();
        public TimerStopWatch()
        {
            InitializeComponent();

            UI_Timer1.Enabled = true; // it will start your timer
        }

        private void UI_Timer1_Tick(object sender, EventArgs e)
        {
            // Simple message in outpur window
            System.Diagnostics.Trace.WriteLine("Message from Timer");

            // increase the count and display the value on label

            count++;

            //if(count ==10)
            //{
            //    UI_Timer1.Enabled = false;
            //}
            // Update your label
            // Text property is expecting a string value 
            //UI_Screen_Lbl.Text = count.ToString();

            UI_Screen_Lbl.Text = $" Count: {count}"; 

            // Display number milliseconds elapsed/ passed in a textbox
            // ElapsedMilliseconds of stopwatch object will give you that number

            UI_Time_Tbx.Text = myStopWatch.ElapsedMilliseconds.ToString();

            // If count variable reaches a multiple of 3 the value is added to the list

            if (count % 3 == 0)
            {
                // Adding the value of count to list items based on a condition
                UI_List_Lbx.Items.Add(count); 
            }

        }

        private void TimerStopWatch_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("Inside form load");

            // Start your stopwatch
            myStopWatch.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            // stop my stopwatch 

            myStopWatch.Stop();

            // Disable the timer by changing the Enabled property to false
            UI_Timer1.Enabled = false;

            // Clear list items - Remove all items from the list

            //UI_List_Lbx.Items.Clear();
            //UI_List_Lbx.Items.Remove(3); // It will remove item with value 3
            UI_List_Lbx.Items.RemoveAt(1); // Index starts from 0 

            // RemoveAt()- will remove an item at a specific index position
            // Remove() -  will remove item from the list
        }
    }
}
