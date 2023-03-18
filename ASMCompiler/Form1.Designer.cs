namespace SimASM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.process1 = new System.Diagnostics.Process();
            this.runButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CodeSource = new System.Windows.Forms.RichTextBox();
            this.CompileResults = new System.Windows.Forms.DataGridView();
            this.LineNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compileAndRunButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.workDirTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBeforeCompileCheckBox = new System.Windows.Forms.CheckBox();
            this.makeComCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.saveFileAsButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompileResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(687, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // process1
            // 
            this.process1.StartInfo.CreateNoWindow = true;
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.ErrorDialog = true;
            this.process1.StartInfo.FileName = "C:\\Projects\\Asembler\\ConsoleApplication1\\bin\\Debug\\out.exe";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.RedirectStandardInput = true;
            this.process1.StartInfo.RedirectStandardOutput = true;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.process1_OutputDataReceived);
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runButton.Location = new System.Drawing.Point(19, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 28);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compileButton.Location = new System.Drawing.Point(120, 4);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(96, 28);
            this.compileButton.TabIndex = 3;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 309);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 215);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 186);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Run";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(686, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(681, 183);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // CodeSource
            // 
            this.CodeSource.AcceptsTab = true;
            this.CodeSource.HideSelection = false;
            this.CodeSource.Location = new System.Drawing.Point(1, 0);
            this.CodeSource.Name = "CodeSource";
            this.CodeSource.Size = new System.Drawing.Size(438, 228);
            this.CodeSource.TabIndex = 5;
            this.CodeSource.Text = "";
            this.CodeSource.TextChanged += new System.EventHandler(this.CodeSource_TextChanged);
            // 
            // CompileResults
            // 
            this.CompileResults.AllowUserToAddRows = false;
            this.CompileResults.AllowUserToDeleteRows = false;
            this.CompileResults.AllowUserToOrderColumns = true;
            this.CompileResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompileResults.ColumnHeadersVisible = false;
            this.CompileResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNumer,
            this.Address,
            this.Code,
            this.Source});
            this.CompileResults.Location = new System.Drawing.Point(0, 0);
            this.CompileResults.Name = "CompileResults";
            this.CompileResults.RowHeadersVisible = false;
            this.CompileResults.RowTemplate.Height = 18;
            this.CompileResults.RowTemplate.ReadOnly = true;
            this.CompileResults.Size = new System.Drawing.Size(461, 232);
            this.CompileResults.TabIndex = 6;
            // 
            // LineNumer
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LineNumer.DefaultCellStyle = dataGridViewCellStyle1;
            this.LineNumer.HeaderText = "Line #";
            this.LineNumer.Name = "LineNumer";
            this.LineNumer.ReadOnly = true;
            this.LineNumer.Width = 45;
            // 
            // Address
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.Address.DefaultCellStyle = dataGridViewCellStyle2;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 50;
            // 
            // Code
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Machine code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 120;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Source.HeaderText = "Source line";
            this.Source.Name = "Source";
            // 
            // compileAndRunButton
            // 
            this.compileAndRunButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compileAndRunButton.Location = new System.Drawing.Point(222, 4);
            this.compileAndRunButton.Name = "compileAndRunButton";
            this.compileAndRunButton.Size = new System.Drawing.Size(93, 28);
            this.compileAndRunButton.TabIndex = 7;
            this.compileAndRunButton.Text = "Compile && Run";
            this.compileAndRunButton.UseVisualStyleBackColor = true;
            this.compileAndRunButton.Click += new System.EventHandler(this.compileAndRunButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.workDirTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveBeforeCompileCheckBox);
            this.groupBox1.Controls.Add(this.makeComCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(715, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // workDirTextBox
            // 
            this.workDirTextBox.Location = new System.Drawing.Point(6, 188);
            this.workDirTextBox.Name = "workDirTextBox";
            this.workDirTextBox.Size = new System.Drawing.Size(155, 20);
            this.workDirTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Working directory";
            // 
            // saveBeforeCompileCheckBox
            // 
            this.saveBeforeCompileCheckBox.AutoSize = true;
            this.saveBeforeCompileCheckBox.Checked = true;
            this.saveBeforeCompileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveBeforeCompileCheckBox.Location = new System.Drawing.Point(6, 43);
            this.saveBeforeCompileCheckBox.Name = "saveBeforeCompileCheckBox";
            this.saveBeforeCompileCheckBox.Size = new System.Drawing.Size(187, 18);
            this.saveBeforeCompileCheckBox.TabIndex = 1;
            this.saveBeforeCompileCheckBox.Text = "Save before compilation";
            this.saveBeforeCompileCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeComCheckBox
            // 
            this.makeComCheckBox.AutoSize = true;
            this.makeComCheckBox.Checked = true;
            this.makeComCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.makeComCheckBox.Location = new System.Drawing.Point(6, 19);
            this.makeComCheckBox.Name = "makeComCheckBox";
            this.makeComCheckBox.Size = new System.Drawing.Size(124, 18);
            this.makeComCheckBox.TabIndex = 0;
            this.makeComCheckBox.Text = "Make com files";
            this.makeComCheckBox.UseVisualStyleBackColor = true;
            this.makeComCheckBox.CheckedChanged += new System.EventHandler(this.makeComCheckBox_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(467, 41);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(469, 262);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CompileResults);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(461, 232);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Compilation Table";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.treeView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(461, 231);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Operators Library";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(461, 229);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl3
            // 
            this.tabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl3.Controls.Add(this.fileTabPage);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(18, 41);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(447, 262);
            this.tabControl3.TabIndex = 10;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.CodeSource);
            this.fileTabPage.Location = new System.Drawing.Point(4, 26);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileTabPage.Size = new System.Drawing.Size(439, 232);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "try.asm";
            this.fileTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(439, 231);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "(binary result)";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(439, 232);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(685, 4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(78, 28);
            this.openFileButton.TabIndex = 11;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(769, 4);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(78, 28);
            this.saveFileButton.TabIndex = 12;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // saveFileAsButton
            // 
            this.saveFileAsButton.Location = new System.Drawing.Point(853, 4);
            this.saveFileAsButton.Name = "saveFileAsButton";
            this.saveFileAsButton.Size = new System.Drawing.Size(78, 28);
            this.saveFileAsButton.TabIndex = 11;
            this.saveFileAsButton.Text = "Save As";
            this.saveFileAsButton.UseVisualStyleBackColor = true;
            this.saveFileAsButton.Click += new System.EventHandler(this.saveFileAsButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.saveFileAsButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compileAndRunButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.runButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "SimASM";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompileResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.fileTabPage.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox CodeSource;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView CompileResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.Button compileAndRunButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox makeComCheckBox;
        private System.Windows.Forms.CheckBox saveBeforeCompileCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox workDirTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.Button saveFileAsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

