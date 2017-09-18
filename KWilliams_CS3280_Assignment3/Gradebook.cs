using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace KWilliams_CS3280_Assignment3
{
    class Gradebook
    {

        #region Attributes

        private int numberStudents;         // holds student count
        private int numberAssignments;      // holds assignment count
        private string[] students;          // string array for student names
        private double[,] assignments;      // two dimensional array for assignment number and score
        private int currentLocation;        // keeps track of student position for array indexing

        #endregion

        #region Methods
        /// <summary>
        /// No-arguments constructor. Initializes numberStudents, numberAssignments, and current Location to default values.
        /// </summary>
        public Gradebook()
        {
            numberStudents = 0;
            numberAssignments = 0;
            currentLocation = 0;

        }

        /// <summary>
        /// Method initializes the student and assignment arrays needed for the gradebook. 
        /// </summary>
        /// <param name="studentCount"></param>
        /// <param name="assgnCount"></param>
        public void createGradebook(int studentCount, int assgnCount)
        {
            students = new string[numberStudents];  // initialize students array to size student count
            assignments = new double[numberStudents, numberAssignments];    // initialize assignments array to number of students by number of assignments

            for (int i = 0; i < numberStudents; i++)  // loops throw each student
            {
                students[i] = "Student #" + (i + 1).ToString();         // sets student name to default value
            }
        }

        /// <summary>
        /// Method initializes the student and assignment arrays needed for the gradebook when loading from file.
        /// </summary>
        /// <param name="studentCount"></param>
        /// <param name="assgnCount"></param>
        public void createLoadedGradebook()
        {
            students = new string[numberStudents];  // initialize students array to size student count
            assignments = new double[numberStudents, numberAssignments];    // initialize assignments array to number of students by number of assignments

        }

        /// <summary>
        /// Method saves assignment score in assignments array
        /// </summary>
        /// <param name="assignmentNumber"></param>
        /// <param name="score"></param>
        public void saveScore(int assignmentNumber, int score)
        {
            assignments[currentLocation, assignmentNumber - 1] = score;  // set array index to score value
        }
        /// <summary>
        /// Method calculates student's average assignment score
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public double calcAverage(int location)
        {
            double sum = 0; // declare sum variable
            for (int i = 0; i < numberAssignments; i++) // loop through each score for student passed in
            {
                sum += assignments[location, i];        // add value to sum
            }
            return (sum / (numberAssignments * 100)) * 100;     // return average based on 100 point assignments
        }

        /// <summary>
        /// Method retreives and returns assignment score for given student and assignment number passed in.
        /// </summary>
        /// <param name="student"></param>
        /// <param name="assignment"></param>
        /// <returns></returns>
        public double getScore(int student, int assignment)
        {
            return assignments[student, assignment];    // returns requested assignment score
        }
        /// <summary>
        /// Method returns student's letter grade based on passed in average assignment score
        /// </summary>
        /// <param name="average"></param>
        /// <returns></returns>
        public string letterGrade(double average)
        {
            // comparison statements for each grade range returns appropriate letter grade
            if (average >= 93)
                return "A";
            else if (average >= 90)
                return "A-";
            else if (average >= 87)
                return "B+";
            else if (average >= 83)
                return "B";
            else if (average >= 80)
                return "B-";
            else if (average >= 77)
                return "C+";
            else if (average >= 73)
                return "C";
            else if (average >= 70)
                return "C-";
            else if (average >= 67)
                return "D+";
            else if (average >= 63)
                return "D";
            else if (average >= 60)
                return "D-";
            else
                return "E";
        }

        /// <summary>
        /// Method saves gradebook data to text file.
        /// </summary>
        /// <param name="FileName"></param>
        public void SaveToFile(string FileName)
        {
            try
            {
                if (File.Exists(FileName))
                {
                    MessageBox.Show("This file already exist");
                }
                else
                {
                    using (StreamWriter MyWriter = new StreamWriter(FileName))
                    {
                        for (int i = 0; i < numberStudents; i++)
                        {
                            MyWriter.Write("Name - " + students[i] + "\t");
                            for (int j = 0; j < numberAssignments; j++)
                            {
                                MyWriter.Write(" " + assignments[i, j].ToString() + ",\t");
                            }
                            MyWriter.Write(" AVG: " + calcAverage(i).ToString() + "  Grade: " + letterGrade(calcAverage(i)).ToString());
                            MyWriter.Write("\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// Method loads gradebook data from xml file.
        /// </summary>
        /// <param name="FileName"></param>
        public void LoadFromFile(string FileName)
        {
            try
            {
                char[] firstSplit = { '\r', '\n' };
                char[] delimiterChars = { ' ', ',', '-', ':', '\t', '\r', '\n' };

                string sAllFileData;

                if (!File.Exists(FileName))
                {
                    MessageBox.Show("That file doesn't exist");
                }
                else
                {
                    using (StreamReader FileRead = new StreamReader(FileName))
                    {
                        sAllFileData = FileRead.ReadToEnd();

                        string[] studentData = sAllFileData.Split(firstSplit, StringSplitOptions.RemoveEmptyEntries);

                        numberStudents = studentData.Length;

                        string[] getCounts = studentData[0].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                        numberAssignments = getCounts.Length - 6;

                        createLoadedGradebook();

                        for (int i = 0; i < numberStudents; i++)
                        {
                            getCounts = studentData[i].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 2; j < getCounts.Length - 4; j++)
                            {
                                assignments[i, (j - 2)] = Convert.ToDouble(getCounts[j]);
                            }
                            students[i] = getCounts[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        #endregion

        #region Private Methods

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

        #region Properties
        public string Student           // declare student property for getting/setting student name variable
        {
            get
            {
                return students[currentLocation];
            }
            set
            {
                students[currentLocation] = value;
            }
        }


        public int AssignmentCount      // declare assignment count property for getting/setting assignment count variable
        {
            get
            {
                return numberAssignments;
            }
            set
            {
                numberAssignments = value;
            }
        }
        public int StudentCount         // declare student count property for getting/setting student count variable
        {
            get
            {
                return numberStudents;
            }
            set
            {
                numberStudents = value;
            }
        }
        public int Location             // declare location property for getting/setting student position variable
        {
            get
            {
                return currentLocation;
            }
            set
            {
                currentLocation = value;
            }
        }

        #endregion

    }
}
