using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IP2IR_Config
{
    public partial class MainForm : Form
    {
        SQLiteConnection m_dbConnection;
        bool dbExists = true;

        public MainForm()
        {
            InitializeComponent();
            string databaseFile = @"ip2ir.sqlite";
            
            //SQLite Stuff
            if (!File.Exists(databaseFile)) 
            { 
                SQLiteConnection.CreateFile(databaseFile);
                dbExists = false;
            }
            
            m_dbConnection = new SQLiteConnection("Data Source=" + databaseFile + ";Version=3;");
            m_dbConnection.Open();
            if (!dbExists) 
            {
                string sql = "create table ir_commands (device varchar(32), function varchar(32), command varchar(256))";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_dbConnection.Close();
            Application.Exit();
        }

        private void b_SaveCmd_Click(object sender, EventArgs e)
        {
            //Generate SQL Query
            string sql = "insert into ir_commands (device, function, command) values (" + t_Device.Text + ", " + t_Function.Text + ", " + t_Command.Text + ")";
            
            //Execute query
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            //Clear boxes after save
            t_Device.Text = @"";
            t_Function.Text = @"";
            t_Command.Text = @"";

            //Display message
            MessageBox.Show("Command Saved!");
        }
    }
}
