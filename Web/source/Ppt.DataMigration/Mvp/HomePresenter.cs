using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;
using Ppt.DataMigration.Services;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Mvp
{
    public class HomePresenter : IPresenter
    {
        ILogger _logger = new NullLogger();
        public ILogger Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                _logger = value;
            }

        }

        public IDatabaseMigrationService YogaMigration { get; set; }
        public IDatabaseMigrationService FriendsMigration { get; set; }
        public IDatabaseMigrationService PrisonerMigration { get; set; }

        IHomeView _view;
        public HomePresenter(
            IHomeView view)
        {
            _logger.Info("Home presenter created");

            _view = view;
        }

        public void StartMigartion()
        {
            List<string> errors = new List<string>();
            if (_view.SqlServerName.IsNullOrEmpty())
                errors.Add("Enter a SQL Server name");
            if (_view.SqlServerDatabase.IsNullOrEmpty())
                errors.Add("Enter a SQL Database name");
            if (_view.SqlServerUsername.IsNullOrEmpty())
                errors.Add("Enter a SQL Server username");
            if (_view.SqlServerPassword.IsNullOrEmpty())
                errors.Add("Enter a SQL Server password");

            if (errors.Count > 0)
            {
                _view.Errors = errors;
                _view.Action(HomeActions.DisplayErrors);
                return;
            }


            var t = new Task(() =>
            {
                _view.Progress.PercentComplete = 1;
                SendMessage("Starting Migration Process");

                SendMessage("Configuring SQL Connection string...");

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server={0};Database={1};User ID={2};Password={3};Trusted_Connection=False;".Formatted(
                    _view.SqlServerName, _view.SqlServerDatabase, _view.SqlServerUsername, _view.SqlServerPassword);

                SendMessage("SQL Connection String Configured, Woot!!");
                
                _view.Progress.PercentComplete = 20;

                #region BuildDatabase

                SendMessage("Starting to rebuild the databases. Were getting out the hammer and nails");

                DatabaseBuilderService dbBuilder = new DatabaseBuilderService();
                dbBuilder.Build(connection);

                SendMessage("Database rebuilt. Time for a tea break before we get started on the next task");

                #endregion



                #region YOGA

                SendMessage("Starting Yoga DB Migration. Exciting stuff");

                if (!_view.YogaDatabase.IsNullOrEmpty() && this.YogaMigration != null)
                {
                    this.YogaMigration.Migrate(_view.YogaDatabase, connection);
                    SendMessage("Yoga migration complete. Party!!!");
                }
                else SendMessage("Yoga migration not setup, migration cancelled... booo");

                _view.Progress.PercentComplete = 40;

                #endregion
                #region Friends

                SendMessage("Starting Friends Migration. Awesome");

                if (!_view.FriendsDatabase.IsNullOrEmpty() && this.FriendsMigration != null)
                {
                    this.FriendsMigration.Migrate(_view.FriendsDatabase, connection);
                    SendMessage("Friends migration complete. Order some champaign");
                }
                else SendMessage("Friends migration not setup, migration cancelled... shame, maybe next time");

                _view.Progress.PercentComplete = 60;


                #endregion
                #region Prisoner

                SendMessage("Starting Prisoner Migration. Sweet");

                if (!_view.PrisonerDatabase.IsNullOrEmpty() && this.PrisonerMigration != null)
                {
                    this.PrisonerMigration.Migrate(_view.PrisonerDatabase, connection);
                    SendMessage("Prisoner migration complete. Order some champaign");
                }
                else SendMessage("Prisoner migration not setup, migration cancelled... ahh well it wasn't meant to be");
                _view.Progress.PercentComplete = 80;

                #endregion
                _view.Progress.Message = "Complete... Time to put your feet up";
                _view.Progress.PercentComplete = 99;
                Thread.Sleep(2000);
                _view.Progress.PercentComplete = 100;

            });

            t.Start();

            _view.Action(HomeActions.DisplayProgressBar);

            t.Wait();


            if (errors.Count > 0)
            {
                _view.Errors = errors;
                _view.Action(HomeActions.DisplayErrors);
                return;
            }


        }

        private void SendMessage(string message)
        {
            _view.Progress.Message = message;
            Thread.Sleep(2000);
        }
    }
}
