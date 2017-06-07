using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clear_Projects_VS
{
    public partial class Form1 : Form
    {

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }



        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            chkSdf.Checked = true;
            chkIpch.Checked = true;
            chkObjFile.Checked = true;
            chkPdb.Checked = true;
            chkIlk.Checked = true;
            chkDebug.Checked = false;
            chkRelease.Checked = false;
        }


        #endregion


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDialog = new FolderBrowserDialog();

            if(txtProjectsPath.Text.Length > 0)
                fDialog.SelectedPath = txtProjectsPath.Text;

            if(fDialog.ShowDialog() == DialogResult.OK)
            {
                txtProjectsPath.Text = fDialog.SelectedPath;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(txtProjectsPath.Text.Length == 0)
            {
                MessageBox.Show("Select a path to Clear", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtLog.Text = String.Empty;

            if(ClearProjects(txtProjectsPath.Text) == true)
            {
                MessageBox.Show("Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            chkSdf.Checked = true;
            chkIpch.Checked = true;
            chkObjFile.Checked = true;
            chkPdb.Checked = true;
            chkIlk.Checked = true;
            chkDebug.Checked = true;
            chkRelease.Checked = true;
            chkObjDir.Checked = true;
            chkBinDir.Checked = true;
            chkSuoFiles.Checked = true;
            chkUserFiles.Checked = true;
            chkNcbFiles.Checked = true;

        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            chkSdf.Checked = false;
            chkIpch.Checked = false;
            chkObjFile.Checked = false;
            chkPdb.Checked = false;
            chkIlk.Checked = false;
            chkDebug.Checked = false;
            chkRelease.Checked = false;
            chkObjDir.Checked = false;
            chkBinDir.Checked = false;
            chkSuoFiles.Checked = false;
            chkUserFiles.Checked = false;
            chkNcbFiles.Checked = false;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            chkSdf.Checked = true;
            chkIpch.Checked = true;
            chkObjFile.Checked = true;
            chkPdb.Checked = true;
            chkIlk.Checked = true;
            chkDebug.Checked = false;
            chkRelease.Checked = false;
            chkObjDir.Checked = false;
            chkBinDir.Checked = false;
            chkSuoFiles.Checked = false;
            chkUserFiles.Checked = false;
            chkNcbFiles.Checked = false;
        }



        #endregion

        #region Methods

        public bool ClearProjects(string sDir)
        {


            if(chkSdf.Checked == true)
            {
                WriteLine("Clear SDF File");
                DirSearch(sDir, "*.sdf");
            }
            if (chkIpch.Checked == true)
            {
                WriteLine("Clear ipch Directory");
                DeleteDirectory(sDir, "ipch");
            }
            if (chkObjFile.Checked == true)
            {
                WriteLine("Clear OBJ File");
                DirSearch(sDir, "*.obj");
            }
            if (chkPdb.Checked == true)
            {
                WriteLine("Clear PDB File");
                DirSearch(sDir, "*.pdb");
            }
            if (chkIlk.Checked == true)
            {
                WriteLine("Clear ILK File");
                DirSearch(sDir, "*.ilk");
            }
            if (chkDebug.Checked == true)
            {
                WriteLine("Clear Debug Directory");
                DeleteDirectory(sDir, "Debug");
            }
            if (chkRelease.Checked == true)
            {
                WriteLine("Clear Release Directory");
                DeleteDirectory(sDir, "Release");
            }

            if (chkObjDir.Checked == true)
            {
                WriteLine("Clear obj Directory");
                DeleteDirectory(sDir, "obj");
            }

            if (chkBinDir.Checked == true)
            {
                WriteLine("Clear bin Directory");
                DeleteDirectory(sDir, "bin");
            }
            if(chkSuoFiles.Checked == true)
            {
                WriteLine("Clear suo File");
                DirSearch(sDir, "*.suo");
            }
            if(chkUserFiles.Checked == true)
            {
                WriteLine("Clear USER File");
                DirSearch(sDir, "*.user");
            }
            if(chkNcbFiles.Checked == true)
            {
                WriteLine("Clear NCB File");
                DirSearch(sDir, "*.ncb");
            }


            return true;

        }

        private void DeleteDirectory(string sDir, string DirName)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {
                foreach( string sd in Directory.GetDirectories(d, DirName))
                {
                    Directory.Delete(sd, true);
                    WriteLine("Directory : " + d);
                }
                DeleteDirectory(d, DirName);
            }
        }

        private void DirSearch(string sDir, string pattern)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    string[] files = Directory.GetFiles(d, pattern);

                    if (files.Length > 0)
                    {
                        WriteLine("Directory : " + d);
                        foreach (string f in files)
                        {
                            WriteLine("File : " + Path.GetFileName(f));
                            File.Delete(f);
                        }
                    }
                    DirSearch(d, pattern);
                }
            }
            catch (System.Exception excpt)
            {
                WriteLine(excpt.Message);
            }

        }

        #endregion

        #region Trace
        public void WriteLine(string text)
        {
            String s = text + Environment.NewLine;
            Print(s);

        }


        public void Print(string format, params object[] obj)
        {
            String s;
            s = " - " + String.Format(format, obj);
            txtLog.AddText(s);


        }

        #endregion

    }




}
