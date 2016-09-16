using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Excel;

namespace CodingConvention
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Save file name
        static string fileIn = "";
        // Content of file name;
        static string fileContents = "";
        // Content of each line
        static string[] lines;
        // SRS file name
        static string srsFileName = "";


        // ReadFile
        static void ReadFile()
        {
            try
            {
                lines = File.ReadAllLines(fileIn);
                fileContents = File.ReadAllText(fileIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        FunctionParam GetFunctionParams(Match theMatch)
        {
            FunctionParam fncParam = new FunctionParam();
            string fncName = theMatch.Groups["function"].ToString();
            int indexOpen = theMatch.ToString().IndexOf('(');
            int indexClose = theMatch.ToString().IndexOf(')');
            string paramss = theMatch.ToString().Substring(indexOpen + 1, indexClose - indexOpen - 1).Trim();
            fncParam.FncName = fncName;

            if (String.IsNullOrEmpty(paramss))
            {
                fncParam.FncParams = null;
                fncParam.NumOfParam = 0;
            }
            else
            {
                string[] pa = paramss.Split(',');
                fncParam.NumOfParam = pa.Length;
                fncParam.FncParams = new string[pa.Length];

                for (int i = 0; i < pa.Length; i++)
                {
                    fncParam.FncParams[i] = pa[i].Trim();
                }
            }

            return fncParam;
        }

        String contents = "";
        List<string> enums;
        List<string> structs;
        List<string> funcs;
        List<string> allFuncs = new List<string>();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object
            OpenFileDialog openFile = new OpenFileDialog();
            // Initialize the filter to look for text files
            openFile.Filter = "H File|*.h|C File|*.c|All file|*.*";

            // If the user selected a file, load its contents into the RichTextBox
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileIn = openFile.FileName;
                rtbCode.LoadFile(fileIn, RichTextBoxStreamType.PlainText);
                contents = new ProcessFile(openFile.FileName).ReadFile();
                if (cbCleanLstFuncs.Checked == true)
                {
                    lstFunctions.Items.Clear();
                    allFuncs.Clear();
                }
            }
            else
            {
                return;
            }

            // Add funcs
            enums = ParseEnum(contents);
            structs = ParseStruct(contents);
            funcs = ParseFuncs(contents);
            if (enums != null)
            {
                allFuncs.AddRange(enums.ToArray());
            }
            if (structs != null)
            {
                allFuncs.AddRange(structs.ToArray());
            }
            if (funcs != null)
            {
                allFuncs.AddRange(funcs.ToArray());
            }

            // add to list
            lstFunctions.Items.AddRange(allFuncs.ToArray());

            // show funcs in Rich Text Box
            ShowFuncsInRichTextBox(lstFunctions);           

            // Gen PEX methods
            if (cbGenPExHAL.Checked)
            {
                SavePExHALMethod(allFuncs);
                SaveListFunctions(allFuncs);
            }
            if (cbGenPExDRV.Checked)
            {
                SavePExDRVMethod(allFuncs);
                SaveListFunctions(allFuncs);
            }
        }

        private void ShowFuncsInRichTextBox(ListBox funcs)
        {
            for (int i = 0; i < lstFunctions.Items.Count; i++)
            {
                rtbCode.Find(lstFunctions.Items[i].ToString(), RichTextBoxFinds.MatchCase);

                rtbCode.SelectionFont = new Font("Verdana", 15, FontStyle.Bold);
                rtbCode.SelectionColor = Color.Red;
            }
        }

        private List<string> ParseFuncs(string str)
        {
            StringBuilder sb = new StringBuilder();

            // Gets functions in file
            Regex theReg = new Regex(@"[\t ]*((static|const|virtual)[\s]+)?[\w:]+([\s]+[\w]+)?([\s]+|\*[\s]+|[\s]+\*|[\s]+\*[\s]+)([\w_]+[\s]*::)?(?!(if|while|for))[\w_]+[\s]*\([^\)\(]*\)([\s]*const[\s]*)?[\n\s]*[;|{]");
            // Gets result
            MatchCollection theMatches = theReg.Matches(contents);
            foreach (Match theMatch in theMatches)
            {
                if (theMatch.Length != 0)
                {
                    sb.Append(theMatch.ToString());
                }
            }

            string sbt = Regex.Replace(sb.ToString(), "( )+", " ");


            StringBuilder sbParams = new StringBuilder();
            List<string> funcs = new List<string>();
            // Regex 2
            Regex theReg2 = new Regex(@"(?<modifier>([\w_\s])+) (?<function>([\w]+))[\s]*\([^\)\(]*\)([\s]*const[\s]*)?[\n\s]*[;|{]");
            MatchCollection theMatches2 = theReg2.Matches(sbt);
            foreach (Match theMatch2 in theMatches2)
            {
                FunctionParam fnParam = GetFunctionParams(theMatch2);
                if (!fnParam.ToString().Contains("DEV_ASSERT") && !fnParam.ToString().Contains("return") && !fnParam.ToString().Contains("char") && !fnParam.ToString().Contains("BR_FTM_STATUS")) // TODO: 
                {
                    funcs.Add(fnParam.ToString());
                }
            }

            return funcs;
        }

        private List<string> ParseEnum(string str)
        {
            List<string> outPut = new List<string>();
            string template = @"typedef enum[_\{\s\w=,/\*!<:+-.>^\(\)#]*\}\s*(?<enum>(\w+))\s*;";

            Regex regex = new Regex(template);
            MatchCollection theMatches = regex.Matches(str);

            foreach (Match theMatch in theMatches)
            {
                outPut.Add(theMatch.Groups["enum"].ToString());
            }

            return outPut;
        }

        private List<string> ParseStruct(string str)
        {
            List<string> outPut = new List<string>();
            string template = @"typedef struct[_\{\s\w=,/\*!<:;+-.>^\(\)#]*\}\s*(?<struct>(\w+))\s*;";

            Regex regex = new Regex(template);
            MatchCollection theMatches = regex.Matches(str);

            foreach (Match theMatch in theMatches)
            {
                outPut.Add(theMatch.Groups["struct"].ToString());
            }

            return outPut;
        }

        private void lstFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFunctions.SelectedIndex != -1)
            {
                string s = lstFunctions.SelectedItem.ToString();
                s = s.Substring(s.IndexOf(":") + 1);

                rtbCode.Find(s, RichTextBoxFinds.MatchCase);
                rtbCode.Focus();
            }
        }

        private void btnSelectSRS_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object
            OpenFileDialog openFile = new OpenFileDialog();
            // Initialize the filter to look for text files
            openFile.Filter = "xlsx File|*.xlsx|xls File|*.xls|All file|*.*";

            // If the user selected a file, load its contents into the RichTextBox
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                srsFileName = openFile.FileName;

                CollectRequirements();
            }
        }

        /* Requirements, used for tagging the activities/classes */
        private static Lookup<String, String> requirements;
        /* Requirements, used for tagging the req level and get function name */
        private static Lookup<String, String> reqLevelFuncs;
        private static void CollectRequirements()
        {
            /* Get the requirements excel files associated with the current driver */
            List<KeyValuePair<string, string>> reqList = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> reqListLevel = new List<KeyValuePair<string, string>>();

            worksheet reqSheet = Workbook.Worksheets(srsFileName).ToArray()[0];
            for (short i = 1; i < reqSheet.Rows.Count(); i++)
            {
                Cell reqID = reqSheet.Rows[i].Cells[0];
                Cell function = reqSheet.Rows[i].Cells[4];
                Cell reqLevel = reqSheet.Rows[i].Cells[1];

                if (function == null || reqID == null || reqLevel == null)
                    break;

                string strFunc = function.Text.Trim();
                string[] funcs = strFunc.Split(',');

                foreach (string func in funcs)
                {
                    reqList.Add(new KeyValuePair<string, string>(func.Trim(), reqID.Text));
                }

                if (funcs.Length == 1)
                {
                    reqListLevel.Add(new KeyValuePair<string, string>(reqLevel.Text, strFunc));
                }
            }

            requirements = (Lookup<string, string>)reqList.ToLookup((item) => item.Key, (item) => item.Value);
            reqLevelFuncs = (Lookup<string, string>)reqListLevel.ToLookup((item) => item.Key, (item) => item.Value);
        }

        List<bool> resultCompare = new List<bool>();
        List<string> srsFuncs = new List<string>();
        private void CompareCodeAndSRS()
        {
            srsFuncs.AddRange(reqLevelFuncs["HAL"].ToArray());
            srsFuncs.AddRange(reqLevelFuncs["DRV"].ToArray());

            foreach (string str in lstFunctions.Items)
            {
                bool ret = false;
                foreach (string item in srsFuncs)
                {
                    if (str.CompareTo(item) == 0)
                    {
                        ret = true;
                        break;
                    }
                }

                resultCompare.Add(ret);
            }
        }

        private void ShowResult()
        {
            lstResult.DrawMode = DrawMode.OwnerDrawFixed;
            lstFunctions.DrawMode = DrawMode.OwnerDrawFixed;

            lstResult.Items.Clear();
            for (int i = 0; i < resultCompare.Count; i++)
            {
                string s = String.Format("F{0}: {1}", i + 1, resultCompare[i]);
                lstResult.Items.Add(s);
            }

            lstFunctions.Items.Clear();
            for (int i = 0; i < allFuncs.Count; i++)
            {
                string s = String.Format("F{0}: {1}", i + 1, allFuncs[i]);
                lstFunctions.Items.Add(s);
            }
        }

        private void btnResultCompare_Click(object sender, EventArgs e)
        {
            CompareCodeAndSRS();
            ShowResult();
        }

        private void lstResult_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (lstResult.Items[e.Index].ToString().Contains("False"))
            {
                e.Graphics.DrawString(lstResult.Items[e.Index].ToString(), new Font("Arial", 10, FontStyle.Italic), Brushes.Red, e.Bounds);
            }
            else
            {
                e.Graphics.DrawString(lstResult.Items[e.Index].ToString(), new Font("Arial", 10, FontStyle.Italic), Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstFunctions_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (lstResult.Items[e.Index].ToString().Contains("False"))
            {
                e.Graphics.DrawString(lstFunctions.Items[e.Index].ToString(), new Font("Arial", 10, FontStyle.Italic), Brushes.Red, e.Bounds);
            }
            else
            {
                e.Graphics.DrawString(lstFunctions.Items[e.Index].ToString(), new Font("Arial", 10, FontStyle.Italic), Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void SaveListFunctions(List<string> lists, string fileName = "listFuncs.txt")
        {
            StreamWriter sw = new StreamWriter(fileName);
            try
            {
                using (sw)
                {
                    foreach (string item in lists)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SavePExDRVMethod(List<string> lists, string fileName = "module_methods.chg")
        {
            StreamWriter sw = new StreamWriter(fileName);
            try
            {
                using (sw)
                {
                    sw.WriteLine(@"%---- This file was generated by Doxy2Component");
                    foreach (string item in allFuncs)
                    {
                        sw.WriteLine("%:dummy=%setVariable(PEx_ImplementationModules4Method" + item + ",SDK/platform/hal/inc/module_driver.h)");
                    }
                    sw.WriteLine(@"%if %get(DeviceName,Exists?) = 'yes' & %get(DeviceName,IsEnabled) = 'yes'");
                    sw.WriteLine(@"  %:dev = %get(DeviceName,Value)");
                    foreach (string item in allFuncs)
                    {
                        sw.WriteLine("  %setVariable(PEx_ComponentMethodFirstParam4Method" + item + ",%get(DeviceName,Value)_INSTANCE)");
                    }
                    sw.WriteLine(@"  %undef dev");
                    sw.WriteLine("%endif");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SavePExHALMethod(List<string> lists, string fileName = "module_hal_methods.chg")
        {
            StreamWriter sw = new StreamWriter(fileName);
            try
            {
                using (sw)
                {
                    sw.WriteLine(@"%---- This file was generated by Doxy2Component");
                    foreach (string item in allFuncs)
                    {
                        sw.WriteLine("%:dummy=%setVariable(PEx_ImplementationModules4Method" + item + ",SDK/platform/hal/inc/module_hal.h)");
                    }
                    sw.WriteLine(@"%if %get(PeriphDevice,Exists?) = 'yes' & %get(PeriphDevice,IsEnabled) = 'yes'");
                    sw.WriteLine(@"%define! basePointer %get(PeriphDevice,SymbolValue[PeriphDevice_Name])");
                    foreach (string item in allFuncs)
                    {
                        sw.WriteLine("  %setVariable(PEx_ComponentMethodFirstParam4Method" + item + ",%'basePointer')");
                    }
                    sw.WriteLine(@"%undef! basePointer");
                    sw.WriteLine("%endif");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
