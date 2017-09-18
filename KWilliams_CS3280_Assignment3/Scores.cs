using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace KWilliams_CS3280_Assignment3
{
    public partial class Scores : Form
    {
        #region Initialize 

        private Gradebook myGradebook; // declare Gradebook object to access the class
        ListViewItem item;              // declare ListViewItem for listview display
        string[] arr;                   // declare string arr for use with listview display

        /// <summary>
        /// Constructor initializes the Scores Form
        /// </summary>
        public Scores()
        {
            InitializeComponent();
            btnLoadXML.Enabled = true;

        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Method displays the contents of the current gradebook object to the listview display, including average and letter grades
        /// </summary>
        private void displayScores()
        {
            lstviewDisplayScores.Clear();               // clears the listview prior to adding fresh data
            // initialize listview
            lstviewDisplayScores.View = View.Details;
            lstviewDisplayScores.FullRowSelect = true;

            lstviewDisplayScores.Columns.Add("Student", 100);     // add student column


            for (int i = 0; i < myGradebook.AssignmentCount; i++)             //for loop to add assignment columns to listview display      
            {
                lstviewDisplayScores.Columns.Add("#" + (i + 1).ToString(), 25);  // add assignment columns

            }

            lstviewDisplayScores.Columns.Add("AVG", 35);    // add average column
            lstviewDisplayScores.Columns.Add("GRADE", 50);  // add letter grade column

            lstviewDisplayScores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.Head‌​erSize);  // auto-size columns based on current quantity and size of the columns

            arr = new string[myGradebook.AssignmentCount + 3];      // initialize array to hold listview data to size needed

            for (int j = 0; j < myGradebook.StudentCount; j++)      // loops through each student
            {

                for (int i = 0; i < myGradebook.AssignmentCount + 3; i++)             //loops through each assignment plus student, average, and letter grade columns
                {
                    arr[i] = "";    // assigns the string as empty
                }
                item = new ListViewItem(arr);   // initializes ListViewItem
                lstviewDisplayScores.Items.Add(item);   // adds item to listview
            }

            int locationHolder = myGradebook.Location;  // records the current student position

            // for loop with a nested for loop to fill the contents of the listview display

            for (int i = 0; i < myGradebook.StudentCount; i++)  // loops through each student
            {
                myGradebook.Location = i; // sets student number
                lstviewDisplayScores.Items[i].SubItems[0].Text = myGradebook.Student; // adds student name

                for (int j = 0; j < myGradebook.AssignmentCount; j++)             // loops through each assignment
                {
                    lstviewDisplayScores.Items[i].SubItems[j + 1].Text = myGradebook.getScore(i, j).ToString();   //adds assignment score
                }
                double average = myGradebook.calcAverage(i); // declare average value and call calculate average method

                lstviewDisplayScores.Items[i].SubItems[myGradebook.AssignmentCount + 1].Text = Math.Round(average, 2).ToString();  // adds average value
                lstviewDisplayScores.Items[i].SubItems[myGradebook.AssignmentCount + 2].Text = myGradebook.letterGrade(average);    // adds letter grade
            }
            lstviewDisplayScores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.Head‌​erSize); // resizes columns to account for current display content
            myGradebook.Location = locationHolder; // resets student position back to original value
        }

        /// <summary>
        /// Method for handling thrown exceptions.
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }
        #endregion

        #region Event Driven Methods

        /// <summary>
        /// Method initializes Gradebook assuming valid input. Validation idea adapted from answer on stackoverflow from T.Rob. Link to answer - http://stackoverflow.com/a/8199613
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitCounts_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            bool isNumber1;
            bool isNumber2;
            bool inRange = false;
            isNumber1 = Int32.TryParse(txtStudentCount.Text, out number1);
            isNumber2 = Int32.TryParse(txtAssgnCount.Text, out number2);
            if (!isNumber1 || !isNumber2)
            {
                number1 = 0; // set guess to out of bounds value to force new input when input was invalid
                number2 = 0;
            }
            else
            {
                number1 = Convert.ToInt32(txtStudentCount.Text); // converts textbox value to int and sets guess equal to the 
                number2 = Convert.ToInt32(txtAssgnCount.Text);
            }

            if (number1 > 0 && number1 < 11) // checks for valid student count range
            {
                inRange = true;
            }
            else
            {
                MessageBox.Show("Invalid Input. Please enter a student count between (1-10).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (number2 > 0 && number2 < 100) // checks for valid assignment count range
            {
                inRange = true;
            }
            else
            {
                inRange = false;
                MessageBox.Show("Invalid Input. Please enter a assignment count between (1-99).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (inRange) // true if both values are integers and in range
            {
                myGradebook = new Gradebook();  // initializes Gradebook object
                myGradebook.StudentCount = number1;  // sets student count 
                myGradebook.AssignmentCount = number2; // sets assignment count
                myGradebook.createGradebook(number1, number2); // creates assignment array

                // following statements unlock the rest of the form and adjust the displays accordingly
                grpAssignment.Enabled = true;
                grpNavigate.Enabled = true;
                grpStudent.Enabled = true;

                btnLoadXML.Enabled = false;
                txtLoadFileName.Enabled = false;
                btnDisplay.Enabled = true;
                btnReset.Enabled = true;
                btnSubmitCounts.Enabled = false;
                lstviewDisplayScores.Enabled = true;

                lblStudentName.Text = myGradebook.Student;
                lblAssignmentNumber.Text = "Enter Assignment Number (1-" + myGradebook.AssignmentCount + "):";

                txtStudentCount.Text = "";
                txtStudentCount.Enabled = false;

                txtAssgnCount.Text = "";
                txtAssgnCount.Enabled = false;
                btnOutput.Enabled = true;
            }
        }
        /// <summary>
        /// Method resets the gradebook and form for new data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.myGradebook = null; // clears out current Gradebook object

            // following items reset form to its initial state
            lstviewDisplayScores.Clear();
            grpAssignment.Enabled = false;
            grpNavigate.Enabled = false;
            grpStudent.Enabled = false;

            btnLoadXML.Enabled = true;
            txtLoadFileName.Enabled = true;
            btnDisplay.Enabled = false;
            btnReset.Enabled = false;
            btnSubmitCounts.Enabled = true;
            lstviewDisplayScores.Enabled = false;
            btnOutput.Enabled = false;
            lblWritingMessage.Text = "";
            txtFileName.Clear();

            lblStudentName.Text = "Student #1";
            lblAssignmentNumber.Text = "Enter Assignment Number (1-X):";

            txtStudentCount.Enabled = true;
            txtAssgnCount.Enabled = true;
        }


        /// <summary>
        ///  Method sets student position to first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            myGradebook.Location = 0;
            lblStudentName.Text = myGradebook.Student;      // updates label with current student name
            txtStudentName.Text = "";
        }

        /// <summary>
        /// Method saves the student's name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            myGradebook.Student = txtStudentName.Text;  // assign student name equal to student name text box
            lblStudentName.Text = myGradebook.Student;  // update label
            txtStudentName.Text = "";
        }
        /// <summary>
        /// Method sets student position to last.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            myGradebook.Location = myGradebook.StudentCount - 1;
            lblStudentName.Text = myGradebook.Student;
            txtStudentName.Text = "";
        }
        /// <summary>
        /// Method sets student position to previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (myGradebook.Location - 1 < 0) // checks if first position
            {
                myGradebook.Location = 0;  // stays first if so
            }
            else
            {
                myGradebook.Location--; // student position is decremented one
                lblStudentName.Text = myGradebook.Student; // label is updated with new value
            }
        }
        /// <summary>
        /// Method sets student position to next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (myGradebook.Location + 1 > myGradebook.StudentCount - 1)  // checks if last position
            {
                myGradebook.Location = myGradebook.StudentCount - 1;
            }
            else
            {
                myGradebook.Location++; // student position is incremented by one
                lblStudentName.Text = myGradebook.Student; // update label
            }
        }
        /// <summary>
        /// Method saves assignment score to assignments array. Validation idea adapted from answer on stackoverflow from T.Rob. Link to answer - http://stackoverflow.com/a/8199613
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            int number1, number2;
            bool isNumber1, isNumber2;
            bool inRange = false;
            isNumber1 = Int32.TryParse(txtAssignmentNumber.Text, out number1);
            isNumber2 = Int32.TryParse(txtAssignmentScore.Text, out number2);
            if (!isNumber1 || !isNumber2)
            {
                number1 = 0; // set guess to out of bounds value to force new input when input was invalid
                number2 = 0;
            }
            else
            {
                number1 = Convert.ToInt32(txtAssignmentNumber.Text); // converts textbox value to int and sets it equal to number variable 
                number2 = Convert.ToInt32(txtAssignmentScore.Text);
            }

            if (number1 > 0 && number1 < myGradebook.AssignmentCount + 1)
            {
                inRange = true;
            }
            else
            {
                MessageBox.Show("Invalid Input. Please enter an assignment number between (1-" + myGradebook.AssignmentCount + ").", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (inRange)
            {
                myGradebook.saveScore(number1, number2); // with valid input calls saveScore method to update score value in assignments array
                txtAssignmentNumber.Text = "";
                txtAssignmentScore.Text = "";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayScores(); // calls display scores method
        }

        /// <summary>
        /// Handles the Save to File button click event. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text != "")
                {
                    btnOutput.Enabled = false;
                    lblWritingMessage.Text = "Writing to file...";
                    bckWorker1.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("A file has no name. Please enter a file name in order to save file.", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Load from XML button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoadFileName.Text != "")
                {
                    btnLoadXML.Enabled = false;
                    myGradebook = new Gradebook();
                    MessageBox.Show("The file will start loading.", "Load File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bckWorker2.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("A file has no name. Please enter a file name in order to load file.", "Load File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Background Worker Do Work method that saves the file on a different thread so the UI doesn't lock up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bckWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string sFile = @"C:\Users\Public\" + txtFileName.Text;
                myGradebook.SaveToFile(sFile);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// Method updates text box and re-enables output button once file has been saved. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bckWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblWritingMessage.Text = "Finished writing to file!";
                txtFileName.Clear();
                btnOutput.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// Method handles the loading scores from XML file on a separate thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bckWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string sFile = @"C:\Users\Public\" + txtLoadFileName.Text;
                myGradebook.LoadFromFile(sFile);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// Method enables the form once scores have been loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bckWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                grpAssignment.Enabled = true;
                grpNavigate.Enabled = true;
                grpStudent.Enabled = true;

                btnLoadXML.Enabled = false;
                txtLoadFileName.Enabled = false;
                btnDisplay.Enabled = true;
                btnReset.Enabled = true;
                btnSubmitCounts.Enabled = false;
                lstviewDisplayScores.Enabled = true;
                txtLoadFileName.Clear();

                lblStudentName.Text = myGradebook.Student;
                lblAssignmentNumber.Text = "Enter Assignment Number (1-" + myGradebook.AssignmentCount + "):";

                txtStudentCount.Text = "";
                txtStudentCount.Enabled = false;

                txtAssgnCount.Text = "";
                txtAssgnCount.Enabled = false;
                btnOutput.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        #endregion

    }
}
