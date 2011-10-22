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
    public partial class Form1 : Form, IHomeView
    {
        HomePresenter _presenter;
        ProgressBar _progressBar;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrisonerButton_Click(object sender, EventArgs e)
        {
            FileButtonClick(PrisonerTextBox, PrisonerFileDialog);
        }

        private void FileButtonClick(TextBox textBox, FileDialog dialog)
        {
            var result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = dialog.FileName;
            }
            else
            {
                textBox.Text = "";
            }
        }

        private void YogaButton_Click(object sender, EventArgs e)
        {
            FileButtonClick(YogaTextBox, YogaFileDialog);
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            FileButtonClick(FriendsTextBox, FriendsFileDialog);

        }



        string IHomeView.SqlServerName
        {
            get { return SqlServerName.Text; }
        }

        string IHomeView.SqlServerDatabase
        {
            get { return SqlServerDatabase.Text; }
        }

        string IHomeView.SqlServerUsername
        {
            get { return SqlServerUsername.Text ; }
        }

        string IHomeView.SqlServerPassword
        {
            get { return SqlServerPassword.Text; }
        }

        public string YogaDatabase
        {
            get { return YogaFileDialog.FileName; }
        }

        public string FriendsDatabase
        {
            get { return FriendsFileDialog.FileName; }
        }

        public string PrisonerDatabase
        {
            get { return PrisonerFileDialog.FileName; }
        }

        public void Action(HomeActions action)
        {
            switch (action)
            {
                case HomeActions.DisplayErrors:

                    DisplayErrors();
                    break;
                case HomeActions.DisplayProgressBar:
                    _progressBar.ShowDialog();
                    break;
                case HomeActions.HideProgressBar:
                        _progressBar.Hide();
                    break;
                default:
                    MessageBox.Show("HomeAction not handled");
                    break;
            }

        }

        private void DisplayErrors()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Please correct the following errors:");
            foreach (var error in Errors)
                sb.AppendLine("\t"+error);
            MessageBox.Show(sb.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDictionary<string,object> args = new Dictionary<string, object>();
            args.Add("view", this);
            _presenter = CastleConfig.Resolve<HomePresenter>(args);

            _progressBar = new ProgressBar();

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            _presenter.StartMigartion();

           


        }

        public IEnumerable<string> Errors { get; set; }

        public IProgressView Progress
        {
            get
            {
                return _progressBar;
            }
        }
    }
}

      
