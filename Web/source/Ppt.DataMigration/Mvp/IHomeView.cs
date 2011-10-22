using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ppt.DataMigration.Mvp
{
    public interface IHomeView
    {
        string SqlServerName { get;  }
        string SqlServerDatabase { get;  }
        string SqlServerUsername { get;  }
        string SqlServerPassword { get;  }
        string YogaDatabase { get; }
        string FriendsDatabase { get; }
        string PrisonerDatabase { get; }

        IEnumerable<string> Errors { get; set; }

        IProgressView Progress { get;  }

        void Action(HomeActions action);
        
    }
    public enum HomeActions
    {
        DisplayErrors,
        DisplayProgressBar,
        HideProgressBar

    }
}
