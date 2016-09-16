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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResultCompare = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnSelectSRS = new System.Windows.Forms.Button();
            this.cbCleanLstFuncs = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbGenPExHAL = new System.Windows.Forms.CheckBox();
            this.cbGenPExDRV = new System.Windows.Forms.CheckBox();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1079, 553);
            this.tab1.TabIndex = 3;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(1071, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1071, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 577);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.ListBox lstFunctions;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbCleanLstFuncs;
        private System.Windows.Forms.Button btnSelectSRS;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnResultCompare;
        private System.Windows.Forms.CheckBox cbGenPExHAL;
        private System.Windows.Forms.CheckBox cbGenPExDRV;
    }
}

