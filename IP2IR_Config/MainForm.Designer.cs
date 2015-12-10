namespace IP2IR_Config
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPISpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_StartListening = new System.Windows.Forms.Button();
            this.b_TestCommand = new System.Windows.Forms.Button();
            this.t_Device = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_Function = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Command = new System.Windows.Forms.TextBox();
            this.b_SaveCmd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_IRCmdTest = new System.Windows.Forms.TextBox();
            this.b_StopListening = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPISpecToolStripMenuItem,
            this.quickHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aPISpecToolStripMenuItem
            // 
            this.aPISpecToolStripMenuItem.Name = "aPISpecToolStripMenuItem";
            this.aPISpecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aPISpecToolStripMenuItem.Text = "API Spec";
            // 
            // quickHelpToolStripMenuItem
            // 
            this.quickHelpToolStripMenuItem.Name = "quickHelpToolStripMenuItem";
            this.quickHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickHelpToolStripMenuItem.Text = "Quick Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // b_StartListening
            // 
            this.b_StartListening.Location = new System.Drawing.Point(36, 443);
            this.b_StartListening.Name = "b_StartListening";
            this.b_StartListening.Size = new System.Drawing.Size(125, 23);
            this.b_StartListening.TabIndex = 3;
            this.b_StartListening.Text = "Start Listening";
            this.b_StartListening.UseVisualStyleBackColor = true;
            // 
            // b_TestCommand
            // 
            this.b_TestCommand.Location = new System.Drawing.Point(457, 443);
            this.b_TestCommand.Name = "b_TestCommand";
            this.b_TestCommand.Size = new System.Drawing.Size(98, 23);
            this.b_TestCommand.TabIndex = 4;
            this.b_TestCommand.Text = "Test Command";
            this.b_TestCommand.UseVisualStyleBackColor = true;
            // 
            // t_Device
            // 
            this.t_Device.Location = new System.Drawing.Point(478, 41);
            this.t_Device.Name = "t_Device";
            this.t_Device.Size = new System.Drawing.Size(100, 20);
            this.t_Device.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Function";
            // 
            // t_Function
            // 
            this.t_Function.Location = new System.Drawing.Point(478, 67);
            this.t_Function.Name = "t_Function";
            this.t_Function.Size = new System.Drawing.Size(100, 20);
            this.t_Function.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Command";
            // 
            // t_Command
            // 
            this.t_Command.Location = new System.Drawing.Point(478, 93);
            this.t_Command.Name = "t_Command";
            this.t_Command.Size = new System.Drawing.Size(100, 20);
            this.t_Command.TabIndex = 9;
            // 
            // b_SaveCmd
            // 
            this.b_SaveCmd.Location = new System.Drawing.Point(461, 119);
            this.b_SaveCmd.Name = "b_SaveCmd";
            this.b_SaveCmd.Size = new System.Drawing.Size(98, 23);
            this.b_SaveCmd.TabIndex = 11;
            this.b_SaveCmd.Text = "Save Command";
            this.b_SaveCmd.UseVisualStyleBackColor = true;
            this.b_SaveCmd.Click += new System.EventHandler(this.b_SaveCmd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.t_IRCmdTest);
            this.panel1.Controls.Add(this.b_StopListening);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.b_TestCommand);
            this.panel1.Controls.Add(this.b_StartListening);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 502);
            this.panel1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 121);
            this.listBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Incoming IR Commands";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Command for Testing";
            // 
            // t_IRCmdTest
            // 
            this.t_IRCmdTest.Location = new System.Drawing.Point(36, 417);
            this.t_IRCmdTest.Name = "t_IRCmdTest";
            this.t_IRCmdTest.Size = new System.Drawing.Size(519, 20);
            this.t_IRCmdTest.TabIndex = 8;
            // 
            // b_StopListening
            // 
            this.b_StopListening.Location = new System.Drawing.Point(243, 443);
            this.b_StopListening.Name = "b_StopListening";
            this.b_StopListening.Size = new System.Drawing.Size(125, 23);
            this.b_StopListening.TabIndex = 6;
            this.b_StopListening.Text = "Stop Listening";
            this.b_StopListening.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 529);
            this.Controls.Add(this.b_SaveCmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_Command);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_Function);
            this.Controls.Add(this.t_Device);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "iTach IP2IR Config and Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Button b_StartListening;
        private System.Windows.Forms.Button b_TestCommand;
        private System.Windows.Forms.TextBox t_Device;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_Function;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Command;
        private System.Windows.Forms.Button b_SaveCmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button b_StopListening;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPISpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_IRCmdTest;
        private System.Windows.Forms.ListBox listBox1;
    }
}

