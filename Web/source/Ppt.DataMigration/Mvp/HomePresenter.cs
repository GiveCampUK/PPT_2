using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;
using Ppt.DataMigration.Services;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

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

        public AbstractMigrationService YogaMigration { get; set; }
        public AbstractMigrationService FriendsMigration { get; set; }
        public AbstractMigrationService PrisonerMigration { get; set; }

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


            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                _view.Progress.Terminate();

                if (e.Error != null)
                {
                    errors.Add("There was a problem during the import process which meant the importer could not complete.");
                    errors.Add("Please check the error logs for further information.");
                }
                else if (e.Cancelled)
                {
                    errors.Add("The import was cancelled by something");
                }
                else
                {
                    _view.Action(HomeActions.ImportComplete);
                }

                if (errors.Count > 0)
                {
                    _view.Errors = errors;
                    _view.Action(HomeActions.DisplayErrors);
                    return;
                }
            };

            worker.ProgressChanged += (object sender, ProgressChangedEventArgs e) =>
            {
                _view.Progress.PercentComplete = e.ProgressPercentage;

                var getMessage = new Func<string>(() =>
                {
                    switch (e.ProgressPercentage)
                    {
                        case 1:
                            return "Starting Migration Process";
                        case 10:
                            return "Configuring SQL Connection string...";
                        case 20 :
                            return "SQL Connection String Configured, Woot!!";
                        case 30:
                            return "Starting to rebuild the databases. Were getting out the hammer and nails";
                        case 40:
                            return "Database rebuilt. Time for a tea break before we get started on the next task";
                        case 45:
                            return "Starting Yoga DB Migration. Exciting stuff";
                        case 50:
                            return "Yoga migration complete. Party!!!";
                        case 55:
                            return "Yoga migration not setup, migration cancelled... booo";
                        case 60:
                            return "Starting Friends Migration. Awesome";
                        case 70:
                            return "Friends migration complete. Order some champaign";
                        case 75:
                            return "Friends migration not setup, migration cancelled... shame, maybe next time";
                        case 80:
                            return "Starting Prisoner Migration. Sweet";
                        case 90:
                            return "Prisoner migration complete. Order some champaign";
                        case 95:
                            return "Prisoner migration not setup, migration cancelled... ahh well it wasn't meant to be";
                        case 99:
                            return "Complete... Time to put your feet up";
                        default:
                            return "Some message was meant to be sent";
                    }
                });

                _view.Progress.Message = getMessage();
            };


            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                BackgroundWorker tempWorker = sender as BackgroundWorker;

                try
                {
                    AsynTask(tempWorker);
                }
                catch (Exception ex)
                {
                    Logger.Error("Error during import", ex);
                    throw ex;
                }
            
            };

            worker.RunWorkerAsync();

            _view.Action(HomeActions.DisplayProgressBar);

        }

        private void AsynTask(BackgroundWorker tempWorker)
        {
            tempWorker.ReportProgress(1);
            tempWorker.ReportProgress(10);

            SqlConnection connection = new SqlConnection();

            try
            {

                connection.ConnectionString = "Server={0};User ID={2};Password={3};Trusted_Connection=False;".Formatted(
                    _view.SqlServerName, _view.SqlServerDatabase, _view.SqlServerUsername, _view.SqlServerPassword);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to create SQL Connection string", ex);
            }

            tempWorker.ReportProgress(20);

            #region BuildDatabase

            tempWorker.ReportProgress(30);

            try
            {
                DatabaseBuilderService dbBuilder = new DatabaseBuilderService();
                dbBuilder.Build(connection, _view.SqlServerDatabase);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to build database schema", ex);
            }

            tempWorker.ReportProgress( 40);

            #endregion

            #region YOGA

            tempWorker.ReportProgress( 45);

            try
            {
                if (!_view.YogaDatabase.IsNullOrEmpty())
                {
                    YogaMigration = new Services.Yoga.MigrationService(_view.YogaDatabase, connection);
                    YogaMigration.Logger = this.Logger;
                    this.YogaMigration.Migrate();
                    tempWorker.ReportProgress( 50);
                }
                else tempWorker.ReportProgress(55);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to complete Yoga import", ex);
            }


            #endregion
            
            #region Friends

         tempWorker.ReportProgress( 60);
            try
            {
                if (!_view.FriendsDatabase.IsNullOrEmpty())
                {
                    FriendsMigration = new Services.Friends.MigrationService(_view.FriendsDatabase, connection);
                    FriendsMigration.Logger = this.Logger;
                    this.FriendsMigration.Migrate();
                   tempWorker.ReportProgress( 70);
                }
                else tempWorker.ReportProgress( 75);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to complete Friends import", ex);
            }



            #endregion
            
            #region Prisoner

            tempWorker.ReportProgress( 80);

            try
            {
                if (!_view.PrisonerDatabase.IsNullOrEmpty())
                {
                    PrisonerMigration = new Services.Prisoner.MigrationService(_view.PrisonerDatabase, connection);
                    PrisonerMigration.Logger = this.Logger;
                    this.PrisonerMigration.Migrate();
                    tempWorker.ReportProgress( 90);
                }
                else tempWorker.ReportProgress( 90);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to complete Prisoner import", ex);
            }

            #endregion


           tempWorker.ReportProgress( 99);

            Thread.Sleep(2000);
            _view.Progress.PercentComplete = 100;
        }

      
       
    }
}
