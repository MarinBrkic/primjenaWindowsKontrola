namespace primjenaWindowsKontrola
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
            this.groupBoxRunProgram = new System.Windows.Forms.GroupBox();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.cmbBoxProgram = new System.Windows.Forms.ComboBox();
            this.checkBoxShowProgram = new System.Windows.Forms.CheckBox();
            this.groupBoxPogramControl = new System.Windows.Forms.GroupBox();
            this.txtProgramDescription = new System.Windows.Forms.TextBox();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRunProgram.SuspendLayout();
            this.groupBoxPogramControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRunProgram
            // 
            this.groupBoxRunProgram.Controls.Add(this.btnRunProgram);
            this.groupBoxRunProgram.Controls.Add(this.cmbBoxProgram);
            this.groupBoxRunProgram.Location = new System.Drawing.Point(13, 35);
            this.groupBoxRunProgram.Name = "groupBoxRunProgram";
            this.groupBoxRunProgram.Size = new System.Drawing.Size(494, 138);
            this.groupBoxRunProgram.TabIndex = 0;
            this.groupBoxRunProgram.TabStop = false;
            this.groupBoxRunProgram.Text = "Run a program";
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(263, 58);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(153, 37);
            this.btnRunProgram.TabIndex = 1;
            this.btnRunProgram.Text = "Run program";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // cmbBoxProgram
            // 
            this.cmbBoxProgram.FormattingEnabled = true;
            this.cmbBoxProgram.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.cmbBoxProgram.Location = new System.Drawing.Point(7, 59);
            this.cmbBoxProgram.Name = "cmbBoxProgram";
            this.cmbBoxProgram.Size = new System.Drawing.Size(216, 28);
            this.cmbBoxProgram.TabIndex = 0;
            // 
            // checkBoxShowProgram
            // 
            this.checkBoxShowProgram.AutoSize = true;
            this.checkBoxShowProgram.Checked = true;
            this.checkBoxShowProgram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowProgram.Location = new System.Drawing.Point(13, 201);
            this.checkBoxShowProgram.Name = "checkBoxShowProgram";
            this.checkBoxShowProgram.Size = new System.Drawing.Size(185, 24);
            this.checkBoxShowProgram.TabIndex = 1;
            this.checkBoxShowProgram.Text = "Show program action";
            this.checkBoxShowProgram.UseVisualStyleBackColor = true;
            this.checkBoxShowProgram.CheckedChanged += new System.EventHandler(this.checkBoxShowProgram_CheckedChanged);
            // 
            // groupBoxPogramControl
            // 
            this.groupBoxPogramControl.Controls.Add(this.btnClear);
            this.groupBoxPogramControl.Controls.Add(this.label2);
            this.groupBoxPogramControl.Controls.Add(this.label1);
            this.groupBoxPogramControl.Controls.Add(this.txtProgramDescription);
            this.groupBoxPogramControl.Controls.Add(this.txtProgramName);
            this.groupBoxPogramControl.Location = new System.Drawing.Point(13, 252);
            this.groupBoxPogramControl.Name = "groupBoxPogramControl";
            this.groupBoxPogramControl.Size = new System.Drawing.Size(494, 230);
            this.groupBoxPogramControl.TabIndex = 2;
            this.groupBoxPogramControl.TabStop = false;
            this.groupBoxPogramControl.Text = "Program control";
            // 
            // txtProgramDescription
            // 
            this.txtProgramDescription.Location = new System.Drawing.Point(7, 116);
            this.txtProgramDescription.Multiline = true;
            this.txtProgramDescription.Name = "txtProgramDescription";
            this.txtProgramDescription.Size = new System.Drawing.Size(216, 98);
            this.txtProgramDescription.TabIndex = 1;
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(7, 55);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(216, 26);
            this.txtProgramName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program description:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 494);
            this.Controls.Add(this.groupBoxPogramControl);
            this.Controls.Add(this.checkBoxShowProgram);
            this.Controls.Add(this.groupBoxRunProgram);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRunProgram.ResumeLayout(false);
            this.groupBoxPogramControl.ResumeLayout(false);
            this.groupBoxPogramControl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRunProgram;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.ComboBox cmbBoxProgram;
        private System.Windows.Forms.CheckBox checkBoxShowProgram;
        private System.Windows.Forms.GroupBox groupBoxPogramControl;
        private System.Windows.Forms.TextBox txtProgramDescription;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

