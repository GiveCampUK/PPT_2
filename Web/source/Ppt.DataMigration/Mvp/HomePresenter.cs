using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;
using Ppt.DataMigration.Services;
using System.Threading;
using System.Threading.Tasks;

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

        public IDatabaseMigrationService YogaMigration
        {get;set;
        }
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


            var t = Task.Factory.StartNew(() =>
            {
                _view.Progress.PercentComplete = 1;
                _view.Progress.Message = "Starting Migration Process";

                Thread.Sleep(4000);
                _view.Progress.PercentComplete = 50;
                _view.Progress.Message = "Getting There";
                Thread.Sleep(4000);
            });

            _view.Action(HomeActions.DisplayProgressBar);
            
            Task.Factory.ContinueWhenAll(new []{t}, result =>{
                    _view.Action(HomeActions.HideProgressBar);
            });
        }
    }
}
