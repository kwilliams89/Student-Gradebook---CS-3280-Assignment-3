namespace KWilliams_CS3280_Assignment3
{
    partial class Scores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCounts = new System.Windows.Forms.GroupBox();
            this.lblLoadFileName = new System.Windows.Forms.Label();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.btnSubmitCounts = new System.Windows.Forms.Button();
            this.txtAssgnCount = new System.Windows.Forms.TextBox();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.lblNumAssignments = new System.Windows.Forms.Label();
            this.lblNumStudents = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpNavigate = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.grpAssignment = new System.Windows.Forms.GroupBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.txtAssignmentScore = new System.Windows.Forms.TextBox();
            this.txtAssignmentNumber = new System.Windows.Forms.TextBox();
            this.lblAssignmentScore = new System.Windows.Forms.Label();
            this.lblAssignmentNumber = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lstviewDisplayScores = new System.Windows.Forms.ListView();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblWritingMessage = new System.Windows.Forms.Label();
            this.bckWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bckWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtLoadFileName = new System.Windows.Forms.TextBox();
            this.grpCounts.SuspendLayout();
            this.grpNavigate.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCounts
            // 
            this.grpCounts.Controls.Add(this.txtLoadFileName);
            this.grpCounts.Controls.Add(this.lblLoadFileName);
            this.grpCounts.Controls.Add(this.btnLoadXML);
            this.grpCounts.Controls.Add(this.btnSubmitCounts);
            this.grpCounts.Controls.Add(this.txtAssgnCount);
            this.grpCounts.Controls.Add(this.txtStudentCount);
            this.grpCounts.Controls.Add(this.lblNumAssignments);
            this.grpCounts.Controls.Add(this.lblNumStudents);
            this.grpCounts.Controls.Add(this.btnReset);
            this.grpCounts.Location = new System.Drawing.Point(26, 12);
            this.grpCounts.Name = "grpCounts";
            this.grpCounts.Size = new System.Drawing.Size(452, 79);
            this.grpCounts.TabIndex = 0;
            this.grpCounts.TabStop = false;
            this.grpCounts.Text = "Counts:";
            // 
            // lblLoadFileName
            // 
            this.lblLoadFileName.AutoSize = true;
            this.lblLoadFileName.Location = new System.Drawing.Point(168, 20);
            this.lblLoadFileName.Name = "lblLoadFileName";
            this.lblLoadFileName.Size = new System.Drawing.Size(58, 13);
            this.lblLoadFileName.TabIndex = 12;
            this.lblLoadFileName.Text = "File name: ";
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Enabled = false;
            this.btnLoadXML.Location = new System.Drawing.Point(333, 13);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(103, 27);
            this.btnLoadXML.TabIndex = 11;
            this.btnLoadXML.Text = "Load from File";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // btnSubmitCounts
            // 
            this.btnSubmitCounts.Location = new System.Drawing.Point(171, 43);
            this.btnSubmitCounts.Name = "btnSubmitCounts";
            this.btnSubmitCounts.Size = new System.Drawing.Size(93, 23);
            this.btnSubmitCounts.TabIndex = 4;
            this.btnSubmitCounts.Text = "Submit Counts";
            this.btnSubmitCounts.UseVisualStyleBackColor = true;
            this.btnSubmitCounts.Click += new System.EventHandler(this.btnSubmitCounts_Click);
            // 
            // txtAssgnCount
            // 
            this.txtAssgnCount.Location = new System.Drawing.Point(132, 43);
            this.txtAssgnCount.MaxLength = 2;
            this.txtAssgnCount.Name = "txtAssgnCount";
            this.txtAssgnCount.Size = new System.Drawing.Size(21, 20);
            this.txtAssgnCount.TabIndex = 3;
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(132, 17);
            this.txtStudentCount.MaxLength = 2;
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(21, 20);
            this.txtStudentCount.TabIndex = 2;
            // 
            // lblNumAssignments
            // 
            this.lblNumAssignments.AutoSize = true;
            this.lblNumAssignments.Location = new System.Drawing.Point(6, 46);
            this.lblNumAssignments.Name = "lblNumAssignments";
            this.lblNumAssignments.Size = new System.Drawing.Size(120, 13);
            this.lblNumAssignments.TabIndex = 1;
            this.lblNumAssignments.Text = "Number of assignments:";
            this.lblNumAssignments.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumStudents
            // 
            this.lblNumStudents.AutoSize = true;
            this.lblNumStudents.Location = new System.Drawing.Point(24, 20);
            this.lblNumStudents.Name = "lblNumStudents";
            this.lblNumStudents.Size = new System.Drawing.Size(102, 13);
            this.lblNumStudents.TabIndex = 0;
            this.lblNumStudents.Text = "Number of students:";
            this.lblNumStudents.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(333, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpNavigate
            // 
            this.grpNavigate.Controls.Add(this.btnNext);
            this.grpNavigate.Controls.Add(this.btnFirst);
            this.grpNavigate.Controls.Add(this.btnLast);
            this.grpNavigate.Controls.Add(this.btnPrevious);
            this.grpNavigate.Enabled = false;
            this.grpNavigate.Location = new System.Drawing.Point(26, 97);
            this.grpNavigate.Name = "grpNavigate";
            this.grpNavigate.Size = new System.Drawing.Size(452, 57);
            this.grpNavigate.TabIndex = 1;
            this.grpNavigate.TabStop = false;
            this.grpNavigate.Text = "Navigate:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(244, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Student >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(19, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(93, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "<< First Student";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(343, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(93, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "Last Student >>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(118, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(93, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "< Prev Student";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.txtStudentName);
            this.grpStudent.Controls.Add(this.lblStudentName);
            this.grpStudent.Controls.Add(this.btnSaveName);
            this.grpStudent.Enabled = false;
            this.grpStudent.Location = new System.Drawing.Point(26, 160);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(452, 51);
            this.grpStudent.TabIndex = 2;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Info:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(82, 21);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(212, 20);
            this.txtStudentName.TabIndex = 10;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(16, 24);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 13);
            this.lblStudentName.TabIndex = 9;
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSaveName
            // 
            this.btnSaveName.Location = new System.Drawing.Point(343, 19);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(93, 23);
            this.btnSaveName.TabIndex = 8;
            this.btnSaveName.Text = "Save Name";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // grpAssignment
            // 
            this.grpAssignment.Controls.Add(this.btnSaveScore);
            this.grpAssignment.Controls.Add(this.txtAssignmentScore);
            this.grpAssignment.Controls.Add(this.txtAssignmentNumber);
            this.grpAssignment.Controls.Add(this.lblAssignmentScore);
            this.grpAssignment.Controls.Add(this.lblAssignmentNumber);
            this.grpAssignment.Enabled = false;
            this.grpAssignment.Location = new System.Drawing.Point(26, 217);
            this.grpAssignment.Name = "grpAssignment";
            this.grpAssignment.Size = new System.Drawing.Size(452, 75);
            this.grpAssignment.TabIndex = 1;
            this.grpAssignment.TabStop = false;
            this.grpAssignment.Text = "Assignment Info:";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Location = new System.Drawing.Point(343, 43);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(93, 23);
            this.btnSaveScore.TabIndex = 9;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // txtAssignmentScore
            // 
            this.txtAssignmentScore.Location = new System.Drawing.Point(212, 46);
            this.txtAssignmentScore.MaxLength = 3;
            this.txtAssignmentScore.Name = "txtAssignmentScore";
            this.txtAssignmentScore.Size = new System.Drawing.Size(52, 20);
            this.txtAssignmentScore.TabIndex = 8;
            // 
            // txtAssignmentNumber
            // 
            this.txtAssignmentNumber.Location = new System.Drawing.Point(212, 20);
            this.txtAssignmentNumber.MaxLength = 2;
            this.txtAssignmentNumber.Name = "txtAssignmentNumber";
            this.txtAssignmentNumber.Size = new System.Drawing.Size(52, 20);
            this.txtAssignmentNumber.TabIndex = 7;
            // 
            // lblAssignmentScore
            // 
            this.lblAssignmentScore.AutoSize = true;
            this.lblAssignmentScore.Location = new System.Drawing.Point(81, 53);
            this.lblAssignmentScore.Name = "lblAssignmentScore";
            this.lblAssignmentScore.Size = new System.Drawing.Size(95, 13);
            this.lblAssignmentScore.TabIndex = 6;
            this.lblAssignmentScore.Text = "Assignment Score:";
            this.lblAssignmentScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAssignmentNumber
            // 
            this.lblAssignmentNumber.AutoSize = true;
            this.lblAssignmentNumber.Location = new System.Drawing.Point(16, 27);
            this.lblAssignmentNumber.Name = "lblAssignmentNumber";
            this.lblAssignmentNumber.Size = new System.Drawing.Size(160, 13);
            this.lblAssignmentNumber.TabIndex = 5;
            this.lblAssignmentNumber.Text = "Enter Assignment Number  (1-X):";
            this.lblAssignmentNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(45, 298);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(93, 27);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Scores";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lstviewDisplayScores
            // 
            this.lstviewDisplayScores.Enabled = false;
            this.lstviewDisplayScores.Location = new System.Drawing.Point(26, 354);
            this.lstviewDisplayScores.Name = "lstviewDisplayScores";
            this.lstviewDisplayScores.Size = new System.Drawing.Size(452, 120);
            this.lstviewDisplayScores.TabIndex = 5;
            this.lstviewDisplayScores.UseCompatibleStateImageBehavior = false;
            // 
            // btnOutput
            // 
            this.btnOutput.Enabled = false;
            this.btnOutput.Location = new System.Drawing.Point(369, 298);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 27);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Save to File";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(144, 305);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(89, 13);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "Create file name: ";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(239, 302);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(108, 20);
            this.txtFileName.TabIndex = 9;
            // 
            // lblWritingMessage
            // 
            this.lblWritingMessage.AutoSize = true;
            this.lblWritingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWritingMessage.Location = new System.Drawing.Point(344, 336);
            this.lblWritingMessage.Name = "lblWritingMessage";
            this.lblWritingMessage.Size = new System.Drawing.Size(0, 15);
            this.lblWritingMessage.TabIndex = 10;
            // 
            // bckWorker1
            // 
            this.bckWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckWorker1_DoWork);
            this.bckWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckWorker1_RunWorkerCompleted);
            // 
            // bckWorker2
            // 
            this.bckWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckWorker2_DoWork);
            this.bckWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckWorker2_RunWorkerCompleted);
            // 
            // txtLoadFileName
            // 
            this.txtLoadFileName.Location = new System.Drawing.Point(223, 17);
            this.txtLoadFileName.Name = "txtLoadFileName";
            this.txtLoadFileName.Size = new System.Drawing.Size(104, 20);
            this.txtLoadFileName.TabIndex = 13;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 499);
            this.Controls.Add(this.lblWritingMessage);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lstviewDisplayScores);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.grpAssignment);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpNavigate);
            this.Controls.Add(this.grpCounts);
            this.Name = "Scores";
            this.Text = "Scores";
            this.grpCounts.ResumeLayout(false);
            this.grpCounts.PerformLayout();
            this.grpNavigate.ResumeLayout(false);
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpAssignment.ResumeLayout(false);
            this.grpAssignment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCounts;
        private System.Windows.Forms.GroupBox grpNavigate;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.GroupBox grpAssignment;
        private System.Windows.Forms.Button btnSubmitCounts;
        private System.Windows.Forms.TextBox txtAssgnCount;
        private System.Windows.Forms.TextBox txtStudentCount;
        private System.Windows.Forms.Label lblNumAssignments;
        private System.Windows.Forms.Label lblNumStudents;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.TextBox txtAssignmentScore;
        private System.Windows.Forms.TextBox txtAssignmentNumber;
        private System.Windows.Forms.Label lblAssignmentScore;
        private System.Windows.Forms.Label lblAssignmentNumber;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListView lstviewDisplayScores;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblWritingMessage;
        private System.ComponentModel.BackgroundWorker bckWorker1;
        private System.Windows.Forms.Button btnLoadXML;
        private System.ComponentModel.BackgroundWorker bckWorker2;
        private System.Windows.Forms.Label lblLoadFileName;
        private System.Windows.Forms.TextBox txtLoadFileName;
    }
}

