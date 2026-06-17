using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week01Day04Demo02AnchoringList
{
    public partial class Form1 : Form
    {
        //Define struct to store student information

        public struct Student
        {
            public string StudentName;
            public double StudentMarks;
            public string StudentEmail;
            public int StudentAge;

            public override string ToString()
            {
                return $" {StudentName}, Marks : {StudentMarks}, Email: {StudentEmail}, Age: {StudentAge}";
            }
        }

        // List to hold students - Empty list
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddSt_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation is pending for non text values
                Student s = new Student
                {
                    StudentName = UI_StName_Tbx.Text,
                    StudentMarks = double.Parse(UI_StMarks_Tbx.Text),
                    StudentEmail = UI_StEmail_Tbx.Text,
                    StudentAge = int.Parse(UI_StAge_Tbx.Text)

                };

                students.Add(s);

                // Update the list
                RefreshList();
            }
            catch(Exception ex) {
                MessageBox .Show(ex.Message);
            }

        }

        //Method to Refresh student list

        private void RefreshList()
        { 
            // Clear your list
            UI_Stdents_Lbx.Items.Clear();

            foreach (Student s in students)
            {
                UI_Stdents_Lbx.Items.Add(s.ToString());
            }
        }

    }
}
