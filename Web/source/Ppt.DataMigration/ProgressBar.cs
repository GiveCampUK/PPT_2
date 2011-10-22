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
                if (value > migrationProgress.Maximum) migrationProgress.Value = migrationProgress.Maximum;
                if (value < migrationProgress.Minimum) migrationProgress.Value = migrationProgress.Minimum;
                migrationProgress.Value = value;                    
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
                migrationMessage.Text = value;
            }
        }
    }
}
