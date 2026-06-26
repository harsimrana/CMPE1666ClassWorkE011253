using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Week03Day04DragandDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Drag Enter event listener: To give user visually impression that this control
        // will accept drag and drop
        private void UI_DisplayData_Tbx_DragEnter(object sender, DragEventArgs e)
        {
            //e event data object
            //e.Data , e.Effect, e.x, e.Y
            //e.Data contains the actual data being dragged
            // GetDataPresent() checks whether a specific type of data exists inside e.Data
            //DataFormats.FileDrop means the dragged data should be in file-drop format
            if ( e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect= DragDropEffects.None;
            }

        }

        private void UI_DisplayData_Tbx_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //Getting the path of the file

                /*e.Data.GetData(DataFormats.FileDrop))
                 *  will return the file paths for files dropped by user
                 *  Why First() - It takes the first file path from the array
                 *  FirstorDefault() - gets the first item, but if the collection is empty. 
                 *  It returns null instead of error
                 *  Last() - Gets last item
                 */

                // UNCOMMENT THE FOLLOWING FOR MULTIPLE FILES
                //string[] filePaths = ((string[])e.Data.GetData(DataFormats.FileDrop));

                //foreach(string singlefilePath in filePaths)
                //    Console.WriteLine(singlefilePath);

                //
                string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop)).FirstOrDefault();

                Console.WriteLine(filePath);

                //UI_DisplayData_Tbx.Text = File.ReadAllText(filePath);

                string [] fileLines= File.ReadAllLines(filePath);

                foreach (string line in fileLines)
                {
                    UI_DisplayData_Tbx.Text += $"{line} \n";
                }


            }
            catch (Exception ex)
            { 
                Console.WriteLine(e.ToString());    
            }
        }
    }
}

// Important steps for Cheat Sheet
/* 1. AllowDrop property for the element on which you are dragging and dropping
 * 2. Event -  DragEnter :  give visual impression to user that you can drop the file here
 * 3. Event - DragDrop : main where you will actually read the data from the file(s)
 * 
 */
