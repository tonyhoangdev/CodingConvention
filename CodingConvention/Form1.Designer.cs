namespace CodingConvention
{
    partial class Form1
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
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lstFunctions = new System.Windows.Forms.ListBox();
            this.tabCodingConvention = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFormatCode = new System.Windows.Forms.Button();
            this.cbGenPExDRV = new System.Windows.Forms.CheckBox();
            this.cbGenPExHAL = new System.Windows.Forms.CheckBox();
            this.btnResultCompare = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnSelectSRS = new System.Windows.Forms.Button();
            this.cbCleanLstFuncs = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTestSRS = new System.Windows.Forms.Button();
            this.btnTestTM = new System.Windows.Forms.Button();
            this.btnTestResult = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lstMiss = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCodingConvention.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbCode
            // 
            this.rtbCode.Location = new System.Drawing.Point(6, 46);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(650, 475);
            this.rtbCode.TabIndex = 0;
            this.rtbCode.Tag = ".c|.h";
            this.rtbCode.Text = "";
            this.rtbCode.WordWrap = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(6, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 34);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lstFunctions
            // 
            this.lstFunctions.FormattingEnabled = true;
            this.lstFunctions.Location = new System.Drawing.Point(688, 46);
            this.lstFunctions.Name = "lstFunctions";
            this.lstFunctions.Size = new System.Drawing.Size(226, 472);
            this.lstFunctions.TabIndex = 2;
            this.lstFunctions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFunctions_DrawItem);
            this.lstFunctions.SelectedIndexChanged += new System.EventHandler(this.lstFunctions_SelectedIndexChanged);
            // 
            // tabCodingConvention
            // 
            this.tabCodingConvention.Controls.Add(this.tabPage1);
            this.tabCodingConvention.Controls.Add(this.tabPage2);
            this.tabCodingConvention.Controls.Add(this.tabPage3);
            this.tabCodingConvention.Controls.Add(this.tabPage4);
            this.tabCodingConvention.Location = new System.Drawing.Point(12, 12);
            this.tabCodingConvention.Name = "tabCodingConvention";
            this.tabCodingConvention.SelectedIndex = 0;
            this.tabCodingConvention.Size = new System.Drawing.Size(1079, 553);
            this.tabCodingConvention.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFormatCode);
            this.tabPage1.Controls.Add(this.cbGenPExDRV);
            this.tabPage1.Controls.Add(this.cbGenPExHAL);
            this.tabPage1.Controls.Add(this.btnResultCompare);
            this.tabPage1.Controls.Add(this.lstResult);
            this.tabPage1.Controls.Add(this.btnSelectSRS);
            this.tabPage1.Controls.Add(this.cbCleanLstFuncs);
            this.tabPage1.Controls.Add(this.btnOpenFile);
            this.tabPage1.Controls.Add(this.lstFunctions);
            this.tabPage1.Controls.Add(this.rtbCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1071, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check code and SRS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFormatCode
            // 
            this.btnFormatCode.Location = new System.Drawing.Point(549, 6);
            this.btnFormatCode.Name = "btnFormatCode";
            this.btnFormatCode.Size = new System.Drawing.Size(107, 34);
            this.btnFormatCode.TabIndex = 9;
            this.btnFormatCode.Text = "Format Code";
            this.btnFormatCode.UseVisualStyleBackColor = true;
            this.btnFormatCode.Click += new System.EventHandler(this.btnFormatCode_Click);
            // 
            // cbGenPExDRV
            // 
            this.cbGenPExDRV.AutoSize = true;
            this.cbGenPExDRV.Location = new System.Drawing.Point(406, 23);
            this.cbGenPExDRV.Name = "cbGenPExDRV";
            this.cbGenPExDRV.Size = new System.Drawing.Size(137, 17);
            this.cbGenPExDRV.TabIndex = 8;
            this.cbGenPExDRV.Text = "Gen Method Pex Driver";
            this.cbGenPExDRV.UseVisualStyleBackColor = true;
            // 
            // cbGenPExHAL
            // 
            this.cbGenPExHAL.AutoSize = true;
            this.cbGenPExHAL.Location = new System.Drawing.Point(406, 6);
            this.cbGenPExHAL.Name = "cbGenPExHAL";
            this.cbGenPExHAL.Size = new System.Drawing.Size(125, 17);
            this.cbGenPExHAL.TabIndex = 7;
            this.cbGenPExHAL.Text = "Gen Method Pex Hal";
            this.cbGenPExHAL.UseVisualStyleBackColor = true;
            // 
            // btnResultCompare
            // 
            this.btnResultCompare.Location = new System.Drawing.Point(287, 6);
            this.btnResultCompare.Name = "btnResultCompare";
            this.btnResultCompare.Size = new System.Drawing.Size(113, 34);
            this.btnResultCompare.TabIndex = 6;
            this.btnResultCompare.Text = "Result Compare";
            this.btnResultCompare.UseVisualStyleBackColor = true;
            this.btnResultCompare.Click += new System.EventHandler(this.btnResultCompare_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(920, 46);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(128, 472);
            this.lstResult.TabIndex = 5;
            this.lstResult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstResult_DrawItem);
            // 
            // btnSelectSRS
            // 
            this.btnSelectSRS.Location = new System.Drawing.Point(206, 6);
            this.btnSelectSRS.Name = "btnSelectSRS";
            this.btnSelectSRS.Size = new System.Drawing.Size(75, 34);
            this.btnSelectSRS.TabIndex = 4;
            this.btnSelectSRS.Text = "Select SRS";
            this.btnSelectSRS.UseVisualStyleBackColor = true;
            this.btnSelectSRS.Click += new System.EventHandler(this.btnSelectSRS_Click);
            // 
            // cbCleanLstFuncs
            // 
            this.cbCleanLstFuncs.AutoSize = true;
            this.cbCleanLstFuncs.Checked = true;
            this.cbCleanLstFuncs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCleanLstFuncs.Location = new System.Drawing.Point(87, 16);
            this.cbCleanLstFuncs.Name = "cbCleanLstFuncs";
            this.cbCleanLstFuncs.Size = new System.Drawing.Size(113, 17);
            this.cbCleanLstFuncs.TabIndex = 3;
            this.cbCleanLstFuncs.Text = "Clean List function";
            this.cbCleanLstFuncs.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1071, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gen code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1071, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Uml";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.lstMiss);
            this.tabPage4.Controls.Add(this.lbResult);
            this.tabPage4.Controls.Add(this.btnTestResult);
            this.tabPage4.Controls.Add(this.btnTestTM);
            this.tabPage4.Controls.Add(this.btnTestSRS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1071, 527);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Check SRS and Test code";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTestSRS
            // 
            this.btnTestSRS.Location = new System.Drawing.Point(6, 6);
            this.btnTestSRS.Name = "btnTestSRS";
            this.btnTestSRS.Size = new System.Drawing.Size(86, 44);
            this.btnTestSRS.TabIndex = 0;
            this.btnTestSRS.Text = "Select SRS";
            this.btnTestSRS.UseVisualStyleBackColor = true;
            this.btnTestSRS.Click += new System.EventHandler(this.btnTestSRS_Click);
            // 
            // btnTestTM
            // 
            this.btnTestTM.Enabled = false;
            this.btnTestTM.Location = new System.Drawing.Point(98, 6);
            this.btnTestTM.Name = "btnTestTM";
            this.btnTestTM.Size = new System.Drawing.Size(86, 44);
            this.btnTestTM.TabIndex = 1;
            this.btnTestTM.Text = "Select TM";
            this.btnTestTM.UseVisualStyleBackColor = true;
            this.btnTestTM.Click += new System.EventHandler(this.btnTestTM_Click);
            // 
            // btnTestResult
            // 
            this.btnTestResult.Enabled = false;
            this.btnTestResult.Location = new System.Drawing.Point(190, 6);
            this.btnTestResult.Name = "btnTestResult";
            this.btnTestResult.Size = new System.Drawing.Size(75, 44);
            this.btnTestResult.TabIndex = 2;
            this.btnTestResult.Text = "Result";
            this.btnTestResult.UseVisualStyleBackColor = true;
            this.btnTestResult.Click += new System.EventHandler(this.btnTestResult_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(285, 14);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(127, 24);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Coverage: 0%";
            // 
            // lstMiss
            // 
            this.lstMiss.FormattingEnabled = true;
            this.lstMiss.Location = new System.Drawing.Point(6, 98);
            this.lstMiss.Name = "lstMiss";
            this.lstMiss.Size = new System.Drawing.Size(259, 420);
            this.lstMiss.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Miss:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 577);
            this.Controls.Add(this.tabCodingConvention);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCodingConvention.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.ListBox lstFunctions;
        private System.Windows.Forms.TabControl tabCodingConvention;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbCleanLstFuncs;
        private System.Windows.Forms.Button btnSelectSRS;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnResultCompare;
        private System.Windows.Forms.CheckBox cbGenPExHAL;
        private System.Windows.Forms.CheckBox cbGenPExDRV;
        private System.Windows.Forms.Button btnFormatCode;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTestSRS;
        private System.Windows.Forms.Button btnTestTM;
        private System.Windows.Forms.Button btnTestResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMiss;
    }
}

