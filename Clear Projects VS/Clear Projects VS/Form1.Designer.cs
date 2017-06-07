namespace Clear_Projects_VS
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProjectsPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.chkRelease = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkIlk = new System.Windows.Forms.CheckBox();
            this.chkPdb = new System.Windows.Forms.CheckBox();
            this.chkObjFile = new System.Windows.Forms.CheckBox();
            this.chkIpch = new System.Windows.Forms.CheckBox();
            this.chkSdf = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new Clear_Projects_VS.AutoscrollTextBox();
            this.chkObjDir = new System.Windows.Forms.CheckBox();
            this.chkBinDir = new System.Windows.Forms.CheckBox();
            this.chkSuoFiles = new System.Windows.Forms.CheckBox();
            this.chkUserFiles = new System.Windows.Forms.CheckBox();
            this.chkNcbFiles = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProjectsPath
            // 
            this.txtProjectsPath.Location = new System.Drawing.Point(27, 66);
            this.txtProjectsPath.Name = "txtProjectsPath";
            this.txtProjectsPath.Size = new System.Drawing.Size(385, 20);
            this.txtProjectsPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(424, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the Projects Path :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNcbFiles);
            this.groupBox1.Controls.Add(this.chkUserFiles);
            this.groupBox1.Controls.Add(this.chkSuoFiles);
            this.groupBox1.Controls.Add(this.chkBinDir);
            this.groupBox1.Controls.Add(this.chkObjDir);
            this.groupBox1.Controls.Add(this.btnDefault);
            this.groupBox1.Controls.Add(this.btnUnselectAll);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.chkRelease);
            this.groupBox1.Controls.Add(this.chkDebug);
            this.groupBox1.Controls.Add(this.chkIlk);
            this.groupBox1.Controls.Add(this.chkPdb);
            this.groupBox1.Controls.Add(this.chkObjFile);
            this.groupBox1.Controls.Add(this.chkIpch);
            this.groupBox1.Controls.Add(this.chkSdf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Options";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(383, 91);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(101, 23);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(383, 62);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(101, 23);
            this.btnUnselectAll.TabIndex = 3;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(383, 33);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(101, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // chkRelease
            // 
            this.chkRelease.AutoSize = true;
            this.chkRelease.Location = new System.Drawing.Point(88, 200);
            this.chkRelease.Name = "chkRelease";
            this.chkRelease.Size = new System.Drawing.Size(110, 17);
            this.chkRelease.TabIndex = 2;
            this.chkRelease.Text = "Release Directory";
            this.chkRelease.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(88, 177);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(103, 17);
            this.chkDebug.TabIndex = 1;
            this.chkDebug.Text = "Debug Directory";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkIlk
            // 
            this.chkIlk.AutoSize = true;
            this.chkIlk.Location = new System.Drawing.Point(88, 154);
            this.chkIlk.Name = "chkIlk";
            this.chkIlk.Size = new System.Drawing.Size(63, 17);
            this.chkIlk.TabIndex = 1;
            this.chkIlk.Text = ".ilk Files";
            this.chkIlk.UseVisualStyleBackColor = true;
            // 
            // chkPdb
            // 
            this.chkPdb.AutoSize = true;
            this.chkPdb.Location = new System.Drawing.Point(88, 131);
            this.chkPdb.Name = "chkPdb";
            this.chkPdb.Size = new System.Drawing.Size(71, 17);
            this.chkPdb.TabIndex = 1;
            this.chkPdb.Text = ".pdb Files";
            this.chkPdb.UseVisualStyleBackColor = true;
            // 
            // chkObjFile
            // 
            this.chkObjFile.AutoSize = true;
            this.chkObjFile.Location = new System.Drawing.Point(88, 108);
            this.chkObjFile.Name = "chkObjFile";
            this.chkObjFile.Size = new System.Drawing.Size(67, 17);
            this.chkObjFile.TabIndex = 1;
            this.chkObjFile.Text = ".obj Files";
            this.chkObjFile.UseVisualStyleBackColor = true;
            // 
            // chkIpch
            // 
            this.chkIpch.AutoSize = true;
            this.chkIpch.Location = new System.Drawing.Point(88, 85);
            this.chkIpch.Name = "chkIpch";
            this.chkIpch.Size = new System.Drawing.Size(91, 17);
            this.chkIpch.TabIndex = 1;
            this.chkIpch.Text = "ipch Directory";
            this.chkIpch.UseVisualStyleBackColor = true;
            // 
            // chkSdf
            // 
            this.chkSdf.AutoSize = true;
            this.chkSdf.Location = new System.Drawing.Point(88, 62);
            this.chkSdf.Name = "chkSdf";
            this.chkSdf.Size = new System.Drawing.Size(67, 17);
            this.chkSdf.TabIndex = 1;
            this.chkSdf.Text = ".sdf Files";
            this.chkSdf.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Element to Clear :";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(549, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(273, 457);
            this.txtLog.TabIndex = 8;
            // 
            // chkObjDir
            // 
            this.chkObjDir.AutoSize = true;
            this.chkObjDir.Location = new System.Drawing.Point(88, 223);
            this.chkObjDir.Name = "chkObjDir";
            this.chkObjDir.Size = new System.Drawing.Size(85, 17);
            this.chkObjDir.TabIndex = 5;
            this.chkObjDir.Text = "obj Directory";
            this.chkObjDir.UseVisualStyleBackColor = true;
            // 
            // chkBinDir
            // 
            this.chkBinDir.AutoSize = true;
            this.chkBinDir.Location = new System.Drawing.Point(235, 62);
            this.chkBinDir.Name = "chkBinDir";
            this.chkBinDir.Size = new System.Drawing.Size(85, 17);
            this.chkBinDir.TabIndex = 5;
            this.chkBinDir.Text = "bin Directory";
            this.chkBinDir.UseVisualStyleBackColor = true;
            // 
            // chkSuoFiles
            // 
            this.chkSuoFiles.AutoSize = true;
            this.chkSuoFiles.Location = new System.Drawing.Point(235, 85);
            this.chkSuoFiles.Name = "chkSuoFiles";
            this.chkSuoFiles.Size = new System.Drawing.Size(70, 17);
            this.chkSuoFiles.TabIndex = 5;
            this.chkSuoFiles.Text = ".suo Files";
            this.chkSuoFiles.UseVisualStyleBackColor = true;
            // 
            // chkUserFiles
            // 
            this.chkUserFiles.AutoSize = true;
            this.chkUserFiles.Location = new System.Drawing.Point(235, 108);
            this.chkUserFiles.Name = "chkUserFiles";
            this.chkUserFiles.Size = new System.Drawing.Size(73, 17);
            this.chkUserFiles.TabIndex = 5;
            this.chkUserFiles.Text = ".user Files";
            this.chkUserFiles.UseVisualStyleBackColor = true;
            // 
            // chkNcbFiles
            // 
            this.chkNcbFiles.AutoSize = true;
            this.chkNcbFiles.Location = new System.Drawing.Point(235, 131);
            this.chkNcbFiles.Name = "chkNcbFiles";
            this.chkNcbFiles.Size = new System.Drawing.Size(71, 17);
            this.chkNcbFiles.TabIndex = 5;
            this.chkNcbFiles.Text = ".ncb Files";
            this.chkNcbFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtProjectsPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clear Projects VS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectsPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkIlk;
        private System.Windows.Forms.CheckBox chkPdb;
        private System.Windows.Forms.CheckBox chkObjFile;
        private System.Windows.Forms.CheckBox chkIpch;
        private System.Windows.Forms.CheckBox chkSdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRelease;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDefault;
        private AutoscrollTextBox txtLog;
        private System.Windows.Forms.CheckBox chkObjDir;
        private System.Windows.Forms.CheckBox chkBinDir;
        private System.Windows.Forms.CheckBox chkUserFiles;
        private System.Windows.Forms.CheckBox chkSuoFiles;
        private System.Windows.Forms.CheckBox chkNcbFiles;
    }
}

