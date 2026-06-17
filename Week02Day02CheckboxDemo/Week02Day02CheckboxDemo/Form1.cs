using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Day02CheckboxDemo
{
    public partial class Form1 : Form
    {
        double item1Cost = 0, item2Cost = 0;

        bool gstCheckBoxState;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_TotalCost_Btn_Click(object sender, EventArgs e)
        {
            // Checked property will provide the checked state of checkbox
            gstCheckBoxState = UI_GST_Cbx.Checked;
            System.Diagnostics.Trace.WriteLine($" GST checkbox state: {gstCheckBoxState}");

            item1Cost = ConvertToDouble(UI_Item1Cost_Tbx.Text);
            item2Cost = ConvertToDouble(UI_Item2Cost_Tbx.Text);

            if(item1Cost !=0 && item2Cost != 0)
            {
                CalculateTotalCost(item1Cost, item2Cost, gstCheckBoxState); 
            }
        }

        // function to calculate total
        public void CalculateTotalCost(double item1Cost, double item2Cost, bool IsGstRequired)
        {
            double sumOfItems = item1Cost + item2Cost;
            double gstCharged = sumOfItems * 0.05;

            sumOfItems = sumOfItems + (IsGstRequired == true ? gstCharged : 0);

            UI_TotalCost_Lbl.Text = $" Total Cost : { sumOfItems.ToString()}";

        }

        private void UI_GST_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            gstCheckBoxState = UI_GST_Cbx.Checked;
            CalculateTotalCost(item1Cost, item2Cost, gstCheckBoxState);
        }

        // Function to parse value to double
        public double ConvertToDouble(string value)
        {
            try
            {
                return double.Parse(value);
            }
            catch(Exception e)
            {
                MessageBox.Show("Not a valid value " + e.Message);
                return 0;
            }
        }
    }
}
