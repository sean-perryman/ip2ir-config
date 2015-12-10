using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IP2IR_Config
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void b_SaveCmd_Click(object sender, EventArgs e)
        {
            //Clear boxes after save
            t_Device.Text = @"";
            t_Function.Text = @"";
            t_Command.Text = @"";

            //Display message
            MessageBox.Show("Command Saved!");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }
    }
}
