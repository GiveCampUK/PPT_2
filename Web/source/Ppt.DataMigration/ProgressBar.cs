using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ppt.DataMigration.Mvp;

namespace Ppt.DataMigration
{
    public partial class ProgressBar : Form, IProgressView
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }

        public int PercentComplete
        {
            get
            {
                return migrationProgress.Value;
            }
            set
            {
                if (value > migrationProgress.Maximum) value = migrationProgress.Maximum;
                if (value < migrationProgress.Minimum) value = migrationProgress.Minimum;

               

                if (this.migrationProgress.InvokeRequired)
                {
                    SetIntCallback d = new SetIntCallback(x => { 
                        this.migrationProgress.Value = x;
                        if (migrationProgress.Maximum == value)
                        {
                            this.Hide();
                        }
                    });
                    this.Invoke(d, new object[] { value });
                }
                else
                {
                    this.migrationProgress.Value = value;
                }
            }
        }

        public string Message
        {
            get
            {
                return migrationMessage.Text;
            }
            set
            {
                // InvokeRequired required compares the thread ID of the
                // calling thread to the thread ID of the creating thread.
                // If these threads are different, it returns true.
                if (this.migrationMessage.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(x => { this.migrationMessage.Text = x; });
                    this.Invoke(d, new object[] { value });
                }
                else
                {
                    this.migrationMessage.Text = value;
                }
            }
        }
        delegate void SetTextCallback(string text);
        delegate void SetIntCallback(int text);
    }
}
