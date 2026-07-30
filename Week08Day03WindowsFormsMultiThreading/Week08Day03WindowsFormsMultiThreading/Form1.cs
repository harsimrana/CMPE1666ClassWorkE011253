using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08Day03WindowsFormsMultiThreading
{

    public partial class Form1 : Form
    {
        /* Generic delegate types
         *      : to avoid us the task of creating a new custom delegate type
         * Action :  zero or more input arguments and no output [returning nothing] 
         * 
         * Func   :  zero or more input arguments and one output argument [return type]     
         */

        // This is your own way of creating delegates
        // We will use some built in one today

        public delegate void delToAddToList(string str);
        
        Thread t1 = null, t2= null, t3=null;

        bool runThread = true; // Defined in the class to control thread

        // Struct
        struct Boundaries
        {
            public int Min;
            public int Max;

            public Boundaries(int minValue, int maxValue)
            {
                Min = minValue;
                Max = maxValue;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private int count = 0;
        private void UI_CountClick_btn_Click(object sender, EventArgs e)
        {
            UI_Count_lbl.Text = $"Button has been clicked {++count} times";
        }


        public void FindSine()
        {
            // Creating an Action delegate
            Action<string> delWriteSine = AddToListBox;

            for (int i = 0; i <= 180; i++)
            {
                double rad = Math.PI * i / 180;
                double sinValue = Math.Sin(rad);

                //UI_DisplayValues_lbx.Items.Add($"{i} degrees = {rad} = Sin = {sinValue} ");


                // You can note that trying to access the listbox from 
                // newly created thread causes an exception
                // To avoid that we can use DELEGATES

                //AddToListBox($"{i} degrees = {rad} = Sin = {sinValue} ");

                // use Invoke method to access AddToListBox from the form class
                string str = $"{i} degrees = {rad} = Sin = {sinValue} ";

                // Good practice to handle it nicely
                try
                {
                    Invoke(delWriteSine, str);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error  {e.Message}");
                }
                // NO NO NOOOOOO  WHY - you know that now
                //delWriteSine(str);

                Console.WriteLine($"{i} degrees = {rad} = Sin = {sinValue} ");
                Thread.Sleep(200);

            }
        }

        // Version 1 of FindSine

        // handing one value passed from thread

        public void FindSine1(object argument)
        {
            // Creating an Action delegate
            Action<string> delWriteSine = AddToListBox;

            if (argument is int MaxDegree)
            {
                // Also possible to unbox regular types
                //int maxDegree = (int) argument;

                for (int i = 0; i <= MaxDegree && runThread == true; i++)
                {

                    double rad = Math.PI * i / 180;
                    double sinValue = Math.Sin(rad);

                    //UI_DisplayValues_lbx.Items.Add($"{i} degrees = {rad} = Sin = {sinValue} ");


                    // You can note that trying to access the listbox from 
                    // newly created thread causes an exception
                    // To avoid that we can use DELEGATES

                    //AddToListBox($"{i} degrees = {rad} = Sin = {sinValue} ");

                    // use Invoke method to access AddToListBox from the form class
                    string str = $"{i} degrees = {rad} = Sin = {sinValue} ";

                    // Good practice to handle it nicely
                    try
                    {
                        Invoke(delWriteSine, str);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error  {e.Message}");
                    }
                    // NO NO NOOOOOO  WHY - you know that now
                    //delWriteSine(str);

                    Console.WriteLine($"{i} degrees = {rad} = Sin = {sinValue} ");
                    Thread.Sleep(50);

                }
            }
        }


        // Version 2 FindSine2
        // Handing struct passed from main form/thread
        public void FindSine2(object argument)
        {
            // Creating an Action delegate
            Action<string> delWriteSine = AddToListBox;

            if (argument is Boundaries)
            { // checking the value is of expected type

                // Unboxed the boundaries object
                Boundaries b2 = (Boundaries)argument;
                // Accessing the value of MIN member
                int x = b2.Min;


                for (int i = b2.Min; i <= b2.Max && runThread == true; i++)
                {

                    double rad = Math.PI * i / 180;
                    double sinValue = Math.Sin(rad);

                    //UI_DisplayValues_lbx.Items.Add($"{i} degrees = {rad} = Sin = {sinValue} ");


                    // You can note that trying to access the listbox from 
                    // newly created thread causes an exception
                    // To avoid that we can use DELEGATES

                    //AddToListBox($"{i} degrees = {rad} = Sin = {sinValue} ");

                    // use Invoke method to access AddToListBox from the form class
                    string str = $"{i} degrees = {rad} = Sin = {sinValue} ";

                    // Good practice to handle it nicely
                    try
                    {
                        Invoke(delWriteSine, str);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error  {e.Message}");
                    }
                    // NO NO NOOOOOO  WHY - you know that now
                    //delWriteSine(str);

                    Console.WriteLine($"{i} degrees = {rad} = Sin = {sinValue} ");
                    Thread.Sleep(50);

                }
            }
        }
        private void UI_PerformCal_btn_Click(object sender, EventArgs e)
        {
            // We will take benefit of Multithreading now here.
            //t1 = new Thread(FindSine);

            // t1 = new Thread(new ThreadStart(FindSine));
            // ThreadStart is present by default
            // By default all the threads run in foreground
            // YOu can change the thread to background by controlling isBackground property

            //t1.IsBackground = true;

            // Foreground vs background thread
            // FG threads keeps the main application running 
            // as long as it is active
            // BG thread is terminate automatically by CLR [Common Language Runtime]
            // the exact moment all FG threads finish executing

            // Using start theard start your thread
            //t1.Start();

            // UNCOMMENT THE FOLLOWING TO TEST ONE VALUE PASSING
            // Thead by passing one value from main thread
            //t2 = new Thread(new ParameterizedThreadStart( FindSine1));

            //runThread = true;
            //t2.Name = "FindSine(90)";

            //t2.Start(90);

            t3 = new Thread(new ParameterizedThreadStart(FindSine2));

            t3.Name = "FindSine2 handing struct";

            // Craete an object of Struct Type
            Boundaries b1 = new Boundaries(91, 180);

            t3.Start(b1);

            Console.WriteLine($" The thread is = {t3.ThreadState.ToString()}");

            // Thread states: running, stopped, suspended, aborted, bacground

            if (t3.ThreadState == ThreadState.Running)
            {
                Console.WriteLine($" Thread is running");
            }
            // This one will work like a single threaded application
            //FindSine();
        }

        private void UI_Stop_btn_Click(object sender, EventArgs e)
        {
            // Change the value of runThread to false to stop the thread

            runThread = false;

            Console.WriteLine($" THe thread is =  {t3.ThreadState.ToString()}");
        }

        public void AddToListBox(string str)
        {
            // Add the string to the list box
            UI_DisplayValues_lbx.Items.Add(str);
        }
    }
}
